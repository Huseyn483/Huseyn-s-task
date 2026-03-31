using System.Reflection.Metadata;

namespace Tapsiriqlar
/*{
 * İstifadəçidən 5 ədəd alın və daxil edilən ədədlərdən ən böyüyünü və ən kiçiyini tapan method yazın. 
 * 
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());

            EbEk(a, b, c, d, e);
        }
        static void EbEk(double a, double b, double c, double d, double e)
        {
            double[] arr = [ a, b, c, d, e ];
            double mx = arr[0];
            double mn = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > mx) 
                    mx = arr[i];
                if (arr[i] < mn) 
                    mn = arr[i];
            }

            Console.WriteLine("en boyuk eded: " + mx);
            Console.WriteLine("en kicik eded: " + mn);
        }
    }
}

*/



/*{

    İki ədəd qəbul edən method yazın və onların cəmini qaytarsın.
    Eyni adı istifadə edərək, double tipli iki ədəd üçün də cəmi 
    qaytaran method overloading tətbiq edin. 
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 7;
            double m = 3.5;
            double n = 2.4;

            Console.WriteLine(Cemle(x, y));
            Console.WriteLine(Cemle(m, n));
        }
        static int Cemle(int a, int b)
        {
            return a + b;
        }
        static double Cemle(double a, double b)
        {
            return a + b;
        }
    }
}
*/



/*İstifadəçi bir ədəd daxil etsin.Method yazın ki, ededin default parametr olaraq kvadrat hesablansın.
 Əgər istifadəçi kub istəsə, nəticə kub olsun.
{
    internal class Program
    {
       static void Main(string[] args)
        {
            int eded = int.Parse(Console.ReadLine());

            Console.WriteLine(Hesabla(eded));
            Console.WriteLine(Hesabla(eded, 3));
        }
        static int Hesabla(int x, int quvvet = 2)
        {
            if (quvvet == 2)
                return x * x;
            else
                return x * x * x;
        }
    }
}
*/



/*{
    Verilmiş array-dəki tək və cüt ədədlərin sayını hesablayan method yazın.
    Əgər tək ədədlər çoxdursa ekrana “Tək ədədlər çoxdur”, əks halda “Cüt ədədlər çoxdur” yazılsın.
    internal class Program
{
    static void Main(string[] args)
    {
            int[] arr = [2, 5, 8, 7, 3, 1];
            Muqayise(arr);
    }
    static void Muqayise(int[] arr)
        {
            int say1 = 0;
            int say2 = 0;
            for(int i=0;i<arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    say1 = say1 + 1;
                else
                {
                    say2 = say2 + 1;
                }
            }

            if (say2 > say1)
                Console.WriteLine("tek ededler coxdur");
            else if (say2 < say1)
                Console.WriteLine("cut ededler coxdur");
        }
    
}
}*/




/*{
    İstifadəçidən ad və soyad alın, default olaraq soyad “Naməlum” olsun.Method ilə ekrana çıxarın.
    internal class Program
{
    static void Main(string[] args)
    {
        string ad=Console.ReadLine();
        string soyad=Console.ReadLine();
        AdSoyad(ad);
        AdSoyad(ad, soyad);

    }
     static void AdSoyad(string ad,string soyad = "Namelum")
        {
            Console.WriteLine(ad + " " + soyad);
               
        }
}
}

*/




/*
{
    İki və üç ədəd üçün cəmi və ya hasili qaytaran method yazın.Default parametr multiply = false olsun.

    internal class Program
{
        static void Main(string[] args)
        {
            Console.WriteLine(Hesabla(2, 3, 4));
            Console.WriteLine(Hesabla(3, 5, 2, true));
        }

        static int Hesabla(int a, int b, bool multiply = false)
        {
            if (multiply)
                return a * b; 
            else
                return a + b; 
        }

        static int Hesabla(int a, int b, int c, bool multiply = false)
        {
            if (multiply)
                return a * b * c; 
            else
                return a + b + c; 
        }

}
   
}
*/




/*{
    Verilmiş int array qəbul edən method yazın.
    Optional parametr reverse = false olsun.
    Əgər reverse = true olsa array-ı tərsinə çap etsin, əks halda normal sırada. 
internal class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        CapEt(arr);
        CapEt(arr, true);
    }
    static void CapEt(int[] array, bool reverse = false)
    {
        if (reverse == true)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
}



*/




/*{

 Verilmiş array-dəki bütün ədədləri kvadratlayan method yazın.
internal class Program
{
    static void Main(string[] args)
    {
            int[] arr = { 5, 2, 3, 4, 5, 2 };
            Kvadratlayan(arr);

    }
        static void Kvadratlayan(int[] massiv)
        {
            for (int i = 0; i < massiv.Length; i++)
            {
                Console.WriteLine(massiv[i] * massiv[i]);
            }
        }
}
}*/






/*{
    İstifadəçidən bir cümlə alın və method yazın ki, bu cümlədəki sözlərin sayını hesablasın.
    Optional parametr olaraq ignoreCase = true qoyun ki, böyük/kiçik hərfləri fərqləndirməsin.

internal class Program
    {
        static void Main(string[] args)
        {
            string cumle = Console.ReadLine();

            int sozSay = SozSay(cumle);
            Console.WriteLine(sozSay);
        }
        static int SozSay(string cumle, bool ignoreCase = true)
        {
            if (ignoreCase)
                cumle = cumle.ToLower();
            string[] sozler = cumle.Split(' ');
            int say = 0;
            for (int i = 0; i < sozler.Length; i++)
            {
                if (sozler[i] != "") 
                    say++;
            }
            return say;
        }
    }
}
*/




