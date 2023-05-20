using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspDotNetMathServiceClientApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            MathWebServiceReference.MathWebServiceSoapClient client = new MathWebServiceReference.MathWebServiceSoapClient();
            lblAddResult.Text = client.Add(Convert.ToInt32(txtFirstNumber.Text), Convert.ToInt32(txtSecondNumber.Text)).ToString();
            lblSubtractResult.Text = client.Subtract(Convert.ToInt32(txtFirstNumber.Text), Convert.ToInt32(txtSecondNumber.Text)).ToString();
            lblMultiplyResult.Text = client.Multiply(Convert.ToInt32(txtFirstNumber.Text), Convert.ToInt32(txtSecondNumber.Text)).ToString();
            lblDivideResult.Text = client.Divide(Convert.ToInt32(txtFirstNumber.Text), Convert.ToInt32(txtSecondNumber.Text)).ToString();
        }
    }
}