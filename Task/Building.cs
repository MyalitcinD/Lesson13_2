using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Building
    {
        public string Adress { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }

        public Building(string adress, double length, double width, double height)
        {
            Height = height;
            Adress = adress;
            Width = width;
            Length = length;
        }

        public string Print()
        {
            return $"Адресс здания - {Adress}\nДлина здания - {Length}\nШирина здания - {Width}\nВысота здания - {Height}";
        }

    }


}
