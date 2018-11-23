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
    public partial class GCliente : Form
    {
        public Inventario padre { get; set; }
        public GCliente(Inventario carguita)
        {
            padre = carguita;
            InitializeComponent();
        }
        private void btnVolverCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGCRegistrarCliente_Click(object sender, EventArgs e)
        {
            if (ExisteCliente(txtGCCedulaCliente.Text))
            {
                MessageBox.Show("Esta Cedula Ya Esta Registrada ");
            }
            else
            {
                GuardarCliente();
                this.padre.Loadito();
                txtGCNombreCliente.Text = "";
                txtGCApellidoCliente.Text = "";
                txtGCTelefonoCliente.Text = "";
                txtGCCedulaCliente.Text = "";
            }
        }


        public void GuardarCliente()
        {
            try
            {
                string cadena = @"Server=DESKTOP-LTJOGNT\ASUS;Database=mrbeimardb;Trusted_Connection=True;";
                SqlConnection conexion = new SqlConnection(cadena);
                try
                {
                    conexion.Open();
                    string sql = @"INSERT INTO Cliente (NombreCliente,ApellidoCliente,TelefonoCliente,CedulaCliente)
                                VALUES(@NombreCliente,@ApellidoCliente,@TelefonoCliente,@CedulaCliente)";

                    SqlCommand comando = new SqlCommand(sql, conexion);
                    //5. Definir los parámetros de la consulta

                    comando.Parameters.AddWithValue("@NombreCliente", txtGCNombreCliente.Text);
                    comando.Parameters.AddWithValue("@ApellidoCliente", txtGCApellidoCliente.Text);
                    comando.Parameters.AddWithValue("@TelefonoCliente", txtGCTelefonoCliente.Text);
                    comando.Parameters.AddWithValue("@CedulaCliente", txtGCCedulaCliente.Text);

                    //6. Ejecución del comando
                    //INSERT, DELETE, UPDATE -> ExecuteNonQuery
                    //SELECT -> DataReader
                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("El Cliente Se Insertó, Correctamete ;)");
                    }
                    else
                    {
                        MessageBox.Show("Encontramos un error, Guardando el Cliente 1 :(");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hemos Encontrado Un Error, Guardando Cliente 2 ({ex.Message})");
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
                MessageBox.Show($"Hay un error en guardado de cliente {ex}");
            }
        }

        public bool ExisteCliente(string cliente)
        {
            //1. Creamos el objeto que permite la conexion
            string cadena = @"Server=DESKTOP-LTJOGNT\ASUS;Database=mrbeimardb;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                conexion.Open();
                string sql = @"SELECT CedulaCliente FROM Cliente WHERE CedulaCliente=@CedulaCliente";

                //4. Crear un Comando para enviar sentencias a la BD
                SqlCommand comando = new SqlCommand(sql, conexion);
                //5. Definir los parámetros de la consulta
                comando.Parameters.AddWithValue("@CedulaCliente", cliente);

                //6. Ejecución del comando
                //INSERT, DELETE, UPDATE -> ExecuteNonQuery
                //SELECT -> DataReader
                object data = comando.ExecuteScalar();

                return data != null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hemos encontrado un error, Verificando la Cedula ! {ex.Message}");
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
