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
    public partial class GUpdateProducto : Form
    {
        public Inventario padre { get; set; }
        public GUpdateProducto(Inventario ed)
        {
            padre = ed;
            InitializeComponent();
        }

        private void btnVolverEditarProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizarProducto_Click(object sender, EventArgs e)
        {
            if (ExisteProducto(txtCodigoProductoEditar.Text))
            {
                ActualizarProducto();
            }
            else
            {
                MessageBox.Show("El Codigo de Producto No Existe");
            }
        }

        public void ActualizarProducto()
        {
            try
            {
                string cadena = @"Server=DESKTOP-LTJOGNT\ASUS;Database=mrbeimardb;Trusted_Connection=True;";
                SqlConnection conexion = new SqlConnection(cadena);
                try
                {
                    conexion.Open();
                    string sql = @"UPDATE Producto SET NombreProducto=@NombreProducto,CantidadProducto=@CantidadProducto,ValorProducto=@ValorProducto WHERE ProductoId=@ProductoId";

                    SqlCommand comando = new SqlCommand(sql, conexion);
                    //5. Definir los parámetros de la consulta

                    comando.Parameters.AddWithValue("@ProductoId", txtCodigoProductoEditar.Text);
                    comando.Parameters.AddWithValue("@NombreProducto", txtNombreProductoEditar.Text);
                    comando.Parameters.AddWithValue("@CantidadProducto", txtCantidadProductoEditar.Text);
                    comando.Parameters.AddWithValue("@ValorProducto", txtValorProductoEditar.Text);

                    //6. Ejecución del comando
                    //INSERT, DELETE, UPDATE -> ExecuteNonQuery
                    //SELECT -> DataReader
                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("El Producto Se Actualizó Correctamete ;)");
                        this.padre.Loadito();
                        txtCodigoProductoEditar.Text = "";
                        txtNombreProductoEditar.Text = "";
                        txtCantidadProductoEditar.Text = "";
                        txtValorProductoEditar.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Error Actualizando el Producto :(");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No Pueden quedar campos Vacios {ex}");
                }
                finally
                {
                    if (conexion.State != ConnectionState.Closed)
                    {
                        conexion.Close();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"No Pueden Quedar Campos Vacios");
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
                string sql = @"SELECT ProductoId FROM Producto WHERE ProductoId=@ProductoId";

                //4. Crear un Comando para enviar sentencias a la BD
                SqlCommand comando = new SqlCommand(sql, conexion);
                //5. Definir los parámetros de la consulta
                comando.Parameters.AddWithValue("@ProductoId", producto);

                //6. Ejecución del comando
                //INSERT, DELETE, UPDATE -> ExecuteNonQuery
                //SELECT -> DataReader
                object data = comando.ExecuteScalar();

                return data != null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en Verificacion de Producto ! {ex}");
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
