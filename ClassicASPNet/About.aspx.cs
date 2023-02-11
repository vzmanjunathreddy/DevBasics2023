using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClassicASPNet
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>() { "", "" };
            GridView1.DataSource= list;
            GridView1.DataBind();
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var firstName = TextBox1.Text;
        }
    }
}