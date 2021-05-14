using System;
using System.Linq;
using System.Text;

namespace PracticeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose action");
                Console.WriteLine("1.Print numbers in string");
                Console.WriteLine("2.Number with two numbers after comma");
                Console.WriteLine("3.Exponential Form");
                Console.WriteLine("4.DateTime Format");
                Console.WriteLine("5.Convert string to DateTime");
                Console.WriteLine("6.Sum");
                Console.WriteLine("10.Exit");
       
                var action = Console.ReadLine();
                switch(action)
                {
                    case "1":
                        NumbersInString();
                        break;
                    case "2":
                        Division();
                        break;
                    case "3":
                        ExponentialForm();
                        break;
                    case "4":
                        DateTimeConvert();
                        break;
                    case "5":
                        ConvertStringToDateTime();
                        break;
                    case "6":
                        Count();
                        break;
                    case "10":
                        return;
                }
            }
        }

        public static void NumbersInString()
        {
            Console.WriteLine("Input string");
            var action = Console.ReadLine();
            StringBuilder onlyNumbers = new StringBuilder();
            int result;
            foreach (var symbol in action)
            {
                if(char.IsDigit(symbol))
                {
                    onlyNumbers.Append(symbol);
                }
            }
            result = Convert.ToInt32(onlyNumbers.ToString());
            Console.WriteLine($"Numbers in string: {result}");
        }

        public static void Division()
        {
            int first = 15;
            int second = 4;
            double division = first/second;
            var divisionResult = Math.Round(division, 2);
            Console.WriteLine($"Devision result = {divisionResult}");
        }

        public static void ExponentialForm()
        {
            Console.WriteLine("Input number");
            var number = Console.ReadLine();
            var expForm = number;
            Console.WriteLine($"{0:E}", expForm);
        }

        public static void DateTimeConvert()
        {
            DateTime dateTime = new DateTime(2021, 5, 14);
            Console.WriteLine($"ISO-8601 Format: {dateTime.ToString("yyyy-MM-ddTHH:mm:ssK")}");
        }

        public static void ConvertStringToDateTime()
        {
            string date = "21.07.2016";
            var dateTime = DateTime.Parse(date);
            Console.WriteLine($"Converted string: {dateTime}");
        }

        public static void Count()
        {
            string numbers = "1,2,3,4,5,6,7";
            var numbersStringArray = numbers.Split(",");
            var numbersIntArray = new int[numbersStringArray.Length];
            for (int i = 0; i < numbersStringArray.Length; i++)
            {
                numbersIntArray[i] = Convert.ToInt32(numbersStringArray[i]);
            }
            int sum = 0;
            Array.ForEach(numbersIntArray, delegate (int i) { sum += i; });
            Console.WriteLine(sum);

        }
    }
}
