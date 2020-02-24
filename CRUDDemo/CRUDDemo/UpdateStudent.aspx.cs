using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUDDemo
{
    public partial class UpdateStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ADOLayer ado = new ADOLayer();
            int id = int.Parse(TextBox1.Text.ToString());
            string name = TextBox2.Text.ToString();

            string i = ado.uStudent(id, name);
            if (int.Parse(i) > 0) { Label1.Text = "   Update Sucessfully"; }
            else { Label1.Text = i; }

        }
    }
}