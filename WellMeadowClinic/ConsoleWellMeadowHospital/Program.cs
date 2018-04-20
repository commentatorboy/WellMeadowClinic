using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleWellMeadowHospital.Database;
using ConsoleWellMeadowHospital.Controllers;

namespace ConsoleWellMeadowHospital
{
    class Program
    {
        static void Main(string[] args)
        {
            InitializeDatabase.ConnectAndCreate();

            Staff staff = new Staff();
            staff.CurrentPosition = ""; 

            StaffController sc = new StaffController();
            sc.Create(staff);
            InitializeDatabase.
        }
    }
}
