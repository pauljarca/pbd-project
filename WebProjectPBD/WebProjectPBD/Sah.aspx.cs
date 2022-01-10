using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace WebProjectPBD
{
    public partial class Sah : System.Web.UI.Page
    {
        static string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Info An 3\PBD\pbd-project\WebProjectPBD\WebProjectPBD\App_Data\db.mdf;Integrated Security=True";
        SqlConnection sqlConn = new SqlConnection(connString);
        SqlCommand cmd;
        private int id1 = 0;
        private int id2 = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            


        }

        protected void IncepeJoc_btn_Click(object sender, EventArgs e)
        {
            if (Nume1_tb.Text == "" || Nume2_tb.Text == "")
            {
                Label8.Text = "Numele nu pot fi lăsate necompletate.";
                Label8.Visible = true;
            } else if ((DataNasterii1_tb.Visible==true && DataNasterii1_tb.Text=="") || (DataNasterii2_tb.Visible == true && DataNasterii2_tb.Text == ""))
            {
                Label8.Text = "Mai verifica data nasterii la unul din cei doi jucatori";
                Label8.Visible = true;
            } else if (Int32.Parse(NrRunde_tb.Text.ToString())%2==0)
            {
                Label8.Text = "Numarul de runde trebuie sa fie impar.";
                Label8.Visible = true;
            }
            else
            {
                sqlConn.Open();
                if (Nume1_tb.Enabled == true)
                {
                    cmd = new SqlCommand(
                        "insert into Jucatori (Nume,Data_nasterii,Data_inregistrarii) values (@nume,@data_n,@data_i)",
                        sqlConn);
                    cmd.Parameters.AddWithValue("@nume", Nume1_tb.Text.Trim());
                    cmd.Parameters.AddWithValue("@data_n", Convert.ToDateTime(DataNasterii1_tb.Text));
                    cmd.Parameters.AddWithValue("@data_i", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }

                if (Nume2_tb.Enabled == true)
                {
                    cmd = new SqlCommand(
                        "insert into Jucatori (Nume,Data_nasterii,Data_inregistrarii) values (@nume1,@data_n1,@data_i1)",
                        sqlConn);
                    cmd.Parameters.AddWithValue("@nume1", Nume2_tb.Text.Trim());
                    cmd.Parameters.AddWithValue("@data_n1", Convert.ToDateTime(DataNasterii1_tb.Text));
                    cmd.Parameters.AddWithValue("@data_i1", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }

                cmd = new SqlCommand("insert into Joc (Tip_joc,Jucator1,Jucator2,Partida_curenta,Partida_totala,Data_inceput_joc,Scor_jucator1,Scor_jucator2) values (@tip,@nume,@nume1,@partida_cur,@partida_tot,@data_i_j,@scor_j1,@scor_j2)", sqlConn);
                cmd.Parameters.AddWithValue("@tip", "0");
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

        protected void CautaJucator1_btn_Click(object sender, EventArgs e)
        {
            if (Nume1_tb.Text == "")
            {
                Label8.Text = "Numele nu pot fi lăsate necompletate.";
                Label8.Visible = true;
            }
            else
            {
                sqlConn.Open();
                cmd = new SqlCommand("SELECT TOP 1 * FROM Jucatori WHERE nume = @nume; ", sqlConn);
                SqlDataReader reader;
                cmd.Parameters.Add("@nume", Nume1_tb.Text);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    id1 = Int32.Parse(reader["Id"].ToString());
                    if (id1!=0)
                    {
                        DataNasterii1_tb.Visible = false;
                        Nume1_tb.Enabled = false;
                        Label8.Text = "jucatorul 1 are id-ul: " + id1.ToString();
                        Label8.Visible = true;
                    }
                    else
                    {
                        Label8.Text = "Numele nu exista in baza de date.";
                        Label8.Visible = true;
                    }

                    reader.Close();
                    //cmd.ExecuteNonQuery();
                }
            }
        }

        protected void CautaJucator2_btn_Click(object sender, EventArgs e)
        {
            if (Nume1_tb.Text == "")
            {
                Label8.Text = "Numele nu pot fi lăsate necompletate.";
                Label8.Visible = true;
            }
            else
            {
                sqlConn.Open();
                cmd = new SqlCommand("SELECT TOP 1 * FROM Jucatori WHERE nume = @nume; ", sqlConn);
                SqlDataReader reader;
                cmd.Parameters.Add("@nume", Nume2_tb.Text);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    id2 = Int32.Parse(reader["Id"].ToString());
                    if (id2 != 0)
                    {
                        DataNasterii2_tb.Visible = false;
                        Nume2_tb.Enabled = false;
                        Label8.Text = "jucatorul 2 are id-ul: "+ id2.ToString();
                        Label8.Visible = true;
                    }
                    else
                    {
                        Label8.Text = "Numele nu exista in baza de date.";
                        Label8.Visible = true;
                    }

                    reader.Close();
                    //cmd.ExecuteNonQuery();
                }
            }
        }
    }
}