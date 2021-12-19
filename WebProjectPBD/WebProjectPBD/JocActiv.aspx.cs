using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebProjectPBD
{
    public partial class JocActiv : System.Web.UI.Page
    {
        static string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\FAC\pbd\cod\pbd-project\WebProjectPBD\WebProjectPBD\App_Data\db.mdf;Integrated Security=True";
        SqlConnection sqlConn = new SqlConnection(connString);
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlCommand cmd3;
        SqlCommand cmd4;

        private int id_joc;
        private int n_partida;
        private int n_partida_curenta;
        private int n_scor1;
        private int n_scor2;
        private int id_invingator;

        protected void Page_Load(object sender, EventArgs e)
        {
            sqlConn.Open();
            cmd = new SqlCommand("select top(1) *from Joc order by Id_joc desc;", sqlConn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            reader.Read();
            id_joc=Int32.Parse(reader["Id_joc"].ToString());


            n_partida = Int32.Parse(reader["Partida_totala"].ToString());
            n_partida_curenta= Int32.Parse(reader["Partida_curenta"].ToString());
            n_scor1 = Int32.Parse(reader["Scor_jucator1"].ToString());
            n_scor2 = Int32.Parse(reader["Scor_jucator2"].ToString());

            Lbl_round.Text = "Partida " + n_partida_curenta +" din "+n_partida;
            if (reader["Tip_joc"].ToString().Equals("0"))
                Lbl_remaining_rounds.Text = "Joc sah";
            else Lbl_remaining_rounds.Text = "Joc table";
            Label1.Text = reader["Jucator1"].ToString();
            Label2.Text = reader["Jucator2"].ToString();
            ScorJucator1_lb.Text = n_scor1.ToString();
            ScorJucator2_lb.Text = n_scor2.ToString();
            reader.Close();
        }

        

        protected void Jucator1_btn_Click(object sender, EventArgs e)
        {
            n_scor1 += 1;
            n_partida_curenta += 1;
            cmd2 = new SqlCommand("UPDATE Joc SET Partida_curenta=@partida, Scor_jucator1=@scor1 WHERE Id_joc=@id", sqlConn);
            cmd2.Parameters.AddWithValue("@partida", n_partida_curenta.ToString());
            cmd2.Parameters.AddWithValue("@scor1", n_scor1.ToString());
            cmd2.Parameters.AddWithValue("@id", id_joc.ToString());
            cmd2.ExecuteNonQuery();
            Lbl_round.Text = "Partida " + n_partida_curenta.ToString() + " din " + n_partida.ToString();
            ScorJucator1_lb.Text = n_scor1.ToString();
            if (n_partida_curenta >= n_partida)
            {

               
                

                winner_lbl.Visible = true;
                Button1.Visible = true;
                Jucator1_btn.Visible = false;
                Jucator2_btn.Visible = false;

                if (n_scor1 > n_scor2)
                {
                    cmd4 = new SqlCommand("SELECT * FROM Jucatori WHERE Nume=@nume", sqlConn);
                    SqlDataReader reader;
                    cmd4.Parameters.Add("@nume", Label1.Text);
                    reader = cmd4.ExecuteReader();
                    reader.Read();
                    id_invingator = Int32.Parse(reader["Id"].ToString());
                    reader.Close();
                    cmd4.ExecuteNonQuery();


                    cmd2 = new SqlCommand("UPDATE Joc SET Data_sfarsit_joc=@data_s,Id_invingator=@id_i WHERE Id_joc=@id ", sqlConn);
                    cmd2.Parameters.AddWithValue("@data_s", DateTime.Now);
                    cmd2.Parameters.AddWithValue("@id_i", id_invingator.ToString());
                    cmd2.Parameters.AddWithValue("@id", id_joc.ToString());
                    cmd2.ExecuteNonQuery();
                    winner_lbl.Text = "Jocul s-a terminat! " + Convert.ToString(Label1.Text) + " a castigat!";
                }
                else
                {
                    cmd4 = new SqlCommand("SELECT * FROM Jucatori WHERE Nume=@nume", sqlConn);
                    SqlDataReader reader;
                    cmd4.Parameters.Add("@nume", Label2.Text);
                    reader = cmd4.ExecuteReader();
                    reader.Read();
                    id_invingator = Int32.Parse(reader["Id"].ToString());
                    reader.Close();
                    cmd4.ExecuteNonQuery();


                    cmd2 = new SqlCommand("UPDATE Joc SET Data_sfarsit_joc=@data_s,Id_invingator=@id_i WHERE Id_joc=@id ", sqlConn);
                    cmd2.Parameters.AddWithValue("@data_s", DateTime.Now);
                    cmd2.Parameters.AddWithValue("@id_i", id_invingator.ToString());
                    cmd2.Parameters.AddWithValue("@id", id_joc.ToString());
                    cmd2.ExecuteNonQuery();
                    winner_lbl.Text = "Jocul s-a terminat! " + Convert.ToString(Label2.Text) + " a castigat!";
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("JocActiv.aspx");
        }

        protected void Jucator2_btn_Click(object sender, EventArgs e)
        {
            n_scor2 += 1;
            n_partida_curenta += 1;
            cmd3 = new SqlCommand("UPDATE Joc SET Partida_curenta=@partida, Scor_jucator2=@scor2 WHERE Id_joc=@id;", sqlConn);
            cmd3.Parameters.AddWithValue("@partida", n_partida_curenta.ToString());
            cmd3.Parameters.AddWithValue("@scor2", n_scor2.ToString());
            cmd3.Parameters.AddWithValue("@id", id_joc.ToString());
            cmd3.ExecuteNonQuery();
            Lbl_round.Text = "Partida " + n_partida_curenta.ToString() + " din " + n_partida.ToString();
            ScorJucator2_lb.Text = n_scor2.ToString();
            if (n_partida_curenta >= n_partida)
            {
                winner_lbl.Visible = true;
                Button1.Visible = true;
                Jucator1_btn.Visible = false;
                Jucator2_btn.Visible = false;
                if (n_scor2 > n_scor1)
                {
                    cmd4 = new SqlCommand("SELECT * FROM Jucatori WHERE Nume=@nume", sqlConn);
                    SqlDataReader reader;
                    cmd4.Parameters.Add("@nume", Label2.Text);
                    reader = cmd4.ExecuteReader();
                    reader.Read();
                    id_invingator = Int32.Parse(reader["Id"].ToString());
                    reader.Close();
                    cmd4.ExecuteNonQuery();


                    cmd2 = new SqlCommand("UPDATE Joc SET Data_sfarsit_joc=@data_s,Id_invingator=@id_i WHERE Id_joc=@id ", sqlConn);
                    cmd2.Parameters.AddWithValue("@data_s", DateTime.Now);
                    cmd2.Parameters.AddWithValue("@id_i", id_invingator.ToString());
                    cmd2.Parameters.AddWithValue("@id", id_joc.ToString());
                    cmd2.ExecuteNonQuery();
                    winner_lbl.Text = "Jocul s-a terminat! " + Convert.ToString(Label2.Text) + " a castigat!";
                }
                else
                {
                    cmd4 = new SqlCommand("SELECT * FROM Jucatori WHERE Nume=@nume", sqlConn);
                    SqlDataReader reader;
                    cmd4.Parameters.Add("@nume", Label1.Text);
                    reader = cmd4.ExecuteReader();
                    reader.Read();
                    id_invingator = Int32.Parse(reader["Id"].ToString());
                    reader.Close();
                    cmd4.ExecuteNonQuery();


                    cmd2 = new SqlCommand("UPDATE Joc SET Data_sfarsit_joc=@data_s,Id_invingator=@id_i WHERE Id_joc=@id ", sqlConn);
                    cmd2.Parameters.AddWithValue("@data_s", DateTime.Now);
                    cmd2.Parameters.AddWithValue("@id_i", id_invingator.ToString());
                    cmd2.Parameters.AddWithValue("@id", id_joc.ToString());
                    cmd2.ExecuteNonQuery();
                    winner_lbl.Text = "Jocul s-a terminat! " + Convert.ToString(Label1.Text) + " a castigat!";
                }

            }
        }
    }
}