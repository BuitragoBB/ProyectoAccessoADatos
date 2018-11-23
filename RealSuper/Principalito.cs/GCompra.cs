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
    public partial class GCompra : Form
    {
        public Inventario padre { get; set; }
        public GCompra(Inventario fg)
        {
            padre = fg;
            InitializeComponent();
        }
        private void btnGCVolverCompra_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGCRegistrarCompra_Click(object sender, EventArgs e)
        {
            if (ExisteProducto(txtGCProductoId.Text))
            {
                if (ExisteProveedor(txtGCProveedorId.Text))
                {
                    GuardarCompra();
                    this.padre.Loadito();
                    txtGCProductoId.Text = "";
                    txtGCProveedorId.Text = "";
                    txtGCCantidadCompra.Text = "";
                }
                else
                {
                    MessageBox.Show("El Codigo de Cliente o Vendedor No Existe");
                }
            }
            else
            {
                MessageBox.Show("El Codigo de Producto No Existe");
            }
        }
        public void GuardarCompra()
        {
            try
            {
                string cadena = @"Server=DESKTOP-LTJOGNT\ASUS;Database=mrbeimardb;Trusted_Connection=True;";
                SqlConnection conexion = new SqlConnection(cadena);
                try
                {
                    conexion.Open();
                    string sql = @"INSERT INTO Compra (ProductoId,ProveedorId,CantidadCompra,FechaCompra)
                                VALUES(@ProductoId,@ProveedorId,@CantidadCompra,@FechaCompra)
                                UPDATE Producto SET CantidadProducto=((SELECT CantidadProducto FROM Producto WHERE ProductoId=@ProductoId)+(@CantidadCompra)) WHERE ProductoId=@ProductoId
                                UPDATE Compra SET ValorCompra=((SELECT ValorProducto FROM Producto WHERE ProductoId=@ProductoId)*(@CantidadCompra)) WHERE ProductoId=@ProductoId";

                    SqlCommand comando = new SqlCommand(sql, conexion);
                    //5. Definir los parámetros de la consulta

                    comando.Parameters.AddWithValue("@ProductoId", txtGCProductoId.Text);
                    comando.Parameters.AddWithValue("@ProveedorId", txtGCProveedorId.Text);
                    comando.Parameters.AddWithValue("@CantidadCompra", txtGCCantidadCompra.Text);
                    comando.Parameters.AddWithValue("@ValorCompra", txtGCCantidadCompra.Text);
                    comando.Parameters.AddWithValue("@FechaCompra", txtGCFechaTimer.Value);

                    //6. Ejecución del comando
                    //INSERT, DELETE, UPDATE -> ExecuteNonQuery
                    //SELECT -> DataReader
                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("La Compra Se Agregó, Correctamete ;)");
                        this.padre.Loadito();
                        txtGCProductoId.Text = "";
                        txtGCProveedorId.Text = "";
                        txtGCCantidadCompra.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Encontramos un error, Guardando la Compra 1 :(");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hemos Encontrado Un Error, Guardando compra 2 ({ex.Message})");
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
                MessageBox.Show($"Hay un error en guardado la compra {ex}");
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
                MessageBox.Show($"Hemos encontrado un error, Verificando existencia producto ! {ex.Message}");
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
        public bool ExisteProveedor(string proveedor)
        {
            //1. Creamos el objeto que permite la conexion
            string cadena = @"Server=DESKTOP-LTJOGNT\ASUS;Database=mrbeimardb;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                conexion.Open();
                string sql = @"SELECT ProveedorId FROM Proveedor WHERE ProveedorId=@ProveedorId";

                //4. Crear un Comando para enviar sentencias a la BD
                SqlCommand comando = new SqlCommand(sql, conexion);
                //5. Definir los parámetros de la consulta
                comando.Parameters.AddWithValue("@ProveedorId", proveedor);

                //6. Ejecución del comando
                //INSERT, DELETE, UPDATE -> ExecuteNonQuery
                //SELECT -> DataReader
                object data = comando.ExecuteScalar();

                return data != null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hemos encontrado un error, Verificando existencia proveedor ! {ex.Message}");
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
