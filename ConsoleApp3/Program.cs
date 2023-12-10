using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Console.Write("Baklava dilimi büyüklüğünü giriniz : ");
            int sayı = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= sayı; i++)//üst kısmı
            {
                for (int j = sayı; j > i; j--) //bosluk
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++) //yıldız
                {
                    Console.Write(" " + "*");
                }
                Console.WriteLine();
            }
            for (int t = 1; t <= sayı; t++) // alt kısmı
            {
                for (int m = 1; m <= t; m++) //bosluk
                {
                    Console.Write(" ");
                }
                for (int n = sayı; n > t; n--) //yıldız
                {
                    Console.Write(" " + "*");
                }

               
                
                Console.WriteLine();
            }

            Console.ReadLine();
        }
        
    }
}
