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
    public partial class GEliminarVenta : Form
    {
        public Inventario padre { get; set; }
        public GEliminarVenta(Inventario hj)
        {
            padre = hj;
            InitializeComponent();
        }

        private void btnVolverVenta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {
            if (ExisteVenta(txtVentaIdEliminar.Text))
            {
                EliminarVenta();
            }
            else
            {
                MessageBox.Show("El Codigo de Venta No Existe");
            }
        }

        public void EliminarVenta()
        {
            try
            {
                string cadena = @"Server=DESKTOP-LTJOGNT\ASUS;Database=mrbeimardb;Trusted_Connection=True;";
                SqlConnection conexion = new SqlConnection(cadena);
                try
                {
                    conexion.Open();
                    string sql = @"DELETE FROM Venta WHERE VentaId=@VentaId";

                    SqlCommand comando = new SqlCommand(sql, conexion);
                    //5. Definir los parámetros de la consulta

                    comando.Parameters.AddWithValue("@VentaId", txtVentaIdEliminar.Text);

                    //6. Ejecución del comando
                    //INSERT, DELETE, UPDATE -> ExecuteNonQuery
                    //SELECT -> DataReader
                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("La Venta Se Eliminó Correctamete ;)");
                        this.padre.Loadito();
                        txtVentaIdEliminar.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Error Eliminando La Venta :(");
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

        public bool ExisteVenta(string venta)
        {
            //1. Creamos el objeto que permite la conexion
            string cadena = @"Server=DESKTOP-LTJOGNT\ASUS;Database=mrbeimardb;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                conexion.Open();
                string sql = @"SELECT VentaId FROM Venta WHERE VentaId=@VentaId";

                //4. Crear un Comando para enviar sentencias a la BD
                SqlCommand comando = new SqlCommand(sql, conexion);
                //5. Definir los parámetros de la consulta
                comando.Parameters.AddWithValue("@VentaId", venta);

                //6. Ejecución del comando
                //INSERT, DELETE, UPDATE -> ExecuteNonQuery
                //SELECT -> DataReader
                object data = comando.ExecuteScalar();

                return data != null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hemos encontrado un error, Verificando existencia venta ! {ex.Message}");
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
