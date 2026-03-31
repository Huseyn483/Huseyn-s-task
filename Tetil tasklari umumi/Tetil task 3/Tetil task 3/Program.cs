namespace Tetil_task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior numune1 = new Warrior("Ejderha", 50, 40, "Od");
            Wizard numune2= new Wizard("Numune", 80, 70, "numune");
            numune1.ShowStats();
            numune1.Attack(); 

            numune2.ShowStats();
            numune2.CastSpell(); 
        }
    }
}
