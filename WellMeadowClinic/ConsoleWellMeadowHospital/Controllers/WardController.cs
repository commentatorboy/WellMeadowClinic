﻿using ConsoleWellMeadowHospital.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWellMeadowHospital.Controllers
{
    class WardController
    {
        public SqlException Create(Ward ward)
        {


            //insert
            string insert = "INSERT INTO Ward (Number, WardName, Location, TotalNumberOfBeds, TelephoneExtentionNumber)" +
                " VALUES(@WardNumber, @WardName, @Location, @TotalNumberOfBeds, @TelephoneExtentionNumber); ";

            //create sql command, insert query, preparing quries, create parameterized quieries, 

            // 1. declare command object with parameter + insert query
            SqlCommand cmd = InitializeDatabase.CreateSqlCommand(insert);


            // 2. define parameters used in command object
            List<SqlParameter> prm = new List<SqlParameter>()
            {
                new SqlParameter("@WardNumber", SqlDbType.Int) {Value = ward.WardNumber},
                new SqlParameter("@WardName", SqlDbType.NVarChar) {Value = ward.WardName},
                new SqlParameter("@Location", SqlDbType.NVarChar) {Value = ward.Location},
                new SqlParameter("@TotalNumberOfBeds", SqlDbType.Int) {Value = ward.TotalNumberOfBeds},
                new SqlParameter("@TelephoneExtentionNumber", SqlDbType.NVarChar) {Value = ward.TelephoneExtentionNumber}

            };

            // 3. add new parameter to command object
            cmd.Parameters.AddRange(prm.ToArray());

            //run
            SqlException res = InitializeDatabase.RunSqlCommand(cmd);

            return res;
        }
        public SqlException Read()
        {
            string select = "SELECT * FROM Ward";

            // 1. declare command object with parameter + insert query
            SqlCommand cmd = InitializeDatabase.CreateSqlCommand(select);

            SqlException res = InitializeDatabase.RunSqlCommand(cmd);


            return res;
        }
        public SqlException Update(Ward ward, int id)
        {
            string update = "UPDATE Ward " +
                "SET Number = @WardNumber, Location = @Location, TotalNumberOfBeds = @TotalNumberOfBeds, TelephoneExtentionNumber = @TelephoneExtentionNumber" + "WHERE WardNumber = @id;";

            // 1. declare command object with parameter + insert query
            SqlCommand cmd = InitializeDatabase.CreateSqlCommand(update);


            // 2. define parameters used in command object
            List<SqlParameter> prm = new List<SqlParameter>()
            {
                new SqlParameter("@WardNumber", SqlDbType.Int) {Value = ward.WardNumber},
                new SqlParameter("@Location", SqlDbType.NVarChar) {Value = ward.Location},
                new SqlParameter("@TotalNumberOfBeds", SqlDbType.Int) {Value = ward.TotalNumberOfBeds},
                new SqlParameter("@TelephoneExtentionNumber", SqlDbType.NVarChar) {Value = ward.TelephoneExtentionNumber},
                
                new SqlParameter("@id", SqlDbType.Int) {Value = id}


            };

            // 3. add new parameter to command object
            cmd.Parameters.AddRange(prm.ToArray());

            //run
            SqlException res = InitializeDatabase.RunSqlCommand(cmd);

            return res;
        }
        public SqlException Delete(int id)
        {
            string delete = "DELETE Ward WHERE Number = @id";

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
