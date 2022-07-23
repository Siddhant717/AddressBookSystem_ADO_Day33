using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBook
    {
        public static void CreateAddressBookServiceDB()
        {
            //creating AddressBookService Database
            string SQL = "create database Address_Book_Service ";

            string connectingstring = @"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectingstring);
            SqlCommand sqlcommand = new SqlCommand(SQL, connection);
            try
            {
                connection.Open();
                sqlcommand.ExecuteNonQuery();
                Console.WriteLine("Database Created Successfully....");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception :" + e.Message);
            }
            finally
            {
                connection.Close();
            }

        }
        //Creating AddressBook Table
        public  void CreateAddressBookTable()
        {
            var SQL = @$"create table AddressBook ( FirstName Varchar(20), LastName Varchar(20), Address Varchar(50), City Varchar(20), State Varchar(20), ZipCode int, PhoneNumber bigint, Email Varchar(20) )";
            string connectingString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Address_Book_Service;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectingString);
            SqlCommand cmd = new SqlCommand(SQL, connection);
            connection.Open();
            int reader = cmd.ExecuteNonQuery();
            Console.WriteLine(reader);
            Console.WriteLine("AddressBook Table Created Successfully");
            Console.ReadKey();
        }
    }
}
