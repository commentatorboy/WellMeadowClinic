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
    class WorkExperienceController
    {

        public SqlException Create(WorkExperience WE)
        {

        //insert
        string insert = "INSERT INTO WorkExperience (WorkExperienceID, PreviousPosition, NameOfOrganisation, StartDate, FinishDate)" +
                " VALUES(@WorkExperienceID, @PreviousPosition, @NameOfOrganisation, @StartDate, @FinishDate)";

            //create sql command, insert query, preparing quries, create parameterized quieries, 

            // 1. declare command object with parameter + insert query
            SqlCommand cmd = InitializeDatabase.CreateSqlCommand(insert);


            // 2. define parameters used in command object
            List<SqlParameter> prm = new List<SqlParameter>()
            {
                new SqlParameter("@WorkExperienceID", SqlDbType.Int) {Value = WE.WorkExperienceID},
                new SqlParameter("@PreviousPosition", SqlDbType.NVarChar) {Value = WE.PreviousPosition},
                new SqlParameter("@NameOfOrganisation", SqlDbType.NVarChar) {Value = WE.NameOfOrganisation},
                new SqlParameter("@StartDate", SqlDbType.DateTime) {Value = WE.StartDate},
                new SqlParameter("@FinishDate", SqlDbType.DateTime) {Value = WE.FinishDate},

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
