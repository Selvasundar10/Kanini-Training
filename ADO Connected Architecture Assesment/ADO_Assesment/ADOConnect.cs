using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Assesment
{
    public class ADOConnect
    {
        SqlConnection conn;
        public ADOConnect()
        {
            conn = new SqlConnection("data source =LAPTOP-6JOEM91O\\SQLEXPRESS01;integrated security=SSPI;initial catalog=ADOBank");
        }



        //{
        //    try
        //    {
        //        conn.Open();
        //        Console.WriteLine("Connection is Opened");



        //    }
        //    catch (Exception ex)

        //    {
        //        Console.WriteLine(ex.Message);
        //        Console.WriteLine(ex.StackTrace);
        //        Console.WriteLine("Connection is not Established");

        //    }


        //}

        public void Region()
            {
            conn.Open();

                SqlCommand cmd = new SqlCommand("create table Regions (regid int PRIMARY KEY, regname varchar(20) ) ", conn);
                
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Table Created");
            conn.Close();

                


            }
          public  void Cus_Nodes()
            {

                SqlCommand cmd = new SqlCommand("create table Cus_Nodes(regid int FOREIGN KEY references Region,cust_id int PRIMARY KEY, node_name nvarchar(20));", conn);
            conn.Open();

            if (conn != null)

            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table Created");

            }
            conn.Close();


           }
           public  void Cust_Transaction()
            {

                SqlCommand cmd = new SqlCommand("create table Cust_Transaction(cust_id int FOREIGN KEY references Cus_Nodes, balance int, transaction_date date ,amt_transaction int ,mode_of_transaction nvarchar(20))", conn);
            conn.Open();
            if (conn != null)
                {
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Table Created");

                }
            conn.Close();


            }

       
    }
}
    