/*{
    Verilmiş int array-də ən böyük və ən kiçik ədədlərin fərqini qaytaran method yazın
internal class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 5, 8, 2, 10, 3 };

        int ferq = Ferq(arr);
        Console.WriteLine(ferq);
    }
    static int Ferq(int[] array)
    {
        int min = array[0];
        int max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
                max = array[i];
            if (array[i] < min)
                min = array[i];
        }

        return max - min;
    }
}
}
*/




/*{
    İki və ya üç string qəbul edən method yazın və onları birləşdirərək bir cümlə çıxarsın.
    Default parametr olaraq 3 - cü string “.” (nöqtə) olsun.
internal class Program
    {
        static void Main(string[] args)
        {
            string soz1 = "salam";
            string soz2 = "necesen";
            string soz3 = "ne var ne yox";

            Birlesdir(soz1, soz2, soz3);
            Birlesdir(soz1, soz2);

        }
        static void Birlesdir(string soz1,string soz2,string soz3 = ".")
        {
            Console.WriteLine(soz1+" "+ soz2+ " "+ soz3);
        }

    }
}*/





/*{ 
  Array-dəki bütün ədədləri toplayan method yazın, optional parametr skipNegatives = false olsun.
  Əgər true olarsa mənfi ədədləri toplamaya daxil etməsin.
internal class Program
{
    static void Main(string[] args)
    {
        int[] arr = [5, -3, 8, -1, 4];
        int topla1 = Topla(arr);
        Console.WriteLine(topla1);
        int topla2 = Topla(arr, true);
        Console.WriteLine(topla2);
    }
    static int Topla(int[] array, bool skipNegatives = false)
    {
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (skipNegatives == true && array[i] < 0)
            {
                continue;
            }

            sum += array[i];
        }

        return sum;
    }
}
}*/




/*{
    Verilmiş array-dəki bütün tək ədədləri array-in tərs sıralamasında çap edən method yazın.
    Optional parametr includeEven = false olsun, əgər true olsa cüt ədədlər də çap olunsun.
   internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [ 1, 2, 3, 4, 5, 6 ];
            TekCapEt(arr);
            TekCapEt(arr, true);
        }
        static void TekCapEt(int[] array, bool includeEven = false)
        {
            for (int i = array.Length - 1; i >= 0; i--) 
            {
                if (includeEven == false && array[i] % 2 == 0)
                {
                    continue;
                }
                Console.Write(array[i] + " ");
            }
        }
    }
}
*/




/*{
    Bir array içində təkrarlanan ədədləri tapan method yaz.
    Əgər təkrarlanan ədəd tapılarsa, onları ekrana çıxar, tapılmazsa “Təkrarlanan ədəd yoxdur” mesajı göstər.  
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 2, 4, 5, 1 };
            Tekrar(arr);
        }
        static void Tekrar(int[] array)
        {
            int h = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int f = 0; ;
                for (int k = 0; k < i; k++)
                {
                    if (array[k] == array[i])
                    {
                        f=1;
                        break;
                    }
                }

                if (f==1)
                    continue;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        Console.Write(array[i] + " ");
                        h=1;
                        break;
                    }
                }
            }

            if (h==0)
            {
                Console.WriteLine("Təkrarlanan ədəd yoxdur");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}*/





/*{
    İstifadəçidən mətn daxil etməsini istəyən method yaz.
    Dövr istifadə edərək mətndəki saitlərin sayını tap.
    Əgər sait sayı 0-dan böyükdürsə, sayını göstər, yoxsa “Sait yoxdur” mesajı ver.  
    internal class Program
    {
        static void Main(string[] args)
        {
            SaitSay();
        }
        static void SaitSay()
        {
            string metn = Console.ReadLine();
            int saitSay = 0;
            string saitler = "aeiouAEIOU";

            for (int i = 0; i < metn.Length; i++)
            {
                if (saitler.Contains(metn[i]))
                {
                    saitSay=saitSay+1;
                }
            }
            if (saitSay > 0)
            {
                Console.WriteLine(saitSay);
            }
            else
            {
                Console.WriteLine("Sait yoxdur");
            }
        }
    }
}*/




/*{
    İstifadəçidən bir ədəd daxil etməsini istəyən method yaz.
    Dövr vasitəsilə daxil edilən ədədlərdən yalnız müsbət ədədləri toplayaraq cəmi ekrana çıxar.
    Mənfi ədəd daxil edildikdə dövr dayansın və nəticəni göstər.
    internal class Program
    {
        static void Main(string[] args)
        {
            Topla();
        }
        static void Topla()
        {
            int cem = 0;
            int h = 1;
            while (h == 1)
            {
                int eded = int.Parse(Console.ReadLine());
                if (eded < 0)
                {
                    h = 0; 
                }
                else
                {
                    cem =cem+ eded;
                }
            }
            Console.WriteLine(cem);
        }
    }
}
*/




