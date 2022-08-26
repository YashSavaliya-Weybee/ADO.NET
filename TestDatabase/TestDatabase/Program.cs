using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Program().createTable();

            //new Program().insertData();

            //new Program().retriveData();

            //new Program().deleteRecord();
            //new Program().retriveData();

            new Program().connect();
        }

        //Create table-------------------------------------
        public void createTable()
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("data source=.;database=Student;integrated security=SSPI");
                SqlCommand cmd = new SqlCommand("CREATE TABLE student(id int not null,name varchar(100),email varchar(50),join_date date)", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table Created Successfully");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("OPPS, Something went wrong. " + e);
                Console.ReadKey();
            }
            finally
            {
                conn.Close();
            }
        }
        //Insert Data--------------------------------------
        public void insertData()
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("data source=.;database=Student;integrated security=SSPI");
                SqlCommand cmd = new SqlCommand("INSERT INTO student(id,name,email,join_date) values (101,'Yash Savaliya','abc@Gmail.com','1/12/2017'),(102,'Himanshu Ladva','xyz@Gmail.com','1/12/2017')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Record Inserted Sucessfully");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, Something went wrong. " + e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        //Retrive data-------------------------------------
        public void retriveData()
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("data source=.;database=Student;integrated security=SSPI");
                SqlCommand cmd = new SqlCommand("SELECT * FROM student", conn);
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["id"] + " " + sdr["name"] + " " + sdr["email"]);
                }
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong. " + e.Message);
                Console.ReadKey();
            }
            finally
            {
                conn.Close();
            }
        }

        //Delete Record------------------------------------
        public void deleteRecord()
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("data source=.;database=Student;integrated security=SSPI");
                SqlCommand cmd = new SqlCommand("DELETE FROM student WHERE id=102", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Record Deleted Sucessfully");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs,Something went wrong." + e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        //Connection class---------------------------------
        public void connect()
        {
            //Method-1 ==> don't need to close connection
            //using (SqlConnection conn = new SqlConnection("data source=.;database=Student;integrated security=SSPI"))
            //{
            //    conn.Open();
            //    Console.WriteLine("Connection Established Successfully");
            //    Console.ReadKey();
            //}

            //Method-2 ==> must need close connection
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("data source=.;database=Student;integrated security=SSPI");
                conn.Open();
                Console.WriteLine("Connection Established Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, Something went wrong. " + e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
