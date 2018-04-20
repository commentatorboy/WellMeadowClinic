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
        string location;
        int totalNumberOfBeds; //max 17 per ward
        string telephoneExtentionNumber;

        public int WardNumber {
            get
            {
                return wardNumber;
            }
            set
            {
                if(value < 17)
                {
                    wardNumber =  value;
                }
                else
                {
                    wardNumber = 17;
                }

            }
        }
    }
}
