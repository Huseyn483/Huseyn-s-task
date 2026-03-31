using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetil_task_3
{
    public class Character
    {
        public string name;
        public int health;
        public int power;
        public virtual void ShowStats()
        {
            Console.WriteLine(name);
            Console.WriteLine(health);
            Console.WriteLine(power);
        }
        public Character(string name,int health,int power)
        {
            this.name = name;
            this.health = health;
            this.power = power;
        }
    }
}
