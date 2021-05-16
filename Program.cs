using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

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
                Console.WriteLine("7.Password");
                Console.WriteLine("8.Find text with numbers");
                Console.WriteLine("9.Phone");
                Console.WriteLine("10.Phone Convert");
                Console.WriteLine("11.Convert text");
                Console.WriteLine("12.Exit");
       
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
                    case "7":
                        Password();
                        break;
                    case "8":
                        FindText();
                        break;
                    case "9":
                        Phone();
                        break;
                    case "10":
                        ConvertPhoneNumber();
                        break;
                    case "11":
                        ConvertText();
                        break;
                    case "12":
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

        public static void Password()
        {
            Console.WriteLine("Введите пароль");
            var password = Console.ReadLine();
            Regex regex = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])[a-zA-Z0-9]{6,15}$");
            if (regex.IsMatch(password))
            {
                Console.WriteLine("Пароль успешно введен");
                return;
            }
            Console.WriteLine("Пароль должен содержать 6 символов, минимум одну прописную букву, заглавную букву, цифру");
        }

        public static void FindText()
        {
            Console.WriteLine("Input text");
            string text = Console.ReadLine();
            Regex regex = new Regex(@"[a-zA-Z]+[\d]+");
            if (regex.IsMatch(text))
            {
                foreach (var match in regex.Matches(text))
                {
                    Console.Write(match);
                }
                Console.WriteLine();
                return;
            }
            Console.Write("Нет совпадений");
        }

        public static void Phone()
        {
            Console.WriteLine("Input phone number");
            var phone = Console.ReadLine();
            Regex regex = new Regex(@"\+?\d{3}-\d{2}-\d{3}-\d{2}-\d{2}");
            if (regex.IsMatch(phone))
            {
                Console.WriteLine(phone);
                return;
            }
            Console.WriteLine("Вееденный номер телефона не соответствует шаблону");
        }

        public static void ConvertPhoneNumber()
        {
            Console.WriteLine("Input phone number");
            var phone = Console.ReadLine();
            Regex regex = new Regex(@"\+?\d{3}-\d{2}-\d{3}-\d{2}-\d{2}");
            if (regex.IsMatch(phone))
            {
                Console.WriteLine(regex.Replace(phone, "+XXX-XX-XXX-XX-XX"));
                return;
            }
            Console.WriteLine("Вееденный номер телефона не соответствует шаблону");
        }

        public static void ConvertText()
        {
            Console.WriteLine("Input text");
            string text = Console.ReadLine();
            byte[] bytes = Encoding.Default.GetBytes(text);
            text = Encoding.UTF8.GetString(bytes);
            Console.WriteLine(text);
        }
    }
}
