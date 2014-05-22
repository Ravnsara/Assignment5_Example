using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["person"] != null)
        {
            AutomartEntities ae = new AutomartEntities();
            int pk = (int)Session["person"];
            var customer = from c in ae.vehicles
                        where c.PersonKey == pk
                        select new
                        {
                            c.Person.LastName,
                            c.Person.FirstName,
                            c.LicenseNumber,
                            c.VehicleMake,
                            c.VehicleYear
                        };
            foreach (var p in customer)
            {
                lblWelcome.Text = "Welcome! " + p.FirstName + " " + p.LastName + ".";
            }

            GridView1.DataSource = customer.ToList();
            GridView1.DataBind();
        }
    else
        {
            Response.Redirect("Default.aspx");
        }
    }
}