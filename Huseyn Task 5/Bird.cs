using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huseyn_Task_5
{
    public class Bird
    {
        public int WingCount { get; set; }
        public string Color { get; set; }

        public void Fly()
        {
            Console.WriteLine("Quş uçur");
        }
    }
}
