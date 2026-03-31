using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetil_task_3
{
    public class Warrior : Character
    {
        public string weapon;
        public Warrior(string name, int health, int power, string weapon) : base(name, health, power)
        {
            this.weapon = weapon;
        }
        public void Attack()
        {
            Console.WriteLine(weapon);
        }

        public override void ShowStats()
        {
            base.ShowStats();
        }

    }
}
