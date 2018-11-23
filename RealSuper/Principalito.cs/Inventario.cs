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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }
        private void Inventario_Load(object sender, EventArgs e)
        {
            Loadito();
        }
        public void Loadito()
        {
            List<Cliente> clientesotes = CargarClientes();
            this.dataGridView3.DataSource = clientesotes;

            List<Producto> productotes = CargarProductos();
            this.dataGridView1.DataSource = productotes;

            List<Vendedor> vendedorotes = CargarVendedores();
            this.dataGridView4.DataSource = vendedorotes;

            List<Venta> ventotas = CargarVentas();
            this.dataGridView2.DataSource = ventotas;

            List<Proveedor> provedorotes = CargarProveedores();
            this.dataGridView5.DataSource = provedorotes;

            List<Compra> comprototas = CargarCompras();
            this.dataGridView6.DataSource = comprototas;
        }

        public List<Cliente> CargarClientes()
        {
            List<Cliente> losclientes = new List<Cliente>();
            //1. Creamos el objeto que permite la conexion
            string cadena = @"Server=DESKTOP-LTJOGNT\ASUS;Database=mrbeimardb;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                //2. Abrimos la conexión
                conexion.Open();

                //3. Construimos la sentencia DML (SELECT, INSERT, DELETE, UPDATE)
                string sql = @"SELECT ClienteId,NombreCliente,ApellidoCliente,TelefonoCliente,CedulaCliente FROM  Cliente";

                //4. Crear un Comando para enviar sentencias a la BD
                SqlCommand comando = new SqlCommand(sql, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    int Id = reader.GetInt32(0);
                    string Nombre = reader.GetString(1);
                    string Apellido = reader.GetString(2);
                    string Telefono = reader.GetString(3);
                    string Cedula = reader.GetString(4);

                    Cliente cliente = new Cliente
                    {
                        ClienteId = Id,
                        NombreCliente = Nombre,
                        ApellidoCliente = Apellido,
                        TelefonoCliente = Telefono,
                        CedulaCliente = Cedula
                    };
                    losclientes.Add(cliente);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en carga de Clientes {ex.Message}");
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
            return losclientes;
        }
        public List<Vendedor> CargarVendedores()
        {
            List<Vendedor> losvendedores = new List<Vendedor>();
            //1. Creamos el objeto que permite la conexion
            string cadena = @"Server=DESKTOP-LTJOGNT\ASUS;Database=mrbeimardb;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                //2. Abrimos la conexión
                conexion.Open();

                //3. Construimos la sentencia DML (SELECT, INSERT, DELETE, UPDATE)
                string sql = @"SELECT VendedorId,NombreVendedor,ApellidoVendedor,TelefonoVendedor,CedulaVendedor FROM Vendedor";

                //4. Crear un Comando para enviar sentencias a la BD
                SqlCommand comando = new SqlCommand(sql, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    int Id = reader.GetInt32(0);
                    string Nombre = reader.GetString(1);
                    string Apellido = reader.GetString(2);
                    string Telefono = reader.GetString(3);
                    string Cedula = reader.GetString(4);

                    Vendedor vendedor = new Vendedor
                    {
                        VendedorId = Id,
                        NombreVendedor = Nombre,
                        ApellidoVendedor = Apellido,
                        TelefonoVendedor = Telefono,
                        CedulaVendedor = Cedula
                    };
                    losvendedores.Add(vendedor);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en carga de Vendedores : {ex.Message}");
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
            return losvendedores;
        }
        public List<Proveedor> CargarProveedores()
        {
            List<Proveedor> losproveedores = new List<Proveedor>();
            //1. Creamos el objeto que permite la conexion
            string cadena = @"Server=DESKTOP-LTJOGNT\ASUS;Database=mrbeimardb;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                //2. Abrimos la conexión
                conexion.Open();

                //3. Construimos la sentencia DML (SELECT, INSERT, DELETE, UPDATE)
                string sql = @"SELECT ProveedorId,NombreProveedor,ApellidoProveedor,TelefonoProveedor,CedulaProveedor FROM Proveedor";

                //4. Crear un Comando para enviar sentencias a la BD
                SqlCommand comando = new SqlCommand(sql, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    int Id = reader.GetInt32(0);
                    string Nombre = reader.GetString(1);
                    string Apellido = reader.GetString(2);
                    string Telefono = reader.GetString(3);
                    string Cedula = reader.GetString(4);

                    Proveedor proveedor = new Proveedor
                    {
                        ProveedorId = Id,
                        NombreProveedor = Nombre,
                        ApellidoProveedor = Apellido,
                        TelefonoProveedor = Telefono,
                        CedulaProveedor = Cedula
                    };
                    losproveedores.Add(proveedor);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en carga de Proveedores {ex.Message}");
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
            return losproveedores;
        }
        public List<Producto> CargarProductos()
        {
            List<Producto> losproductos = new List<Producto>();
            //1. Creamos el objeto que permite la conexion
            string cadena = @"Server=DESKTOP-LTJOGNT\ASUS;Database=mrbeimardb;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                //2. Abrimos la conexión
                conexion.Open();

                //3. Construimos la sentencia DML (SELECT, INSERT, DELETE, UPDATE)
                string sql = @"SELECT ProductoId,NombreProducto,CantidadProducto,ValorProducto FROM Producto";

                //4. Crear un Comando para enviar sentencias a la BD
                SqlCommand comando = new SqlCommand(sql, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    int Id = reader.GetInt32(0);
                    string NombreProducto = reader.GetString(1);
                    int Cantidad = reader.GetInt32(2);
                    int Valor = reader.GetInt32(3);

                    Producto producto = new Producto
                    {
                        ProductoId = Id,
                        NombreProducto = NombreProducto,
                        CantidadProducto = Cantidad,
                        ValorProducto = Valor
                    };
                    losproductos.Add(producto);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en carga de productos {ex.Message}");
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
            return losproductos;
        }
        public List<Venta> CargarVentas()
        {            
            List<Venta> lasventas = new List<Venta>();
            //1. Creamos el objeto que permite la conexion
            string cadena = @"Server=DESKTOP-LTJOGNT\ASUS;Database=mrbeimardb;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                //2. Abrimos la conexión
                conexion.Open();

                //3. Construimos la sentencia DML (SELECT, INSERT, DELETE, UPDATE)
                string sql = @"SELECT VentaId,ProductoId,ClienteId,VendedorId,CantidadVenta,ValorVenta,FechaVenta FROM Venta";

                //4. Crear un Comando para enviar sentencias a la BD
                SqlCommand comando = new SqlCommand(sql, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    int ventaid = reader.GetInt32(0);
                    int productoid = reader.GetInt32(1);
                    int clienteid = reader.GetInt32(2);
                    int vendedorid = reader.GetInt32(3);
                    int cantidadventa = reader.GetInt32(4);
                    int valorventa = reader.GetInt32(5);
                    DateTime fechaventa = reader.GetDateTime(6);

                    Venta venta = new Venta
                    {
                        VentaId = ventaid,
                        ProductoId = productoid,
                        ClienteId = clienteid,
                        VendedorId = vendedorid,
                        CantidadVenta = cantidadventa,
                        ValorTotal = valorventa,
                        FechaVenta = fechaventa
                    };
                    lasventas.Add(venta);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en carga de ventas {ex.Message}");
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
            return lasventas;
        }
        public List<Compra> CargarCompras()
        {
            List<Compra> lascompras = new List<Compra>();
            //1. Creamos el objeto que permite la conexion
            string cadena = @"Server=DESKTOP-LTJOGNT\ASUS;Database=mrbeimardb;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                //2. Abrimos la conexión
                conexion.Open();

                //3. Construimos la sentencia DML (SELECT, INSERT, DELETE, UPDATE)
                string sql = @"SELECT CompraId,ProductoId,ProveedorId,CantidadCompra,ValorCompra,FechaCompra FROM Compra";

                //4. Crear un Comando para enviar sentencias a la BD
                SqlCommand comando = new SqlCommand(sql, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    int compraid = reader.GetInt32(0);
                    int productoid = reader.GetInt32(1);
                    int proveedorid = reader.GetInt32(2);
                    int cantidadcompra = reader.GetInt32(3);
                    int valorcompra = reader.GetInt32(4);
                    DateTime fechaventa = reader.GetDateTime(5);

                    Compra venta = new Compra
                    {
                        CompraId = compraid,
                        ProductoId = productoid,
                        ProveedorId = proveedorid,
                        CantidadCompra = cantidadcompra,
                        ValorCompra = valorcompra,
                        FechaCompra = fechaventa
                    };
                    lascompras.Add(venta);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en carga de Compras {ex.Message}");
            }
            finally
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                }
            }
            return lascompras;
        }



















        private void btnRegistrarP_Click(object sender, EventArgs e)
        {
            GProducto regp = new GProducto(this);
            regp.ShowDialog();
        }
        private void btnRegistrarCom_Click(object sender, EventArgs e)
        {
            GCompra rec = new GCompra(this);
            rec.ShowDialog();
        }
        private void btnRegistrarVen_Click(object sender, EventArgs e)
        {
            GVenta rev = new GVenta(this);
            rev.ShowDialog();
        }
        private void btnRegistrarCli_Click(object sender, EventArgs e)
        {
            GCliente recc = new GCliente(this);
            recc.ShowDialog();
        }
        private void btnRegistrarProvee_Click(object sender, EventArgs e)
        {
            GProveedor rep = new GProveedor(this);
            rep.ShowDialog();
        }
        private void btnRegistrarVende_Click(object sender, EventArgs e)
        {
            GVendedor revv = new GVendedor(this);
            revv.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GEliminarVenta el = new GEliminarVenta(this);
            el.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GUpdateProducto up = new GUpdateProducto(this);
            up.ShowDialog();
        }
    }
}
