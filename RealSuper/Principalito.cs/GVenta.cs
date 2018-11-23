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
    public partial class GVenta : Form
    {
        public Inventario padre { get; set; }
        public GVenta(Inventario hg)
        {
            padre = hg;
            InitializeComponent();
        }

        private void btnVolerVenta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGVRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (ExisteProducto(txtGVProductoId.Text))
            {
                if (ExisteCliente(txtGVClienteId.Text))
                {
                    if (ExisteVendedor(txtGVVendedorId.Text))
                    {
                        GuardarVenta();
                        this.padre.Loadito();
                        txtGVProductoId.Text = "";
                        txtGVVendedorId.Text = "";
                        txtGVCantidadProductos.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("El Codigo de Vendedor No Existe");
                    }
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
        public void GuardarVenta()
        {
            try
            {
                string cadena = @"Server=DESKTOP-LTJOGNT\ASUS;Database=mrbeimardb;Trusted_Connection=True;";
                SqlConnection conexion = new SqlConnection(cadena);
                try
                {
                    conexion.Open();
                    string sql = @"INSERT INTO Venta (ProductoId,ClienteId,VendedorId,CantidadVenta,FechaVenta)
                                VALUES(@ProductoId,@ClienteId,@VendedorId,@CantidadVenta,@FechaVenta)
                                UPDATE Producto SET CantidadProducto=((SELECT CantidadProducto FROM Producto WHERE ProductoId=@ProductoId)-(@CantidadVenta)) WHERE ProductoId=@ProductoId
                                UPDATE Venta SET ValorVenta=((SELECT ValorProducto FROM Producto WHERE ProductoId=@ProductoId)*(@CantidadVenta)) WHERE ProductoId=@ProductoId";

                    SqlCommand comando = new SqlCommand(sql, conexion);
                    //5. Definir los parámetros de la consulta

                    comando.Parameters.AddWithValue("@ProductoId", txtGVProductoId.Text);
                    comando.Parameters.AddWithValue("@ClienteId", txtGVClienteId.Text);
                    comando.Parameters.AddWithValue("@VendedorId", txtGVVendedorId.Text);
                    comando.Parameters.AddWithValue("@CantidadVenta", txtGVCantidadProductos.Text);
                    comando.Parameters.AddWithValue("@FechaVenta", txtGVFechaVentaPicker.Value);

                    //6. Ejecución del comando
                    //INSERT, DELETE, UPDATE -> ExecuteNonQuery
                    //SELECT -> DataReader
                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("La Venta Se Insertó, Correctamete ;)");
                        this.padre.Loadito();
                        txtGVProductoId.Text = "";
                        txtGVClienteId.Text = "";
                        txtGVVendedorId.Text = "";
                        txtGVCantidadProductos.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Encontramos un error, Guardando la Venta 1 :(");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hemos Encontrado Un Error, Guardando Venta 2 ({ex.Message})");
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
                MessageBox.Show($"Hay un error en guardado de venta {ex}");
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
        public bool ExisteCliente(string cliente)
        {
            //1. Creamos el objeto que permite la conexion
            string cadena = @"Server=DESKTOP-LTJOGNT\ASUS;Database=mrbeimardb;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                conexion.Open();
                string sql = @"SELECT ClienteId FROM Cliente WHERE ClienteId=@ClienteId";

                //4. Crear un Comando para enviar sentencias a la BD
                SqlCommand comando = new SqlCommand(sql, conexion);
                //5. Definir los parámetros de la consulta
                comando.Parameters.AddWithValue("@ClienteId", cliente);

                //6. Ejecución del comando
                //INSERT, DELETE, UPDATE -> ExecuteNonQuery
                //SELECT -> DataReader
                object data = comando.ExecuteScalar();

                return data != null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hemos encontrado un error, Verificando existencia cliente ! {ex.Message}");
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
        public bool ExisteVendedor(string vendedor)
        {
            //1. Creamos el objeto que permite la conexion
            string cadena = @"Server=DESKTOP-LTJOGNT\ASUS;Database=mrbeimardb;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                conexion.Open();
                string sql = @"SELECT VendedorId FROM Vendedor WHERE VendedorId=@VendedorId";

                //4. Crear un Comando para enviar sentencias a la BD
                SqlCommand comando = new SqlCommand(sql, conexion);
                //5. Definir los parámetros de la consulta
                comando.Parameters.AddWithValue("@VendedorId", vendedor);

                //6. Ejecución del comando
                //INSERT, DELETE, UPDATE -> ExecuteNonQuery
                //SELECT -> DataReader
                object data = comando.ExecuteScalar();

                return data != null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hemos encontrado un error, Verificando existencia Vendedor ! {ex.Message}");
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

        private void GVenta_Load(object sender, EventArgs e)
        {

        }
    }
}
