using DigitalSafetyDepositBoxClass;
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

//For the test
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
            int currentUserID = 0;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm userLoginForm = new LoginForm();
            Application.Run(userLoginForm);
            currentUserID = userLoginForm.currentUser;
            Console.WriteLine(currentUserID);
            Console.ReadLine();
			
            Application.Run(new Regis());
            Application.Run(new ProfileMain());
        }

        static internal void registerAccount() 
        {
            Application.Run();
        }

        static internal int verifyAccount(String username, String password) 
        {
            username = Regex.Replace(username, "(\\\\n|\\\\r|'|\\/\\\\)+", "");
            password = Regex.Replace(password, "(\\\\n|\\\\r|'|\\/\\\\)+", "");
            return DataAccess.testUserVerification(username, password);
        }

        
    }
}
