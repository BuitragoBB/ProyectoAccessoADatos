using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principalito.cs
{
    public partial class GProveedor : Form
    {
        public Inventario padre { get; set; }
        public GProveedor(Inventario par)
        {
            padre = par;
            InitializeComponent();
        }
        private void btnVolverProveedor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                if (ExisteProveedor(txtCedulaProveedor.Text))
                {
                    MessageBox.Show("Esta Cedula Ya Esta Registrada ");
                }
                else
                {
                    GuardarProveedor();
                    this.padre.Loadito();
                    txtNombreProveedor.Text = "";
                    txtApellidoProveedor.Text = "";
                    txtTelefonoProveedor.Text = "";
                    txtCedulaProveedor.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No Pueden Queadar Campos Vacios :{ex}");
            }
            
        }

        public void GuardarProveedor()
        {
            try
            {
                string cadena = @"Server=DESKTOP-LTJOGNT\ASUS;Database=mrbeimardb;Trusted_Connection=True;";
                SqlConnection conexion = new SqlConnection(cadena);
                try
                {
                    conexion.Open();
                    string sql = @"INSERT INTO Proveedor (NombreProveedor,ApellidoProveedor,TelefonoProveedor,CedulaProveedor)
                                VALUES(@NombreProveedor,@ApellidoProveedor,@TelefonoProveedor,@CedulaProveedor)";

                    SqlCommand comando = new SqlCommand(sql, conexion);
                    //5. Definir los parámetros de la consulta

                    comando.Parameters.AddWithValue("@NombreProveedor", txtNombreProveedor.Text);
                    comando.Parameters.AddWithValue("@ApellidoProveedor", txtApellidoProveedor.Text);
                    comando.Parameters.AddWithValue("@TelefonoProveedor", txtTelefonoProveedor.Text);
                    comando.Parameters.AddWithValue("@CedulaProveedor", txtCedulaProveedor.Text);

                    //6. Ejecución del comando
                    //INSERT, DELETE, UPDATE -> ExecuteNonQuery
                    //SELECT -> DataReader
                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("El Proveedor Se Insertó, Correctamete ;)");
                    }
                    else
                    {
                        MessageBox.Show("Encontramos un error, Guardando el Proveedor 1 :(");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hemos Encontrado Un Error, Guardando Proveedor 2 ({ex.Message})");
                }
                finally
                {
                    if (conexion.State != ConnectionState.Closed)
                    {
                        conexion.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hay un error en guardado de proveedor {ex}");
            }
        }

        public bool ExisteProveedor(string proveedor)
        {
            //1. Creamos el objeto que permite la conexion
            string cadena = @"Server=DESKTOP-LTJOGNT\ASUS;Database=mrbeimardb;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                conexion.Open();
                string sql = @"SELECT CedulaProveedor FROM Proveedor WHERE CedulaProveedor=@CedulaProveedor";

                //4. Crear un Comando para enviar sentencias a la BD
                SqlCommand comando = new SqlCommand(sql, conexion);
                //5. Definir los parámetros de la consulta
                comando.Parameters.AddWithValue("@CedulaProveedor", proveedor);

                //6. Ejecución del comando
                //INSERT, DELETE, UPDATE -> ExecuteNonQuery
                //SELECT -> DataReader
                object data = comando.ExecuteScalar();

                return data != null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hemos encontrado un error, Verificando la CedulaProveedor ! {ex.Message}");
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }

            return false;
        }
    }
}
