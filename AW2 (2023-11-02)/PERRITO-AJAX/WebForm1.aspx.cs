using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Threading;

namespace PERRITO_AJAX
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "HOLA";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Thread.Sleep(5000);
            TextBox2.Text = "HOLA";
        }
    }
}