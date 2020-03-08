using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;


namespace asp2
{
    public partial class Default : System.Web.UI.Page
    {
        crud gc = new crud();
        public void mostrardatos()
        {
            gc.LlenarGrid("select * from docentes", "docentes");
            GridView1.DataSource = gc.ds.Tables["docentes"];
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            mostrardatos();
        }

    }
}