using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WebProjectPBD
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        static string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\FAC\pbd\cod\pbd-project\WebProjectPBD\WebProjectPBD\App_Data\db.mdf;Integrated Security=True";
        SqlConnection sqlConn = new SqlConnection(connString);
        SqlCommand cmd;
        DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            sqlConn.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT  * FROM Joc", sqlConn);
            dt = new DataTable();
            sqlDa.Fill(dt);
            GridView3.DataSource = dt;
            GridView3.DataBind();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {


        }

        }
}