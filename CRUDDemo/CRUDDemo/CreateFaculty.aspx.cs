using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUDDemo
{
    public partial class CreateFaculty : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ADOLayer ad = new ADOLayer();
            int id = Convert.ToInt32(TextBox1.Text);
            string name = TextBox2.Text.ToString();

            string i = ad.iFaculty(id, name);
            if (i.Length > 5) { Label1.Text = i; }
            else { Label1.Text = "  Added"; }
        }
    }
}