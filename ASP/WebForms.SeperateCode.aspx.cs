using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        int number1 =
            System.Convert.ToInt32(txtNumber1.Text);

        int number2 =
            System.Convert.ToInt32(txtNumber2.Text);

        int sum = number1 + number2;
        
        txtSum.Text = sum.ToString();
    }
}