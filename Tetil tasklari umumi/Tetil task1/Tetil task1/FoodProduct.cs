using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetil_task1
{
    public class FoodProduct:Product
    {
        public string SonIstifadeTarixi;
        public FoodProduct(string name,double price,string SonIstifadeTarixi):base(name,price)
        {
            this.SonIstifadeTarixi=SonIstifadeTarixi;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("son istifade tarixi:"+SonIstifadeTarixi);
        }
    }
}

