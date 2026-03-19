namespace Huseyn_Task_5
{
   public class Program
    {
        static void Main()
        {
            Eagle myEagle = new Eagle();

            myEagle.WingCount = 2;
            myEagle.Color = "Qəhvəyi";
            myEagle.VisionPower = 100;
            Console.WriteLine($"Qartalın rəngi: {myEagle.Color}, Qanad sayı: {myEagle.WingCount}");

            myEagle.Fly();

            myEagle.Hunt();
        }
    }
}
