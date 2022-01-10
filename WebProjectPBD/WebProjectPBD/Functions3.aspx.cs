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
        static string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Info An 3\PBD\pbd-project\WebProjectPBD\WebProjectPBD\App_Data\db.mdf;Integrated Security=True";
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

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (NumeJucator_tb.Text == "")
            {
                Label1.Visible = true;
            }
            else
            {
                sqlConn.Open();
                cmd = new SqlCommand("SELECT TOP 1 Id FROM Jucatori WHERE nume = @nume; ", sqlConn);
                SqlDataReader reader;
                cmd.Parameters.AddWithValue("@nume", NumeJucator_tb.Text.Trim());
                reader = cmd.ExecuteReader();
                int id = 0;
                if(reader.Read())
                    id = Int32.Parse(reader["Id"].ToString());
                reader.Close();
                cmd = new SqlCommand(
                    "(SELECT Id_joc,Jucator2,Tip_joc,Data_inceput_joc,Data_sfarsit_joc," +
                    "CASE " +
                    "WHEN Id_invingator=@id THEN 'da'" +
                    "ELSE 'nu'" +
                    "END AS Castigator" +
                    " FROM Joc WHERE Jucator1=@nume) " +
                    "UNION" +
                    " (SELECT Id_joc,Jucator1,Tip_joc,Data_inceput_joc,Data_sfarsit_joc," +
                    "CASE " +
                    "WHEN Id_invingator=@id THEN 'da'" +
                    "ELSE 'nu'" +
                    "END AS Castigator" +
                    " FROM Joc WHERE Jucator2=@nume)" +
                    " ORDER BY Id_joc", sqlConn);
                cmd.Parameters.AddWithValue("@nume", NumeJucator_tb.Text.Trim());
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataAdapter sqlDA5 = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sqlDA5.Fill(dt);
                GridView2.DataSource = dt;
                GridView2.DataBind();
                sqlConn.Close();
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            int id = 0;
            SqlDataReader reader;
            sqlConn.Open();
            if (DropDownList1.Text == "<10")
            {
                
                cmd = new SqlCommand("SELECT TOP 1 * FROM Joc " +
                                     " WHERE Id_invingator=(SELECT Id FROM Jucatori WHERE (DATEDIFF(year, Data_nasterii, GETDATE()) BETWEEN 0 AND 10)) " +
                                     "GROUP By Id_invingator" +
                                     " ORDER BY COUNT(Id_invingator) DESC", sqlConn);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                    id = Int32.Parse(reader["Id"].ToString());
                reader.Close();

            }
            else if (DropDownList1.Text == "10-18")
            { ;
                cmd = new SqlCommand("SELECT TOP(1) Id_invingator FROM Joc " +
                                     " WHERE Id_invingator=(SELECT Id FROM Jucatori WHERE (DATEDIFF(year, Data_nasterii, GETDATE()) BETWEEN 10 AND 18)) " +
                                     "GROUP BY Id_invingator" +
                                     " ORDER BY COUNT(Id_invingator) DESC", sqlConn);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                    id = Int32.Parse(reader["Id"].ToString());
                reader.Close();
            }
            else if (DropDownList1.Text == "19-40")
            {
                cmd = new SqlCommand("SELECT TOP(1) Id_invingator FROM Joc " +
                                     " WHERE Id_invingator=(SELECT Id FROM Jucatori WHERE (DATEDIFF(year, Data_nasterii, GETDATE()) BETWEEN 18 AND 40)) " +
                                     "GROUP By Id_invingator" +
                                     " ORDER BY COUNT(Id_invingator) DESC", sqlConn);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                    id = Int32.Parse(reader["Id"].ToString());
                reader.Close();
            }
            else if (DropDownList1.Text == "41-50")
            {
                cmd = new SqlCommand("SELECT TOP(1) Id_invingator FROM Joc " +
                                     " WHERE Id_invingator=(SELECT Id FROM Jucatori WHERE (DATEDIFF(year, Data_nasterii, GETDATE()) BETWEEN 40 AND 50)) " +
                                     "GROUP By Id_invingator" +
                                     " ORDER BY COUNT(Id_invingator) DESC", sqlConn);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                    id = Int32.Parse(reader["Id"].ToString());
                reader.Close();
            }
            else if (DropDownList1.Text == ">50")
            {
                cmd = new SqlCommand("SELECT TOP(1) Id_invingator FROM Joc " +
                                     " WHERE Id_invingator=(SELECT Id FROM Jucatori WHERE (DATEDIFF(year, Data_nasterii, GETDATE()) BETWEEN 50 AND 100)) " +
                                     "GROUP By Id_invingator" +
                                     " ORDER BY COUNT(Id_invingator) DESC", sqlConn);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                    id = Int32.Parse(reader["Id"].ToString());
                reader.Close();
            }
            cmd = new SqlCommand("SELECT TOP 1 Nume FROM Jucatori WHERE Id = @id;", sqlConn);
            cmd.Parameters.AddWithValue("@id", id);
            reader = cmd.ExecuteReader();
            if (reader.Read() && id != 0)
            {
                Label3.Text = reader["Nume"].ToString();
                Label3.Visible = true;
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            sqlConn.Open();


            cmd = new SqlCommand("SELECT top(1) Id_invingator,Tip_joc FROM Joc GROUP By Id_invingator,Tip_joc ORDER BY Tip_joc ASC,COUNT(Id_invingator) DESC", sqlConn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            reader.Read();
            int id = Int32.Parse(reader["Id_invingator"].ToString());
            reader.Close();
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("SELECT * FROM Jucatori WHERE Id=@id", sqlConn);
            SqlDataReader reader1;
            cmd.Parameters.Add("@id", id);
            reader1 = cmd.ExecuteReader();
            reader1.Read();
            string nume = reader1["Nume"].ToString();
            reader1.Close();
            cmd.ExecuteNonQuery();
            TextBox1.Text = nume;
            sqlConn.Close();
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            sqlConn.Open();


            cmd = new SqlCommand("SELECT top(1) * FROM Jucatori ORDER BY Partide_jucate DESC", sqlConn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            reader.Read();
            int id = Int32.Parse(reader["Id"].ToString());
            reader.Close();
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("SELECT * FROM Jucatori WHERE Id=@id", sqlConn);
            SqlDataReader reader1;
            cmd.Parameters.Add("@id", id);
            reader1 = cmd.ExecuteReader();
            reader1.Read();
            string nume = reader1["Nume"].ToString();
            reader1.Close();
            cmd.ExecuteNonQuery();
            TextBox1.Text = nume;
            sqlConn.Close();
        }
    }
}