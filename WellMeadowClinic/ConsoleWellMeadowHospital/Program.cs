﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleWellMeadowHospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.InitialzeDatabase.ConnectAndCreate();

        }
    }
}