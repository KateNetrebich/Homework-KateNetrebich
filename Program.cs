using System;
using System.Linq;
using System.Threading;

namespace Threadings
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            decimal[] array = new decimal[10];
            Thread randomArray = new Thread(()=>
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(1,10);
                }
                foreach (var a in array)
                {
                    Console.Write(a);
                }
                Console.WriteLine("\n");
            });

            Thread arrayPart = new Thread(() => 
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(1, 10);
                }
                decimal[] arr = new decimal[array.Length/2];
                arr = array;
                foreach (var a in arr)
                {
                    Console.Write(a);
                }
                Console.WriteLine("\n");
            });

            Thread arrayMin = new Thread(()=> 
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(1, 10);
                }
                Console.Write($"{array.Min()}\n");
            });

            Thread arrayAvarage = new Thread(()=> 
            {
                decimal sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(1, 10);
                    sum += array[i];
                }
                Console.Write($"{sum/array.Length}\n");
            });

            randomArray.Start();
            arrayPart.Start();
            arrayMin.Start();
            arrayAvarage.Start();

            randomArray.Join();
            arrayPart.Join();
            arrayMin.Join();
            arrayAvarage.Join();
        }
    }
}
