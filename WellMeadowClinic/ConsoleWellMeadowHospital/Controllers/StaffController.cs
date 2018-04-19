using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleWellMeadowHospital.Database;

namespace ConsoleWellMeadowHospital.Controllers
{
    class StaffController
    {
        int Create()
        {
            //insert
            string insert = "";
            InitializeDatabase.RunCommand(insert);
            return 0;
        }
        int Read()
        {
            return 0;
        }
        int Update()
        {
            return 0;
        }
        int Delete()
        {
            return 0;
        }

    }
}
