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
        public int Create(Staff staff)
        {
            Staff s = new Staff();
            
            //insert
            string insert = "INSERT INTO Staff (StaffNumber, FirstName, LastName, FullAddress, DateOfBirth, Gender, InsuranceNumber, CurrentPosition, CurrentSalary, NumberOfHoursPerWeek, PermenentOrTemporary, SalaryPayment, AppointmentNumber, WorkExperience, QualificationID)" +
                " VALUES(@StaffNumber, @FirstName, @LastName, @FullAddress, @DateOfBirth, @Gender, @InsuranceNumber, @CurrentPosition, @CurrentSalary, @NumberOfHoursPerWeek, @PermenentOrTemporary, @SalaryPayment, @AppointmentNumber, @WorkExperience, @QualificationID); ";

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
                new SqlParameter("@CurrentPosition", SqlDbType.DateTime) {Value = staff.CurrentPosition},
                new SqlParameter("@CurrentSalary", SqlDbType.Float) {Value = staff.CurrentSalary},
                new SqlParameter("@SalaryScale", SqlDbType.NVarChar) {Value = staff.SalaryScale},
                new SqlParameter("@NumberOfHoursPerWeek", SqlDbType.Int) {Value = staff.NumberOfHoursPerWeek},
                new SqlParameter("@PermenentOrTemporary", SqlDbType.NVarChar) {Value = staff.PermenentOrTemporary},
                new SqlParameter("@SalaryPayment", SqlDbType.NVarChar) {Value = staff.SalaryPayment},
                new SqlParameter("@AppointmentNumber", SqlDbType.Int) {Value = staff.AppointmentNumber},
                new SqlParameter("@WorkExperience", SqlDbType.Int) {Value = staff.WorkExperience},
                new SqlParameter("@QualificationID", SqlDbType.Int) {Value = staff.QualificationID},
            };

            // 3. add new parameter to command object
            cmd.Parameters.AddRange(prm.ToArray());

            //run
            InitializeDatabase.RunSqlCommand(cmd);


            return 0;
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
