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
    public partial class Functions3 : System.Web.UI.Page
    {
        static string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\FAC\pbd\cod\pbd-project\WebProjectPBD\WebProjectPBD\App_Data\db.mdf;Integrated Security=True";
        SqlConnection sqlConn = new SqlConnection(connString);
        SqlCommand cmd;
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            sqlConn.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT  * FROM Jucatori", sqlConn);
            dt = new DataTable();
            sqlDa.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();

            SqlDataAdapter sqlDa1 = new SqlDataAdapter("SELECT * FROM Joc", sqlConn);
            dt = new DataTable();
            sqlDa1.Fill(dt);
            GridView2.DataSource = dt;
            GridView2.DataBind();

            sqlConn.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            sqlConn.Open();
            SqlDataAdapter sqlDA2 = new SqlDataAdapter("SELECT * FROM Joc ORDER BY Data_inceput_joc ASC",sqlConn);
            dt = new DataTable();
            sqlDA2.Fill(dt);
            GridView2.DataSource = dt;
            GridView2.DataBind();
            sqlConn.Close();


        }

        

        protected void Button3_Click(object sender, EventArgs e)
        {
            sqlConn.Open();
            SqlDataAdapter sqlDA4 = new SqlDataAdapter("SELECT Id_joc,Tip_joc,Partida_totala,Data_inceput_joc,Data_sfarsit_joc,DATEDIFF(hour,Data_inceput_joc,Data_sfarsit_joc) AS Durata_joc FROM Joc WHERE Data_sfarsit_joc BETWEEN '01/01/2010' AND '04/01/2010' ORDER BY Tip_joc,Data_inceput_joc ASC", sqlConn);
            dt = new DataTable();

            sqlDA4.Fill(dt);
            GridView2.DataSource = dt;
            GridView2.DataBind();

            sqlConn.Close();

        }
       


    }
}