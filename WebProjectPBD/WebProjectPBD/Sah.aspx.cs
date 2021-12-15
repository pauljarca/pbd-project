using System;
using System.Collections.Generic;
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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void IncepeJoc_btn_Click(object sender, EventArgs e)
        {
            if ((Convert.ToDateTime(DataNasterii1_tb).Date > DateTime.Today.Date) || (Convert.ToDateTime(DataNasterii2_tb).Date > DateTime.Today.Date))
            {
                Label8.Visible = true;
                Label8.Text = "Verifica datele de nastere inca o data.";
            }
        }
    }
}