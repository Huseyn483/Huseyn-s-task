using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetil_task2
{
    public class Flight:Travel
    {
        public string airlineName;
        public string flightTime;

        public Flight(string airlineName, string flightTime,string destination,double price):base(destination,price)
        {
            this.airlineName = airlineName;
            this.flightTime = flightTime;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("hava limani adi:" + airlineName);
            Console.WriteLine("ucus vaxti:" + flightTime);
        }
    }
}
