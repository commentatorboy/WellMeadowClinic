using ConsoleWellMeadowHospital.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWellMeadowHospital.Controllers
{
    class PatientController
    {
        public SqlException Create(Patient p)
        {
            //insert
            string insert = "INSERT INTO Patient (PatientNumber, FirstName, LastName, Address, MaritalStatus, Gender, Telephone, DateOfBirth)" +
                " VALUES(@PatientNumber, @FirstName, @LastName, @Address, @MaritalStatus, @Gender, @Telephone, @DateOfBirth)";

            //create sql command, insert query, preparing quries, create parameterized quieries, 

            // 1. declare command object with parameter + insert query
            SqlCommand cmd = InitializeDatabase.CreateSqlCommand(insert);


            // 2. define parameters used in command object
            List<SqlParameter> prm = new List<SqlParameter>()
            {
                new SqlParameter("@PatientNumber", SqlDbType.Int) {Value = p.PatientNumber},
                new SqlParameter("@FirstName", SqlDbType.NVarChar) {Value = p.FirstName},
                new SqlParameter("@LastName", SqlDbType.NVarChar) {Value = p.LastName},
                new SqlParameter("@Address", SqlDbType.NVarChar) {Value = p.Address},
                new SqlParameter("@MaritalStatus", SqlDbType.NVarChar) {Value = p.MartialStatus},
                new SqlParameter("@Gender", SqlDbType.NVarChar) {Value = p.Gender},
                new SqlParameter("@Telephone", SqlDbType.NVarChar) {Value = p.Telephone},
                new SqlParameter("@DateOfBirth", SqlDbType.DateTime) {Value = p.DateOfBirth},

            };

            // 3. add new parameter to command object
            cmd.Parameters.AddRange(prm.ToArray());

            //run
            SqlException res = InitializeDatabase.RunSqlCommand(cmd);

            return res;
        }

        public int Read()
        {
            string select;
            return 0;
        }
        public int Update()
        {
            string update;
            return 0;
        }
        public int Delete()
        {
            string delete;
            return 0;
        }
    }

}
