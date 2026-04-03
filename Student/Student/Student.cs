using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Student
    {
        public string Name;
        public int Age;
        public int ExamScore;
        public int PassingScore;
        public void Netice()
        {
            if (ExamScore >= PassingScore)
            {
                Console.WriteLine("Telebe kecdi");
            }
            else
            {
                int bal = PassingScore - ExamScore;
                Console.WriteLine("Telebe kesildi");
                Console.WriteLine("Kecmek ucun lazim olan bal: " + bal);
            }
        }
    }
}
