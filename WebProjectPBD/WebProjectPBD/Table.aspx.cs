using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProjectPBD
{
    public partial class Table : System.Web.UI.Page
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
            }
            else if (DataNasterii1_tb.Text == "" || DataNasterii2_tb.Text == "")
            {
                Label8.Text = "Mai verifica data nasterii la unul din cei doi jucatori";
                Label8.Visible = true;
            }
            else if (NrRunde_tb.Text == "" || Int32.Parse(NrRunde_tb.Text.ToString()) % 2 == 0) 
            {
                Label8.Text = "Numarul de runde trebuie sa fie impar.";
                Label8.Visible = true;
            }
            else
            {
                sqlConn.Open();
                cmd = new SqlCommand("insert into Jucatori (Nume,Data_nasterii,Data_inregistrarii) values (@nume,@data_n,@data_i)", sqlConn);
                cmd.Parameters.AddWithValue("@nume", Nume1_tb.Text.Trim());
                cmd.Parameters.AddWithValue("@data_n", Convert.ToDateTime(DataNasterii1_tb.Text));

                cmd.Parameters.AddWithValue("@data_i", DateTime.Now);

                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("insert into Jucatori (Nume,Data_nasterii,Data_inregistrarii) values (@nume1,@data_n1,@data_i1)", sqlConn);
                cmd.Parameters.AddWithValue("@nume1", Nume2_tb.Text.Trim());
                cmd.Parameters.AddWithValue("@data_n1", Convert.ToDateTime(DataNasterii1_tb.Text));
                cmd.Parameters.AddWithValue("@data_i1", DateTime.Now);

                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("insert into Joc (Tip_joc,Jucator1,Jucator2,Partida_curenta,Partida_totala,Data_inceput_joc,Scor_jucator1,Scor_jucator2) values (@tip,@nume,@nume1,@partida_cur,@partida_tot,@data_i_j,@scor_j1,@scor_j2)", sqlConn);
                cmd.Parameters.AddWithValue("@tip", "1");
                cmd.Parameters.AddWithValue("@nume", Nume1_tb.Text.Trim());
                cmd.Parameters.AddWithValue("@nume1", Nume2_tb.Text.Trim());
                cmd.Parameters.AddWithValue("@partida_cur", "0");
                cmd.Parameters.AddWithValue("@partida_tot", NrRunde_tb.Text.Trim());
                cmd.Parameters.AddWithValue("@data_i_j", DateTime.Now);
                cmd.Parameters.AddWithValue("@scor_j1", "0");
                cmd.Parameters.AddWithValue("@scor_j2", "0");

                cmd.ExecuteNonQuery();

                sqlConn.Close();
                Response.Redirect("JocActiv.aspx");
            }
        }
    }
}