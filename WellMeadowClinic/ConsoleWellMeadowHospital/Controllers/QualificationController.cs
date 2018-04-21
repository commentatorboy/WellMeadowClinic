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
    class QualificationController
    {
        public SqlException Create(Qualification qualification)
        {

            //insert
            string insert = "INSERT INTO Qualification (DateOfQualification, NameOfInstitution, QualificationID, Type)" +
                "VALUES(@DateOfQualification, @NameOfInstitution, @QualificationID, @Type)";

            //create sql command, insert query, preparing quries, create parameterized quieries, 

            // 1. declare command object with parameter + insert query
            SqlCommand cmd = InitializeDatabase.CreateSqlCommand(insert);


            // 2. define parameters used in command object
            List<SqlParameter> prm = new List<SqlParameter>()
            {
                new SqlParameter("@DateOfQualification", SqlDbType.DateTime) {Value = qualification.DateOfQualification},
                new SqlParameter("@NameOfInstitution", SqlDbType.NVarChar) {Value = qualification.NameOfInstitution},
                new SqlParameter("@QualificationID", SqlDbType.Int) {Value = qualification.QualificationID},
                new SqlParameter("@Type", SqlDbType.NVarChar) {Value = qualification.Type},

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
