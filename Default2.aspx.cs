using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string[] years = new string[19];
            int counter = 0;
            for (int i = 1995; i < 2014; i++)
            {
                years[counter] = i.ToString();
                counter++;
            }
            ddYears.DataSource = years.ToList();
            ddYears.DataBind();
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        AutomartEntities ae = new AutomartEntities();
        Person p = new Person();
        p.LastName = txtLastName.Text;
        p.FirstName = txtFirstName.Text;
        ae.People.Add(p);

        vehicle v = new vehicle();
        v.Person = p;
        v.VehicleMake = txtMake.Text;
        v.LicenseNumber = txtLicense.Text;
        v.VehicleYear = ddYears.SelectedItem.ToString();
        ae.vehicles.Add(v);

        Random rand = new Random();
        int passcode = rand.Next(1000000, 9999999);
        PasswordHash ph = new PasswordHash();
        byte[] hashed = ph.HashIt(txtPassword.Text, passcode.ToString());

        RegisteredCustomer rc = new RegisteredCustomer();
        rc.Person = p;
        rc.Email = txtEmail.Text;
        rc.CustomerPassCode = passcode;
        rc.CustomerPassword = txtPassword.Text;
        rc.CustomerHashedPassword = hashed;
        ae.RegisteredCustomers.Add(rc);

        ae.SaveChanges();
    }
}