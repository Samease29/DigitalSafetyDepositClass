using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Configuration;
using DigitalSafetyDepositBoxClass;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
using DigitalSafetyDepositBoxClass.DBDSModel;

//Bug Fix
namespace DigitalSafetyDepositClass
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Regis());
            int currentUserID = 0;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm userLoginForm = new LoginForm();
            Application.Run(userLoginForm);
            currentUserID = userLoginForm.currentUser;
            Console.WriteLine(currentUserID);
            Console.ReadLine();

            //DataAccess dbMethods = new DataAccess();
            //USERS test = dbMethods._user;
            //DataContext con = new DataContext(ConfigurationManager.AppSettings["connectionString"]);

            
            /*
            String testPass = "Adminpass!@123";
            Guid id = Guid.NewGuid();
            Console.WriteLine($"Password: {testPass} and Uniqueidentifier: {id} -> Become Hash: {Helper.encryptPass(testPass, id)}");
            Console.ReadLine();
            Application.Run(new LoginForm());
            Application.Run(new LoginForm());
            */


        }

        static internal bool registerAccount(String username, String password, bool userIsEmail, String email, String firstName, String lastName) 
        {
            username = Regex.Replace(username, "(\\\\n|\\\\r|'|\\/\\\\)+", "");
            password = Regex.Replace(password, "(\\\\n|\\\\r|'|\\/\\\\)+", "");
            email = Regex.Replace(email, "(\\\\n|\\\\r|'|\\/\\\\)+", "");
            firstName = Regex.Replace(firstName, "(\\\\n|\\\\r|'|\\/\\\\)+", "");
            lastName = Regex.Replace(lastName, "(\\\\n|\\\\r|'|\\/\\\\)+", "");
            return DataAccess.testUserRegistation(username, password, userIsEmail, email, firstName, lastName);
        }

        static internal int verifyAccount(String username, String password) 
        {
            username = Regex.Replace(username, "(\\\\n|\\\\r|'|\\/\\\\)+", "");
            password = Regex.Replace(password, "(\\\\n|\\\\r|'|\\/\\\\)+", "");
            return DataAccess.testUserVerification(username, password);
        }

        
    }
}
