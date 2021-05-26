using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace LINQHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose action");
                Console.WriteLine("1.Division");
                Console.WriteLine("2.Linq");
                Console.WriteLine("3.First");
                Console.WriteLine("4.Words with a");
                Console.WriteLine("5.Count a");
                Console.WriteLine("6.Find abb");
                Console.WriteLine("7.Long word");
                Console.WriteLine("8.Count string length");
                Console.WriteLine("9.Find Short");
                Console.WriteLine("10.Start with a");
                Console.WriteLine("12.Exit");
                Console.WriteLine();

                var action = Console.ReadLine();
                switch (action)
                {
                    case "1":
                        Division();
                        break;
                    case "2":
                        PrintLINQ();
                        break;
                    case "3":
                        First();
                        break;
                    case "4":
                        WordsWithA();
                        break;
                    case "5":
                        CountA();
                        break;
                    case "6":
                        FindAbb();
                        break;
                    case "7":
                        LongWord();
                        break;
                    case "8":
                        CountStringLength();
                        break;
                    case "9":
                        FindShort();
                        break;
                    case "10":
                        StartWithA();
                        break;
                    case "12":
                        return;
                }
            }
        }

        public static void Division()
        {
            Console.Clear();
            var number = Console.ReadLine();
            var result = number.Where(n => n >= 10 && n <= 50).Select(n => n % 3 == 0).ToString();
            Console.WriteLine(result);
        }

        public static void PrintLINQ()
        {
            Console.Clear();
            foreach (string linq in Enumerable.Repeat("Linq", 10).Select((l, i) => $"{i + 1}:{l}."))
            {
                Console.WriteLine(linq);
            }
        }

        public static void First()
        {
            Console.Clear();
            Console.WriteLine(string.Join(",", Enumerable.Range(10, 41)));
        }

        public static void WordsWithA()
        {
            Console.Clear();
            string str = "aaa,abb,ccc,dap,trwv,twfc,aqwd";
            string[] strArray = str.Split(',');
            str = string.Join(',', strArray.Where(n => n.Contains('a')));
            Console.WriteLine(str);
        }

        public static void CountA()
        {
            Console.Clear();
            string str = "aaa,abb,ccc,dap,trwv,twfc,aqwd";
            string[] strArray = str.Split(',');
            str = strArray
             .Select(n => n.ToCharArray().Count(x => x == 'a'))
             .ToList()
             .ConvertAll(x => x.ToString())
             .Aggregate((a, x) => a + "; " + x);
            Console.WriteLine(str);
        }

        public static void FindAbb()
        {
            Console.Clear();
            string str = "aaa,abb,ccc,dap";
            string[] strArray = str.Split(',');
            str = strArray.Any(a => a.StartsWith("abb")) ? "True" : "False";
            Console.WriteLine(str);

        }

        public static void LongWord()
        {
            Console.Clear();
            string str = "aaa,xabbx,abb,ccc,dap";
            string[] strArray = str.Split(',');
            str = strArray.OrderByDescending(s => s.Length).First();
            Console.WriteLine(str);
        }

        public static void CountStringLength()
        {
            Console.Clear();
            string str = "aaa,xabbx,abb,ccc,dap";
            string[] strArray = str.Split(',');
            str = strArray.Average(n => n.Length).ToString();
            Console.WriteLine(str);
        }

        public static void FindShort()
        {
            Console.Clear();
            string str = "aaa,xabbx,abb,ccc,dap,zh";
            string[] strArray = str.Split(',');
            str = new string(strArray.OrderBy(s => s.Length).First().Reverse().ToArray());
            Console.WriteLine(str);
        }

        public static void StartWithA()
        {
            Console.Clear();
            string str = "baaa,aabbfd,aabb,aaa,xabbx,abb,ccc,dap,zh";
            string[] strArray = str.Split(',');
            str = strArray.First(n => n.StartsWith("aa"));
            str = Regex.IsMatch(str, "^aab+$") ? "True" : "False";
            Console.WriteLine(str);
        }
    }
}
