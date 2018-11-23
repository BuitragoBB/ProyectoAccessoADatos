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
    public partial class GProducto : Form
    {
        public Inventario padres { get; set; }
        public GProducto(Inventario gac)
        {
            padres = gac;
            InitializeComponent();
        }

        private void btnGPVolverProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGPRegistrarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (ExisteProducto(txtGPNombreProducto.Text))
                {
                    MessageBox.Show("Este Producto Ya Esta Registrado ");
                }
                else
                {
                    GuardarProducto();
                    this.padres.Loadito();
                    txtGPNombreProducto.Text = "";
                    txtGPCantidadProducto.Text = "";
                    txtGPValorProducto.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en : {ex}");
            }
            
        }
        public void GuardarProducto()
        {
            try
            {
                string cadena = @"Server=DESKTOP-LTJOGNT\ASUS;Database=mrbeimardb;Trusted_Connection=True;";
                SqlConnection conexion = new SqlConnection(cadena);
                try
                {
                    conexion.Open();
                    string sql = @"INSERT INTO Producto (NombreProducto,CantidadProducto,ValorProducto)
                                VALUES(@NombreProducto,@CantidadProducto,@ValorProducto)";

                    SqlCommand comando = new SqlCommand(sql, conexion);
                    //5. Definir los parámetros de la consulta

                    comando.Parameters.AddWithValue("@NombreProducto", txtGPNombreProducto.Text);
                    comando.Parameters.AddWithValue("@CantidadProducto", txtGPCantidadProducto.Text);
                    comando.Parameters.AddWithValue("@ValorProducto", txtGPValorProducto.Text);

                    //6. Ejecución del comando
                    //INSERT, DELETE, UPDATE -> ExecuteNonQuery
                    //SELECT -> DataReader
                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("El Producto Se Insertó, Correctamete ;)");
                    }
                    else
                    {
                        MessageBox.Show("Encontramos un error, Guardando el Producto 1 :(");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hemos Encontrado Un Error, Guardando Producto 2 {ex.Message}");
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

        public bool ExisteProducto(string producto)
        {
            //1. Creamos el objeto que permite la conexion
            string cadena = @"Server=DESKTOP-LTJOGNT\ASUS;Database=mrbeimardb;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                conexion.Open();
                string sql = @"SELECT NombreProducto FROM Producto WHERE NombreProducto=@NombreProducto";

                //4. Crear un Comando para enviar sentencias a la BD
                SqlCommand comando = new SqlCommand(sql, conexion);
                //5. Definir los parámetros de la consulta
                comando.Parameters.AddWithValue("@NombreProducto", producto);

                //6. Ejecución del comando
                //INSERT, DELETE, UPDATE -> ExecuteNonQuery
                //SELECT -> DataReader
                object data = comando.ExecuteScalar();

                return data != null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hemos encontrado un error, Verificando NombreProducto ! {ex.Message}");
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
