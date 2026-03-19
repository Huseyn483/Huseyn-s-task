using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huseyn_Task_5
{
   public class Eagle : Bird
    {
        public int VisionPower { get; set; }

        public void Hunt()
        {
            Console.WriteLine("Qartal ov edir");
        }
    }
}
