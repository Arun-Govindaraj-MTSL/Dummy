using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Dummy
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void showRecord_Click(object sender, EventArgs e)
        {
            string ConString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            SqlConnection con = new SqlConnection(ConString);
            string querystring = "Select * from Product";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(querystring, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridRecord.DataSource = dt;
            gridRecord.DataBind();
        }
    }
}