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
    class InPatientsController
    {

        public SqlException Create(InPatient ip)
        {
            //insert
            string insert = "INSERT INTO InPatient (PatientNumber, WardNumber, InWardOrWaitingList, DateExpectedToLeave, DatePlacedOnWaitingList, ExpectedDurationOfStay, ActualDateLeft)" +
                " VALUES(@PatientNumber, @WardNumber, @InWardOrWaitingList, @DateExpectedToLeave, @DatePlacedOnWaitingList, @ExpectedDurationOfStay, @ActualDateLeft)";

            //create sql command, insert query, preparing quries, create parameterized quieries, 

            // 1. declare command object with parameter + insert query
            SqlCommand cmd = InitializeDatabase.CreateSqlCommand(insert);


            // 2. define parameters used in command object
            List<SqlParameter> prm = new List<SqlParameter>()
            {
                new SqlParameter("@PatientNumber", SqlDbType.Int) {Value = ip.PatientNumber},
                new SqlParameter("@WardNumber", SqlDbType.Int) {Value = ip.WardNumber},
                new SqlParameter("@DatePlacedOnWaitingList", SqlDbType.DateTime) {Value = ip.DatePlacedOnWaitingList},
                new SqlParameter("@ExpectedDurationOfStay", SqlDbType.Int) {Value = ip.ExpectedDurationOfStay},
                new SqlParameter("@ActualDateLeft", SqlDbType.DateTime) {Value = ip.ActualDateLeft},
                new SqlParameter("@InWardOrWaitingList", SqlDbType.NVarChar) {Value = ip.InWardOrWaitingList},
                new SqlParameter("@DateExpectedToLeave", SqlDbType.DateTime) {Value = ip.DateExpectedToLeave},


            };

            // 3. add new parameter to command object
            cmd.Parameters.AddRange(prm.ToArray());

            //run
            SqlException res = InitializeDatabase.RunSqlCommand(cmd);

            return res;
        }
        
        public SqlException Read(int wardNumber)
        {
            string select = "SELECT Patient.FirstName, Patient.LastName, Ward.Number FROM Patient " +
                "JOIN InPatient ON Patient.PatientNumber=InPatient.PatientNumber JOIN Ward ON Ward.Number=InPatient.WardNumber " +
                "WHERE Ward.Number = @WardNumber";

            // 1. declare command object with parameter + insert query
            SqlCommand cmd = InitializeDatabase.CreateSqlCommand(select);


            // 2. define parameters used in command object
            List<SqlParameter> prm = new List<SqlParameter>()
            {
                new SqlParameter("@WardNumber", SqlDbType.Int) {Value = wardNumber}
            };


            // 3. add new parameter to command object
            cmd.Parameters.AddRange(prm.ToArray());

            SqlException res = InitializeDatabase.RunSqlCommand(cmd);


            return res;
        }
        public SqlException Update(InPatient ip, int patientID)
        {
            string update = "UPDATE InPatient " +
                "SET PatientNumber = @PatientNumber, WardNumber = @WardNumber, DatePlacedOnWaitingList = @DatePlacedOnWaitingList," +
                "ExpectedDurationOfStay = @ExpectedDurationOfStay, ActualDateLeft = @ActualDateLeft, InWardOrWaitingList = @InWardOrWaitingList" +
                "WHERE PatientNumber = @PatientID;";

            // 1. declare command object with parameter + insert query
            SqlCommand cmd = InitializeDatabase.CreateSqlCommand(update);


            // 2. define parameters used in command object
            List<SqlParameter> prm = new List<SqlParameter>()
            {
                new SqlParameter("@PatientNumber", SqlDbType.Int) {Value = ip.PatientNumber},
                new SqlParameter("@WardNumber", SqlDbType.Int) {Value = ip.WardNumber},
                new SqlParameter("@DatePlacedOnWaitingList", SqlDbType.DateTime) {Value = ip.DatePlacedOnWaitingList},
                new SqlParameter("@ExpectedDurationOfStay", SqlDbType.Int) {Value = ip.ExpectedDurationOfStay},
                new SqlParameter("@ActualDateLeft", SqlDbType.DateTime) {Value = ip.ActualDateLeft},
                new SqlParameter("@PatientID", SqlDbType.Int) {Value = patientID},
                new SqlParameter("@InWardOrWaitingList", SqlDbType.DateTime) {Value = ip.InWardOrWaitingList}
            };

            // 3. add new parameter to command object
            cmd.Parameters.AddRange(prm.ToArray());

            //run
            SqlException res = InitializeDatabase.RunSqlCommand(cmd);

            return res;
        }
        public SqlException Delete(int id)
        {
            string delete = "DELETE InPatient WHERE PatientNumber = @id";

            SqlCommand cmd = InitializeDatabase.CreateSqlCommand(delete);

            List<SqlParameter> prm = new List<SqlParameter>()
            {
                new SqlParameter("@id", SqlDbType.Int) {Value = id}
            };

            // 3. add new parameter to command object
            cmd.Parameters.AddRange(prm.ToArray());

            SqlException res = InitializeDatabase.RunSqlCommand(cmd);

            return res;
        }
    }
}
