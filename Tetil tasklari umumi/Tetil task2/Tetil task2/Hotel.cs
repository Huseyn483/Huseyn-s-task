using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetil_task2
{
    public class Hotel : Travel
    {
        public string hotelName;
        public int starCount;

        public Hotel(string hotelName, int starCount, string destination, double price) : base(destination, price)
        {
            this.hotelName = hotelName;
            this.starCount = starCount;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("otelin adi:" + hotelName);
            Console.WriteLine("otelin ulduzlarinin sayi:" + starCount);
        }
    } 
  
    
}
