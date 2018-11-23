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
    public partial class GVendedor : Form
    {
        public Inventario padre { get; set; }
        public GVendedor(Inventario carg)
        {
            padre = carg;
            InitializeComponent();
        }
        private void btnVolverVendedor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrarVendedor_Click(object sender, EventArgs e)
        {
            if (ExisteVendedor(txtGCedulaVendedor.Text))
            {
                MessageBox.Show("Esta Cedula Ya Esta Registrada ");
            }
            else
            {
                GuardarVendedor();
                this.padre.Loadito();
                txtGNombreVendedor.Text = "";
                txtGApellidoVendedor.Text = "";
                txtGTelefonoVendedor.Text = "";
                txtGCedulaVendedor.Text = "";
            }
        }
        
        public void GuardarVendedor()
        {
            try
            {
                string cadena = @"Server=DESKTOP-LTJOGNT\ASUS;Database=mrbeimardb;Trusted_Connection=True;";
                SqlConnection conexion = new SqlConnection(cadena);
                try
                {
                    conexion.Open();
                    string sql = @"INSERT INTO Vendedor (NombreVendedor,ApellidoVendedor,TelefonoVendedor,CedulaVendedor)
                                VALUES(@NombreVendedor,@ApellidoVendedor,@TelefonoVendedor,@CedulaVendedor)";

                    SqlCommand comando = new SqlCommand(sql, conexion);
                    //5. Definir los parámetros de la consulta

                    comando.Parameters.AddWithValue("@NombreVendedor", txtGNombreVendedor.Text);
                    comando.Parameters.AddWithValue("@ApellidoVendedor", txtGApellidoVendedor.Text);
                    comando.Parameters.AddWithValue("@TelefonoVendedor", txtGTelefonoVendedor.Text);
                    comando.Parameters.AddWithValue("@CedulaVendedor", txtGCedulaVendedor.Text);

                    //6. Ejecución del comando
                    //INSERT, DELETE, UPDATE -> ExecuteNonQuery
                    //SELECT -> DataReader
                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("El Vendedor Se Insertó, Correctamete ;)");
                    }
                    else
                    {
                        MessageBox.Show("Encontramos un error, Guardando el Vendedor 1 :(");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hemos Encontrado Un Error, Guardando Vendedor 2 ({ex.Message})");
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
                MessageBox.Show($"Hay un error en guardado de vendedor {ex}");
            }
        }

        public bool ExisteVendedor(string vendedor)
        {
            //1. Creamos el objeto que permite la conexion
            string cadena = @"Server=DESKTOP-LTJOGNT\ASUS;Database=mrbeimardb;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                conexion.Open();
                string sql = @"SELECT CedulaVendedor FROM Vendedor WHERE CedulaVendedor=@CedulaVendedor";

                //4. Crear un Comando para enviar sentencias a la BD
                SqlCommand comando = new SqlCommand(sql, conexion);
                //5. Definir los parámetros de la consulta
                comando.Parameters.AddWithValue("@CedulaVendedor", vendedor);

                //6. Ejecución del comando
                //INSERT, DELETE, UPDATE -> ExecuteNonQuery
                //SELECT -> DataReader
                object data = comando.ExecuteScalar();

                return data != null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hemos encontrado un error, Verificando la CedulaVendedor ! {ex.Message}");
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
