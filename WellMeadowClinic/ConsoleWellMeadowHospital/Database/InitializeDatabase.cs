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

    /*
     * TODO
     * a) Create and maintain records recording the details of members of staff (Personnel officer)
     * c) Produce a report listing the details of staff allocated to each ward (Personnel officer + charge nurse)
     * g) Create and maintain records recording the details of patients referred to a particular ward (Charge nurse)
     * h) Produce a report listing the details of patients currently located in a particular ward (Charge nurse)
     * 
     * */
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

        public static SqlCommand CreateSqlCommand(string queryString)
        {
            SqlCommand command = new SqlCommand(queryString, connection);
            return command;
        }

        public static SqlException RunSqlCommand(SqlCommand cmd)
        {

            using (connection = new SqlConnection(connectionString))
            {

                connection.Open();

                try
                {
                    // Open the connection and execute the reader.
                    SqlDataReader reader = null;
                    reader = cmd.ExecuteReader();


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
                    connection.Close();
                    return e;


                }
                SqlException sqlException = null;
                connection.Close();


                return sqlException;
            }

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
                connection.Close();
                return e.ErrorCode;
                

            }
            connection.Close();
            return 0;
        }
    }
}
