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
    class PatientAppointmentController
    {
        public SqlException Create(PatientAppointment PA)
        {

            //insert
            string insert = "INSERT INTO PatientAppointment (AppointmentNumber, DateOfAppointment, AppointmentRoom, PatientNumber)" +
                " VALUES(@AppointmentNumber, @DateOfAppointment, @AppointmentRoom, @PatientNumber)";

            //create sql command, insert query, preparing quries, create parameterized quieries, 

            // 1. declare command object with parameter + insert query
            SqlCommand cmd = InitializeDatabase.CreateSqlCommand(insert);


            // 2. define parameters used in command object
            List<SqlParameter> prm = new List<SqlParameter>()
            {
                new SqlParameter("@AppointmentNumber", SqlDbType.Int) {Value = PA.AppointmentNumber},
                new SqlParameter("@DateOfAppointment", SqlDbType.DateTime) {Value = PA.DateOfAppointment},
                new SqlParameter("@AppointmentRoom", SqlDbType.NVarChar) {Value = PA.AppointmentRoom},
                new SqlParameter("@PatientNumber", SqlDbType.Int) {Value = PA.PatientNumber},

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
