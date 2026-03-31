using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetil_task1
{
    public class Product
    {
        public string name;
        public double price;

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine("mehsul adi:"+name);
            Console.WriteLine("mehsulun qiymeti"+price);
        }

    }
}
