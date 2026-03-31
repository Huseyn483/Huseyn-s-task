using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetil_task_3
{
    public class Wizard:Character
    {
        public string MagicType;

        public Wizard(string name, int health, int power, string MagicType)
            : base(name, health, power)
        {
            this.MagicType = MagicType;
        }
        public void CastSpell()
        {
            Console.WriteLine(MagicType);
        }
       public override void ShowStats()
        {
            base.ShowStats();
        }
    }
}
