using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    sealed class MultiBuilding : Building
    {
        public int Storeys;
        public MultiBuilding(string adress, double lenght, double width, double height, int storeys)
        : base(adress, lenght, width, height)
        {
            Storeys = storeys;
        }
        public string Print()
        {
            string res = base.Print();
            res += $"\nЭтажей в здании - {Storeys}";
            return res;
        }
    }
}
