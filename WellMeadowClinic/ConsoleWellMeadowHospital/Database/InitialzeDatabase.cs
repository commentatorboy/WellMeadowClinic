using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWellMeadowHospital.Database
{
    class InitialzeDatabase
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
            string queryString = "";
            string createDatabase = "CREATE DATABASE WellMeadowClinic " +
                " USE WellMeadowClinic ";
            string createWard = " CREATE TABLE Ward(" +
                "WardNumber int NOT NULL PRIMARY KEY, " +
                "Name nchar(10) NOT NULL, " +
                "Location nchar(10) NOT NULL, " +
                "TotalNumberOfBeds int NOT NULL, " +
                "TelephoneExtensionNumber int NOT NULL " +
                ")";
            string createStaff = " CREATE TABLE Staff( " +
                "ID int NOT NULL PRIMARY KEY, " +
                "FirstName nchar(10) NOT NULL, " +
                "LastName nchar(10) NOT NULL, " +
                "Telephone nchar(10) NOT NULL, " +
                "DateOfBirth date NOT NULL, " +
                "Gender bit NOT NULL, " +
                "InsuranceNumber int NOT NULL, " +
                "CurrentSalary int NOT NULL " +
                ")";

            string createQualification = " CREATE TABLE Qualification( " +
                "ID int NOT NULL PRIMARY KEY, " +
                "FirstName nchar(10) NOT NULL, " +
                "LastName nchar(10) NOT NULL, " +
                "Telephone nchar(10) NOT NULL, " +
                "DateOfBirth date NOT NULL, " +
                "Gender bit NOT NULL, " +
                "InsuranceNumber int NOT NULL, " +
                "CurrentSalary int NOT NULL " +
                ")"; ;
            string createWorkExperienceDetail;
            string createTypeOfEmploymentContract;
            string createPatient;
            string createPatientNextToKin;
            string createLocalDoctors;
            string createOutPatient;
            string createPatientAppointment;
            string createInPantient;
            string createPatientMedication;
            string createSurgicalNonSurgicalSupplies;
            string createUsedByWard;
            string createSuppliers;
            string createWardPatientStaffJoined;
            string createWardRequisition;
            string createPharmaceuticalSupplies;




            queryString = createDatabase + createWard + createStaff;

            int errorCode = RunCommand(queryString);
            //string script = File.ReadAllText(@"C:\Users\X220\Desktop\ucn\2 semester\database\first delivirable\WellmeadowsRelational\WellmeadowsRelational\Database\MeadowSQLdatabase.sql");
            //-2146232060
            
            if(errorCode == -2146232060)
            {
                //all ready exists in database
                //continue or delete?
               errorCode = Delete();
               
            }
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
        
        private static int RunCommand(string queryString)
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
