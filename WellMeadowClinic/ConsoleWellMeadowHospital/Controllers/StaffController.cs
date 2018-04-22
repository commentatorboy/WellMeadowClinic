using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleWellMeadowHospital.Database;
using System.Data.SqlClient;
using System.Data;

namespace ConsoleWellMeadowHospital.Controllers
{
    class StaffController
    {
        public SqlException Create(Staff staff)
        {
            
            //insert
            string insert = "INSERT INTO Staff (StaffNumber, FirstName, LastName, FullAddress, DateOfBirth, Gender, InsuranceNumber, CurrentPosition, CurrentSalary, SalaryScale, NumberOfHoursPerWeek, PermenantOrTemporary, SalaryPayment, AppointmentNumber, WorkExperienceID, QualificationID)" +
                " VALUES(@StaffNumber, @FirstName, @LastName, @FullAddress, @DateOfBirth, @Gender, @InsuranceNumber, @CurrentPosition, @CurrentSalary, @SalaryScale, @NumberOfHoursPerWeek, @PermenantOrTemporary, @SalaryPayment, @AppointmentNumber, @WorkExperienceID, @QualificationID); ";

            //create sql command, insert query, preparing quries, create parameterized quieries, 

            // 1. declare command object with parameter + insert query
            SqlCommand cmd =  InitializeDatabase.CreateSqlCommand(insert);


            // 2. define parameters used in command object
            List<SqlParameter> prm = new List<SqlParameter>()
            {
                new SqlParameter("@StaffNumber", SqlDbType.Int) {Value = staff.StaffNumber},
                new SqlParameter("@FirstName", SqlDbType.NVarChar) {Value = staff.FirstName},
                new SqlParameter("@LastName", SqlDbType.NVarChar) {Value = staff.LastName},
                new SqlParameter("@FullAddress", SqlDbType.NVarChar) {Value = staff.FullAddress},
                new SqlParameter("@DateOfBirth", SqlDbType.DateTime) {Value = staff.DateOfBirth},
                new SqlParameter("@Gender", SqlDbType.NVarChar) {Value = staff.Gender},
                new SqlParameter("@InsuranceNumber", SqlDbType.Int) {Value = staff.InsuranceNumber},
                new SqlParameter("@CurrentPosition", SqlDbType.NVarChar) {Value = staff.CurrentPosition},
                new SqlParameter("@CurrentSalary", SqlDbType.Float) {Value = staff.CurrentSalary},
                new SqlParameter("@SalaryScale", SqlDbType.NVarChar) {Value = staff.SalaryScale},
                new SqlParameter("@NumberOfHoursPerWeek", SqlDbType.Int) {Value = staff.NumberOfHoursPerWeek},
                new SqlParameter("@PermenantOrTemporary", SqlDbType.NVarChar) {Value = staff.PermenentOrTemporary},
                new SqlParameter("@SalaryPayment", SqlDbType.NVarChar) {Value = staff.SalaryPayment},
                new SqlParameter("@AppointmentNumber", SqlDbType.Int) {Value = staff.AppointmentNumber},
                new SqlParameter("@WorkExperienceID", SqlDbType.Int) {Value = staff.WorkExperienceID},
                new SqlParameter("@QualificationID", SqlDbType.Int) {Value = staff.QualificationID},
            };

            // 3. add new parameter to command object
            cmd.Parameters.AddRange(prm.ToArray());

            //run
            SqlException res = InitializeDatabase.RunSqlCommand(cmd);

            return res;
        }
        public SqlException Read()
        {
            string select = "SELECT * FROM Staff";

            // 1. declare command object with parameter + insert query
            SqlCommand cmd = InitializeDatabase.CreateSqlCommand(select);

            SqlException res = InitializeDatabase.RunSqlCommand(cmd);


            return res;
        }
        public SqlException Update(Staff staff, int id)
        {
            string update = "UPDATE Staff " +
                "SET StaffNumber = @StaffNumber, FirstName = @FirstName, LastName = @LastName, FullAddress = @FullAddress, DateOfBirth = @DateOfBirth, " +
                "Gender = @Gender, InsuranceNumber = @InsuranceNumber, CurrentPosition = @CurrentPosition, CurrentSalary = @CurrentSalary, " +
                "SalaryScale = @SalaryScale, NumberOfHoursPerWeek = @NumberOfHoursPerWeek, PermenantOrTemporary = @PermenantOrTemporary, " +
                "SalaryPayment = @SalaryPayment, AppointmentNumber = @AppointmentNumber, WorkExperienceID = @WorkExperienceID, QualificationID = @QualificationID " +
                "WHERE StaffNumber = @id;";

            // 1. declare command object with parameter + insert query
            SqlCommand cmd = InitializeDatabase.CreateSqlCommand(update);


            // 2. define parameters used in command object
            List<SqlParameter> prm = new List<SqlParameter>()
            {
                new SqlParameter("@StaffNumber", SqlDbType.Int) {Value = staff.StaffNumber},
                new SqlParameter("@FirstName", SqlDbType.NVarChar) {Value = staff.FirstName},
                new SqlParameter("@LastName", SqlDbType.NVarChar) {Value = staff.LastName},
                new SqlParameter("@FullAddress", SqlDbType.NVarChar) {Value = staff.FullAddress},
                new SqlParameter("@DateOfBirth", SqlDbType.DateTime) {Value = staff.DateOfBirth},
                new SqlParameter("@Gender", SqlDbType.NVarChar) {Value = staff.Gender},
                new SqlParameter("@InsuranceNumber", SqlDbType.Int) {Value = staff.InsuranceNumber},
                new SqlParameter("@CurrentPosition", SqlDbType.NVarChar) {Value = staff.CurrentPosition},
                new SqlParameter("@CurrentSalary", SqlDbType.Float) {Value = staff.CurrentSalary},
                new SqlParameter("@SalaryScale", SqlDbType.NVarChar) {Value = staff.SalaryScale},
                new SqlParameter("@NumberOfHoursPerWeek", SqlDbType.Int) {Value = staff.NumberOfHoursPerWeek},
                new SqlParameter("@PermenantOrTemporary", SqlDbType.NVarChar) {Value = staff.PermenentOrTemporary},
                new SqlParameter("@SalaryPayment", SqlDbType.NVarChar) {Value = staff.SalaryPayment},
                new SqlParameter("@AppointmentNumber", SqlDbType.Int) {Value = staff.AppointmentNumber},
                new SqlParameter("@WorkExperienceID", SqlDbType.Int) {Value = staff.WorkExperienceID},
                new SqlParameter("@QualificationID", SqlDbType.Int) {Value = staff.QualificationID},
                new SqlParameter("@id", SqlDbType.Int) {Value = id},


            };

            // 3. add new parameter to command object
            cmd.Parameters.AddRange(prm.ToArray());

            //run
            SqlException res = InitializeDatabase.RunSqlCommand(cmd);

            return res;
        }
        public SqlException Delete(int id)
        {
            string delete = "DELETE Staff WHERE StaffNumber = @id";

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
