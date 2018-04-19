using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWellMeadowHospital.Database
{
    class InitializeDatabase
    {
        private static SqlConnection connection;
        private static string connectionString = "Data Source=X220-PC\\SQLEXPRESS;Initial Catalog=WellMeadowClinic;Integrated Security=True";

        static public void ConnectAndCreate()
        {
            // Assumes connectionString is a valid connection string. 
            using (connection = new SqlConnection(connectionString))
            {

                connection.Open();
                Create(connection);
                
            }
        }
        static void Create(SqlConnection connection)
        {
            RunProceduredStorage("CreateDateabase");
            RunProceduredStorage("InsertData");

        }

        private static int Delete()
        {
            //close connection and then delete

            string queryString = "DROP DATABASE WellMeadowClinic";

            int errorCode = RunCommand(queryString);
            return errorCode;
        }
        void Update()
        {

        }
        void Read()
        {

        }
        
        public static int RunProceduredStorage(string procedurename)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var command = new SqlCommand(procedurename, conn)
            {
                CommandType = CommandType.StoredProcedure
            })
            {
                conn.Open();
                command.ExecuteNonQuery();
            }
            return 0;
        }

        public static int RunCommand(string queryString)
        {
            SqlCommand command = new SqlCommand(queryString, connection);
            try
            {
                // Open the connection and execute the reader.
                SqlDataReader reader = command.ExecuteReader();

                if (reader.RecordsAffected > 0)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}: {1:C}", reader[0], reader[1]);
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();
            }
            catch (SqlException e)
            {
                Console.Write(e);
                return e.ErrorCode;
                

            }

            return 0;
        }
    }
}
