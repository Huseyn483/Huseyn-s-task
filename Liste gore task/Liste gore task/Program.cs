namespace Liste_gore_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
        {
            new Person { Name = "Ali", Surname = "Mammadov", Age = 30 },
            new Person { Name = "Veli", Surname = "Aliyev", Age = 50 },
            new Person { Name = "Aysel", Surname = "Huseynova", Age = 20 }
        };

            Console.WriteLine("1 - Ada görə");
            Console.WriteLine("2 - Soyada görə");
            Console.WriteLine("3 - Yasha görə");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Yanlış seçim!");
                return;
            }

            Console.Write("Axtarış dəyərini daxil et: ");
            string input = Console.ReadLine();

            List<Person> result = new List<Person>();

            switch (choice)
            {
                case 1:
                    result = people
                        .Where(p => p.Name.Contains(input, StringComparison.OrdinalIgnoreCase))
                        .ToList();
                    break;

                case 2:
                    result = people
                        .Where(p => p.Surname.Contains(input, StringComparison.OrdinalIgnoreCase))
                        .ToList();
                    break;

                case 3:
                    if (int.TryParse(input, out int age))
                    {
                        result = people
                            .Where(p => p.Age == age)
                            .ToList();
                    }
                    else
                    {
                        Console.WriteLine("Yaş düzgün deyil!");
                    }
                    break;

                default:
                    Console.WriteLine("Yanlış seçim!");
                    return;
            }

            if (result.Count == 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                foreach (Person p in result)
                {
                    Console.WriteLine($"{p.Name} {p.Surname} - {p.Age}");
                }
            }
        
    }
    }
}
