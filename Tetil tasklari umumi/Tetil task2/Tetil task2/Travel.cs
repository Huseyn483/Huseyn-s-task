using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetil_task2
{
    public class Travel
    {
        public string destination;
        public double price;

        public Travel(string destination, double price)
        {
            this.destination = destination;
            this.price = price;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine("Gedilecek yer:" + destination);
            Console.WriteLine("Qiymeti:" + price);
        }
    }
}
