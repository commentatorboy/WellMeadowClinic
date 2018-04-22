using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWellMeadowHospital.Database
{
    class Ward
    {
        int wardNumber;
        string wardName;
        string location;
        int totalNumberOfBeds; //max 17 per ward
        string telephoneExtentionNumber;

        public int WardNumber { get; set; }
        public string WardName { get; set; }
        public string Location { get; set; }
        public string TelephoneExtentionNumber { get; set; }

        public int TotalNumberOfBeds {
            get
            {
                return totalNumberOfBeds;
            }
            set
            {
                if(value < 17)
                {
                    totalNumberOfBeds =  value;
                }
                else
                {
                    totalNumberOfBeds = 17;
                }

            }
        }
    }
}
