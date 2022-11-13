using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlonWork_13
{
    class MultiBuilding:Building
    {
        int nomberOfStoreys;
       
        int NomberOfStoreys
        {
            get
            {
                return nomberOfStoreys;
            }
            set
            {
                if (value < 1)
                    nomberOfStoreys = 1;
                else
                    nomberOfStoreys = value;
            }
        }
             public MultiBuilding(string adress, double lenght, double width, double height, int nomberOfStoreys)
            : base(adress, lenght, width, height)
        {
            this.NomberOfStoreys = nomberOfStoreys;
        }

        public string Print()
        {
            string result = base.Print();
            result += $"Этажность: {nomberOfStoreys}";
            return result;
        }


    }
}
