using System;
namespace Uppgift_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du ?");
            int ålder=int.Parse(Console.ReadLine());

            if(ålder > 16 && ålder <=19)
            {
                Console.WriteLine("du får delta i tävligen");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("du får inte delta");
                Console.ReadKey();
            }
        }
    }
}
  
     



    