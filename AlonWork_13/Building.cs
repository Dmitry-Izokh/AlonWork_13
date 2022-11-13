using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlonWork_13
{
    class Building
    {
        string adress;
        double lenght;
        double width;
        double height;

        double Lenght
        {
            get
            {
                return lenght;
            }
            set
            {
                if (value < 1)
                    lenght = 1;
                else if (value >= 1)
                    lenght = value;
            }
        }
        double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value < 1)
                    width = 1;
                else if (value >= 1)
                    width = value;
            }
        }
        double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 3)
                    height = 3;
                else if (value >= 3)
                    height = value;
            }
        }

            public Building(string adress, double lenght, double width, double height)
        {
            this.adress = adress;
            this.Lenght = lenght;
            this.Width = width;
            this.Height = height;
        }

        public string Print()
        {
            return $"Адрес:{adress}; Длина здания:{lenght}; Ширина здания:{ width}; Высота здания: { width}; "; 
        }
        
    }

    
}
