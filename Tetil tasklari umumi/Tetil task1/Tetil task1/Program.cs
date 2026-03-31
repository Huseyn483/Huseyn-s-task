namespace Tetil_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FoodProduct numune = new FoodProduct("alma", 7.5, "20.04.2027");
            ElectronicProduct numune1 = new ElectronicProduct("komputer", 1700, "1 il");
            numune.ShowInfo();
            numune1.ShowInfo();
        }
    }
}
