using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CRUDDemo
{
    public partial class CreateStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ADOLayer ad = new ADOLayer();
            int id= Convert.ToInt32(TextBox1.Text);
            string name = TextBox2.Text.ToString();

            string i=ad.iStudent(id, name);
            if (int.Parse(i) > 0) { Label1.Text = "   Added"; }
            else { Label1.Text = i; }

        }
    }
}