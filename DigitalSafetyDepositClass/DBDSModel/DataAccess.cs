﻿using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
using System.IO;
using System.Globalization;

namespace DigitalSafetyDepositBoxClass.DBDSModel
{
    public class DataAccess
    {
        private USERS user;
        public USERS _user { get { return this.user; } set { this.user = value; } }

        public DataAccess() 
        {
            this.user = new USERS();
        }

        /*This is the USERS class which links to the USERS Table. It uses LINQ format for this operation.
         * 
         */
        [Table(Name = "USERS")]
        public class USERS
        {
            [Column(IsPrimaryKey = true, Storage = "user_id")]
            internal int user_id;
            [Column(Storage = "user_name")]
            internal String user_name;
            [Column(Storage = "password")]
            internal String password;
            [Column(Storage = "email")]
            internal String email;
            [Column(Storage = "last_name")]
            internal String last_name;
            [Column(Storage = "first_name")]
            internal String first_name;
            [Column(Storage = "admin")]
            internal bool admin;
            [Column(Storage = "user_name_is_email")]
            internal bool user_name_is_email;
            [Column(Storage = "password_salt")]
            internal Guid password_salt;
            [Column(Storage = "void_ind")]
            internal bool void_ind;


        }

        /*This is the FILES class which links to the FILES Table. It uses LINQ format for this operation.
         * 
         */
        [Table(Name = "FILES")]
        public class FILES
        {
            [Column(IsPrimaryKey = true, Storage = "file_id")]
            internal int file_id;
            [Column(Storage = "file_name")]
            internal String file_name;
            [Column(Storage = "file_contents")]
            internal Byte[] file_contents;
            [Column(Storage = "type")]
            internal String type;
            [Column(Storage = "container_name")]
            internal String container_name;
            [Column(IsDiscriminator = true, Storage = "user_id")]
            internal int user_id;
            [Column(Storage = "void_ind")]
            internal bool void_ind;
        }

        static internal int testUserVerification(String username, String password)
        {
            //The DateTime operations are attempting to make a Log file. They can be edited out.
            DateTime Date = DateTime.Now;
            CultureInfo culture = new CultureInfo("en-US");
            String filePath = "C:\\Users\\skyla\\Desktop\\LINQLogResults.txt";
            System.IO.StreamWriter queryLog = new System.IO.StreamWriter(@filePath, true);
            queryLog.WriteLine("Query Results written at " + Date.ToString(culture) + ":\n");
            queryLog.Close();

            /*This line creates the connection to your Database Server. You need to replace 
             * "DSDBDatabaseConnectionString" with the String in App.config
             *The string will be in the <connectionStrings> tag. It is the string in the
             * tag that looks like this <add name="DSDBDatabaseConnectionString"
             */
            DataContext db = new DataContext(System.Configuration.ConfigurationManager.ConnectionStrings["DSDBDatabaseConnectionString"].ToString());
            /*This line says which table you want to access. You will replace <USERS> with <FILES> if you're
             * trying to work with the FILES table.
             */
            Table<USERS> Users = db.GetTable<USERS>();
            //db.Log = new StreamWriter(@filePath); Ignore this.

            /*This is where the database query goes. You can look up IQueryable to learn the general
             * form of the queries. I believe they always begin with "from" keyword.
             * Note that you access the records in the database like you would items in any iterable list.
             * Note that you access the fields in the individual databse records like you would class fields.
             */
            IQueryable<USERS> verifyQuery = from user in Users where user.user_name == username select user;
            foreach (USERS user in verifyQuery)
            {
                if (Helper.encryptPass(password, user.password_salt).Equals(user.password))
                {
                    //We will pass user_id's to tell Program.cs what User we're working with.
                    return user.user_id;
                }
            }
           
            return 0;
        }


        static internal void testUserRegistation(String username)
        {
            DataContext db = new DataContext(System.Configuration.ConfigurationManager.ConnectionStrings["DSDBDatabaseConnectionString"].ToString());
            Table<USERS> Users = db.GetTable<USERS>();

            IQueryable<USERS> usernameAvailableQuery = from user in Users where user.user_name == username select user;
            if (usernameAvailableQuery.Count() == 0)
            { 
                
            }
        }

        static internal bool TestFileAdd(String fileName, String containerName, String filePath) 
        {
            byte[] bytesToAdd = System.IO.File.ReadAllBytes(filePath);

            return true;
        }

    }
}