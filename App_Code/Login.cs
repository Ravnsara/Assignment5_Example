using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Login
/// </summary>
public class Login
{
    private string userName;
    private string password;
    public Login(string user, string pass)
	{
        userName = user;
        password = pass;
	}

    public int ValidateLogin()
    {
        int pKey = 0;
        AutomartEntities ae = new AutomartEntities();

        var loginData = from p in ae.RegisteredCustomers 
                        where p.Email.Equals(userName) 
                        select new 
                        { 
                            p.CustomerPassCode, 
                            p.CustomerHashedPassword, 
                            p.PersonKey 
                        };
        int passcode = 0;
        byte[]hashed = null;
        int personKey = 0;

        //if (loginData != null)
        //{
            foreach (var ld in loginData)
            {
                passcode = (int)ld.CustomerPassCode;
                hashed = (byte[])ld.CustomerHashedPassword;
                personKey = (int)ld.PersonKey;
            }

            PasswordHash ph = new PasswordHash();
            if (passcode != 0)
            {
                byte[] generatedPassword = ph.HashIt(password, passcode.ToString());

                if (hashed != null)
                {
                    if (generatedPassword.SequenceEqual(hashed))
                    {
                        pKey = personKey;
                    }//end inner if
                }//end hashed if
            }//end outer if, passcode
        return pKey;
    }
}
