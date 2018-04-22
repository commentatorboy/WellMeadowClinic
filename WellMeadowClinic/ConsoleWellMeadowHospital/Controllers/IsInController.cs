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
    class IsInController
    {
        public SqlException Create(IsIn isin)
        {


            //insert "Number" is ward number
            string insert = "INSERT INTO IsIn (Shift, StaffNumber, Number)" +
                " VALUES(@Shift, @StaffNumber, @Number); ";

            //create sql command, insert query, preparing quries, create parameterized quieries, 

            // 1. declare command object with parameter + insert query
            SqlCommand cmd = InitializeDatabase.CreateSqlCommand(insert);


            // 2. define parameters used in command object
            List<SqlParameter> prm = new List<SqlParameter>()
            {
                new SqlParameter("@Shift", SqlDbType.NVarChar) {Value = isin.Shift},
                new SqlParameter("@StaffNumber", SqlDbType.Int) {Value = isin.StaffNumber},
                new SqlParameter("@Number", SqlDbType.Int) {Value = isin.WardNumber}

            };

            // 3. add new parameter to command object
            cmd.Parameters.AddRange(prm.ToArray());

            //run
            SqlException res = InitializeDatabase.RunSqlCommand(cmd);

            return res;
        }
        public SqlException Read()
        {
            string select = "SELECT Staff.FirstName, Staff.LastName, Ward.Number FROM Staff " +
                "JOIN IsIn ON Staff.StaffNumber=IsIn.StaffNumber JOIN Ward ON Ward.Number=IsIn.Number";

            // 1. declare command object with parameter + insert query
            SqlCommand cmd = InitializeDatabase.CreateSqlCommand(select);

            SqlException res = InitializeDatabase.RunSqlCommand(cmd);


            return res;
        }
        public SqlException Update(IsIn isin, int wardNumber)
        {
            string update = "UPDATE IsIn " +
                "SET Shift = @Shift, StaffNumber = @StaffNumber" + "WHERE Number = @wardNumber;";

            // 1. declare command object with parameter + insert query
            SqlCommand cmd = InitializeDatabase.CreateSqlCommand(update);


            // 2. define parameters used in command object
            List<SqlParameter> prm = new List<SqlParameter>()
            {
                new SqlParameter("@Shift", SqlDbType.Int) {Value = isin.Shift},
                new SqlParameter("@StaffNumber", SqlDbType.NVarChar) {Value = isin.StaffNumber},
                new SqlParameter("@Number", SqlDbType.Int) {Value = isin.WardNumber}

            };

            // 3. add new parameter to command object
            cmd.Parameters.AddRange(prm.ToArray());

            //run
            SqlException res = InitializeDatabase.RunSqlCommand(cmd);

            return res;
        }
        public SqlException Delete(int id)
        {
            string delete = "DELETE IsIn WHERE IsInNumber = @id";

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
