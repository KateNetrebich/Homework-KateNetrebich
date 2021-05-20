using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var customers = new List<Customer>
            {
                new Customer(1, "Tawana Shope", new DateTime(2017, 7, 15), 15.8),
                new Customer(2, "Danny Wemple", new DateTime(2016, 2, 3), 88.54),
                new Customer(3, "Margert Journey", new DateTime(2017, 11, 19), 0.5),
                new Customer(4, "Tyler Gonzalez", new DateTime(2017, 5, 14), 184.65),
                new Customer(5, "Melissa Demaio", new DateTime(2016, 9, 24), 241.33),
                new Customer(6, "Cornelius Clemens", new DateTime(2016, 4, 2), 99.4),
                new Customer(7, "Silvia Stefano", new DateTime(2017, 7, 15), 40),
                new Customer(8, "Margrett Yocum", new DateTime(2017, 12, 7), 62.2),
                new Customer(9, "Clifford Schauer", new DateTime(2017, 6, 29), 89.47),
                new Customer(10, "Norris Ringdahl", new DateTime(2017, 1, 30), 13.22),
                new Customer(11, "Delora Brownfield", new DateTime(2011, 10, 11), 0),
                new Customer(12, "Sparkle Vanzile", new DateTime(2017, 7, 15), 12.76),
                new Customer(13, "Lucina Engh", new DateTime(2017, 3, 8), 19.7),
                new Customer(14, "Myrna Suther", new DateTime(2017, 8, 31), 13.9),
                new Customer(15, "Fidel Querry", new DateTime(2016, 5, 17), 77.88),
                new Customer(16, "Adelle Elfrink", new DateTime(2017, 11, 6), 183.16),
                new Customer(17, "Valentine Liverman", new DateTime(2017, 1, 18), 13.6),
                new Customer(18, "Ivory Castile", new DateTime(2016, 4, 21), 36.8),
                new Customer(19, "Florencio Messenger", new DateTime(2017, 10, 2), 36.8),
                new Customer(20, "Anna Ledesma", new DateTime(2017, 12, 29), 0.8)
            };

            while (true)
            {
                Console.WriteLine("Выберите действие");
                Console.WriteLine("1.Поиск первого кто зарегистрировался");
                Console.WriteLine("2.Среднее арифметическое баланса");
                Console.WriteLine("3.Сортировка по дате регистрации");
                Console.WriteLine("4.Групировка по месяцу и сортировка по алфавиту");
                Console.WriteLine("5.Фильтр по ID");
                Console.WriteLine("6.Вывод всех через запятую"); 
                Console.WriteLine("7.Сортировка во возрастанию и убыванию");
                Console.WriteLine("8.Exit");


                var action = Console.ReadLine();
                switch (action)
                {

                    case "1":
                        FirstCustomer(customers);
                        break;
                    case "2":
                        Avarage(customers);
                        break;
                    case "3":
                        var x = new DateTime(2017, 1, 1);
                        var y = new DateTime(2017, 12, 31);
                        Sort(x, y, customers);
                        break;
                    case "4":
                        var month = new DateTime(3);
                        SortByMonth(month, customers);
                        break;
                    case "5":
                        int number = 6;
                        FilterById(number, customers);
                        break;
                    case "6":
                        SortAscDesc(customers);
                        break;
                    case "7":
                        AllCustomers(customers);
                        break;
                    case "8":
                        return;
                }
            }


            var input = Console.ReadLine();
            var selectByName = (from c in customers where c.Name.StartsWith(input) select c).ToList();
            Console.WriteLine(selectByName);
        }

        public static void FirstCustomer(List<Customer> customers)
        {
            var firstCustomer = customers.OrderByDescending(x => x.RegistrationDate).FirstOrDefault();
            Console.WriteLine($"{firstCustomer.Id},{firstCustomer.Name},{firstCustomer.RegistrationDate}");
        }

        public static void Avarage(List<Customer> customers)
        {
            var sum = customers.Average(c => c.Balance);
            Console.WriteLine(sum);
        }

        public static void Sort(DateTime firstDate, DateTime secondDate, List<Customer> customers)
        {
            var sort = customers.Where(c => c.RegistrationDate > firstDate && c.RegistrationDate < secondDate).ToList();
            if (!sort.Any())
            {
                Console.WriteLine("No results");
            }
            else
            {
                foreach (var found in sort)
                {
                    Console.WriteLine($"{found.Id},{found.Name},{found.RegistrationDate}");
                }
            }
        }

        public static void SortByMonth(DateTime month, List<Customer> customers)
        {
            var sort = customers.Where(c => c.RegistrationDate == month).OrderBy(c => c.Name).ToList();
            foreach (var sorted in sort)
            {
                Console.WriteLine(sorted);
            }
        }

        public static void FilterById(int id, List<Customer> customers)
        {
            var filterById = customers.Select(i => i.Id == id).ToList();
            foreach (var found in filterById)
            {
                Console.WriteLine(found);
            }
        }
        
        public static void SortAscDesc(List<Customer> customers)
        {
            Console.WriteLine("Choose how you want to sort Asc or Desc");
            var chose = Console.ReadLine();
            if(chose == "Asc")
            {
                Console.WriteLine("Choose Name, Id, Date or Balance");
                var input = Console.ReadLine();
                if(input=="Name")
                {
                    var name = customers.OrderBy(c => c.Name).ToList();
                    Console.WriteLine(name);
                }
                else if(input == "Id")
                {
                    var id = customers.OrderBy(c => c.Id).ToList();
                    Console.WriteLine(id);
                }
                else if(input == "Date")
                {
                    var date = customers.OrderBy(c => c.RegistrationDate).ToList();
                    Console.WriteLine(date);
                }
                else if (input == "Balance")
                {
                    var balance = customers.OrderBy(c => c.Balance).ToList();
                    Console.WriteLine(balance);
                }
            }
            else if (chose == "Desc")
            {
                Console.WriteLine("Choose Name, Id, Date or Balance");
                var input = Console.ReadLine();
                if (input == "Name")
                {
                    var name = customers.OrderBy(c => c.Name).ToList();
                    Console.WriteLine(name);
                }
                else if (input == "Id")
                {
                    var id = customers.OrderByDescending(c => c.Id).ToList();
                    Console.WriteLine(id);
                }
                else if (input == "Date")
                {
                    var date = customers.OrderByDescending(c => c.RegistrationDate).ToList();
                    Console.WriteLine(date);
                }
                else if (input == "Balance")
                {
                    var balance = customers.OrderByDescending(c => c.Balance).ToList();
                    Console.WriteLine(balance);
                }
            }
        }
          
        public static void AllCustomers(List<Customer> customers)
        {
            Console.WriteLine(customers + ",");
        }
    }
}
