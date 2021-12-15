using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebProjectPBD
{
    public partial class Sah : System.Web.UI.Page
    {
        static string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Info An 3\PBD\pbd-project\WebProjectPBD\WebProjectPBD\App_Data\db.mdf;Integrated Security=True";
        SqlConnection sqlConn = new SqlConnection(connString);
        SqlCommand cmd;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void IncepeJoc_btn_Click(object sender, EventArgs e)
        {
            if (Nume1_tb.Text == "" || Nume2_tb.Text == "")
            {
                Label8.Text = "Numele nu pot fi lăsate necompletate.";
                Label8.Visible = true;
            } else if (DataNasterii1_tb.Text=="" || DataNasterii2_tb.Text=="")
            {
                Label8.Text = "Mai verifica data nasterii la unul din cei doi jucatori";
                Label8.Visible = true;
            }
            else
            {
                sqlConn.Open();
                cmd = new SqlCommand("insert into Jucatori (Nume,Data_nasterii,Data_inregistrarii) values (@nume,@data_n,@data_i)", sqlConn);
                cmd.Parameters.AddWithValue("@nume", Nume1_tb.Text.Trim());
                cmd.Parameters.AddWithValue("@data_n", Convert.ToDateTime(DataNasterii1_tb.Text));

                cmd.Parameters.AddWithValue("@data_i", DateTime.Now.ToString("yyyy-MM-dd"));

                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("insert into Jucatori (Nume,Data_nasterii,Data_inregistrarii) values (@nume1,@data_n1,@data_i1)", sqlConn);
                cmd.Parameters.AddWithValue("@nume1", Nume2_tb.Text.Trim());
                cmd.Parameters.AddWithValue("@data_n1", Convert.ToDateTime(DataNasterii1_tb.Text));
                cmd.Parameters.AddWithValue("@data_i1", DateTime.Now.ToString("yyyy-MM-dd"));

                cmd.ExecuteNonQuery();

                sqlConn.Close();
            }
        }


    }
}