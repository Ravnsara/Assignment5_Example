using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        Login login = new Login(txtUserName.Text, txtPassword.Text);
        int personKey = login.ValidateLogin();
        if (personKey != 0)
        {
            Session["person"] = personKey;
            Response.Redirect("Default3.aspx");
        }
        else
        {
            lblError.Text = "Invalid Login";
        }
    }
}