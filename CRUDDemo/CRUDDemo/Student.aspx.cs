using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace CRUDDemo
{
    public partial class Student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           ADOLayer ado = new ADOLayer();
           DataSet ds= ado.ShowStudent();
            GridView1.DataSource = ds;
            GridView1.DataBind();

            DataSet ds1 = ado.ShowFaculty();
            GridView2.DataSource = ds1;
            GridView2.DataBind();

            DataSet ds2 = ado.ShowCourse();
            GridView3.DataSource = ds2;
            GridView3.DataBind();
        }
      


    }
}