using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumaraOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                NumberGame();

            }
            catch (Exception)
            {

                NumberGame();
            }


            Console.ReadLine();
        }
        static void NumberGame()
        {
            // Random metotunu 1 kere kullanabiliriz.
            // Random rnd = new Random();
            // int number = rnd.Next(1,101);
            int number = new Random().Next(1, 101);  // Bu şekilde kullanılabilir.Tek satırda işlemi tamamlamış olduk.

            int kalanHak = 10;

            Console.Write("Tahmininizi Giriniz: ");
            int userNumber = int.Parse(Console.ReadLine());

            while (userNumber != number)
            {
                if (Math.Abs(number - userNumber) < 5)
                {
                    Console.WriteLine("SICAK");
                }
                else
                {
                    Console.WriteLine("SOĞUK");
                }

                userNumber = int.Parse(Console.ReadLine());

                kalanHak--;

                if (kalanHak == 0)
                {
                    Console.WriteLine("Hakkınız Bitti. Rakam :" + number);
                    break;
                }
            }

            if (userNumber == number)
            {
                Console.WriteLine("TEBRİKLER. KAZANDINIZ.");
            }

        }
    }
}
