using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day4Webservices_Client
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnmsg_Click(object sender, EventArgs e)
        {
            ZensarServices.MyWebService1SoapClient client = new ZensarServices.MyWebService1SoapClient();
            // Label1.Text = client.Message(Txtname.Text);
            string str = client.msg(Txtname.Text);
            Label1.Text = str;
        }

        protected void Btnnum_Click(object sender, EventArgs e)
        {
            ZensarServices.MyWebService1SoapClient client = new ZensarServices.MyWebService1SoapClient();
            float result = client.findsquare(float.Parse(Txtnum.Text));
            Label1.Text = result.ToString();
        }
    }
}