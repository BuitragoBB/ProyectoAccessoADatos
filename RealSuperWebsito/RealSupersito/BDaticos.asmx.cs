using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace RealSupersito
{
    /// <summary>
    /// Descripción breve de BDaticos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class BDaticos : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        public DataSet GetData()
        {
            string cadena = @"Server=DESKTOP-LTJOGNT\ASUS;Database=mrbeimardb;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Venta", cadena);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        [WebMethod]
        public DataSet GetCompras()
        {
            string cadena = @"Server=DESKTOP-LTJOGNT\ASUS;Database=mrbeimardb;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);
            SqlDataAdapter co = new SqlDataAdapter("SELECT * FROM Compra", cadena);
            DataSet cargaco = new DataSet();
            co.Fill(cargaco);
            return cargaco;
        }
        [WebMethod]
        public DataSet GetClientes()
        {
            string cadena = @"Server=DESKTOP-LTJOGNT\ASUS;Database=mrbeimardb;Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);
            SqlDataAdapter ccli = new SqlDataAdapter("SELECT * FROM Cliente", cadena);
            DataSet cargacli = new DataSet();
            ccli.Fill(cargacli);
            return cargacli;
        }
    }
}
