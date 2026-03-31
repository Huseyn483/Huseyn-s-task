using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetil_task1
{
    public class ElectronicProduct:Product
    {
        public string ZemanetMuddeti;
        public ElectronicProduct(string name,double price,string ZemanetMuddeti):base(name,price)
        {
            this.ZemanetMuddeti = ZemanetMuddeti;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("zemanet muddeti:" + ZemanetMuddeti);
        }
        
    }
}
