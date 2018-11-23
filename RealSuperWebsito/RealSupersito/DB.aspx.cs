using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RealSupersito
{
    public partial class DB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargaVentas();
            CargaCompras();
            CargaClientes();
        }
        public void CargaVentas()
        {
            WebSito.BDaticosSoapClient WS = new WebSito.BDaticosSoapClient();
            DataSet ds = WS.GetData();
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        public void CargaCompras()
        {
            WebCompra.BDaticosSoapClient WC = new WebCompra.BDaticosSoapClient();
            DataSet cac = WC.GetCompras();
            GridView2.DataSource = cac.Tables[0];
            GridView2.DataBind();
        }
        public void CargaClientes()
        {
            WebCliente.BDaticosSoapClient WCl = new WebCliente.BDaticosSoapClient();
            DataSet ccl = WCl.GetClientes();
            GridView3.DataSource = ccl.Tables[0];
            GridView3.DataBind();
        }
    }
}