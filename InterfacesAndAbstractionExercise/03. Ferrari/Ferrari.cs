using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Ferrari
{
    class Ferrari : ICar
    {
        public Ferrari(string driverName)
        {
            this.Model = "488-Spider";
            this.DriverName = driverName;
            this.UseBreaks = "Brakes!";
            this.PushTheGas = "Zadu6avam sA!";
        }

        public string Model { get; private set; }
        public string DriverName { get; private set; }

        public string UseBreaks { get; private set; }

        public string PushTheGas
        {
            get; private set;
        }




    }
}
