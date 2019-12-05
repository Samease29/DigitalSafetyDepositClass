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
            bool firstRun = true;
            int currentUserID = 0;

            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            
            while (isAdminUnchanged())
            {
                InformationChange userInfoChangeForm = new InformationChange();
                Application.Run(userInfoChangeForm);
            }
            
            Regis regisForm = new Regis();
            Application.Run(regisForm);
            LoginForm userLoginForm = new LoginForm();
            Application.Run(userLoginForm);
            currentUserID = userLoginForm.currentUser;
            //Application.Run(new ProfileMain());
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

        static internal bool changeUserInformation(String username, String password, bool userIsEmail, String email, String firstName, String lastName, String confirmUsername, String confirmPassword)
        {
            username = Regex.Replace(username, "(\\\\n|\\\\r|'|\\/\\\\)+", "");
            password = Regex.Replace(password, "(\\\\n|\\\\r|'|\\/\\\\)+", "");
            email = Regex.Replace(email, "(\\\\n|\\\\r|'|\\/\\\\)+", "");
            firstName = Regex.Replace(firstName, "(\\\\n|\\\\r|'|\\/\\\\)+", "");
            lastName = Regex.Replace(lastName, "(\\\\n|\\\\r|'|\\/\\\\)+", "");
            confirmUsername = Regex.Replace(username, "(\\\\n|\\\\r|'|\\/\\\\)+", "");
            confirmPassword = Regex.Replace(password, "(\\\\n|\\\\r|'|\\/\\\\)+", "");
            return DataAccess.testUpdateUserInformation(username, password, userIsEmail, email, firstName, lastName, confirmUsername, confirmPassword);
        }

        static internal bool isAdminUnchanged() 
        {
            return DataAccess.testAdminUnchanged();
        }
    }


}
