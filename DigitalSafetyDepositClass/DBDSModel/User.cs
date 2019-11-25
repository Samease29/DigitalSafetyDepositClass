using System;
using System.Data.Common;
using System.Configuration;
using System.Windows.Forms;

namespace DSDBModel
{
    internal class User : Account
    {

        

        public User(String user, String pass, String fName, String lName) 
        {
            username = user;
            password = pass;
            firstName = fName;
            lastName = lName;
        }

        static internal bool verifyUserPass(String username, String password) 
        {
            String provider = ConfigurationManager.AppSettings["provider"];

            String connectionString = ConfigurationManager.AppSettings["connectionString"];

            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);

            using (DbConnection connection = factory.CreateConnection())
            {
                if (connection == null)
                {
                    MessageBox.Show("Error Connecting to Database", "CONNECTION ERROR");
                    return false;
                }

                connection.ConnectionString = connectionString;

                connection.Open();

                DbCommand command = factory.CreateCommand();

                if (command == null)
                {
                    MessageBox.Show("Error Sending Request to Database", "COMMAND ERROR");
                    return false;
                }

                command.Connection = connection;

                String user = username.Substring(0, username.Length);
                String pass = password.Substring(0, password.Length);

                command.CommandText = $"SELECT * FROM UserInfo WHERE username = '{user}' AND password = '{pass}'";

                Console.WriteLine(command.CommandText);

                using (DbDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read()) 
                    {
                        Console.WriteLine($"{dataReader["username"]} " +
                                          $"{dataReader["email"]} " +
                                          $"{dataReader["fName"]} " +
                                          $"{dataReader["lName"]} " +
                                          $"{dataReader["admin"]}.");
                        
                    }

                    Console.ReadLine();
                }
            }

            return true;
        }
    }

}
