using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqHomeworkPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new List<object>
            {
                "Hello",
                new Article { Author = "Hilgendorf", Name = "Punitive law and criminal law doctrine.", Pages = 44 },
                new List<int> {45, 9, 8, 3},
                new string[] {"Hello inside array"},
                new Film { Author = "Martin Scorsese", Name= "The Departed", Actors = new List<Actor>() {
                    new Actor { Name = "Jack Nickolson", Birthdate = new DateTime(1937, 4, 22)},
                    new Actor { Name = "Leonardo DiCaprio", Birthdate = new DateTime(1974, 11, 11)},
                    new Actor { Name = "Matt Damon", Birthdate = new DateTime(1970, 8, 10)}
                }},
                new Film { Author = "Gus Van Sant", Name = "Good Will Hunting", Actors = new List<Actor>() {
                    new Actor { Name = "Matt Damon", Birthdate = new DateTime(1970, 8, 10)},
                    new Actor { Name = "Robin Williams", Birthdate = new DateTime(1951, 8, 11)},
                }},
                new Article { Author = "Basov", Name="Classification and content of restrictive administrative measures applied in the case of emergency", Pages = 35},
                "Leonardo DiCaprio"
            };

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Choose action");
                Console.WriteLine("1.All actors names");
                Console.WriteLine("2.Actor birthday");
                Console.WriteLine("3.Articles");
                Console.WriteLine("4.Count");
                Console.WriteLine("5.Actors Films");
                Console.WriteLine("6.Exit");
                Console.WriteLine();

                var action = Console.ReadLine();
                switch (action)
                {
                    case "1":
                        AllNames(data);
                        break;
                    case "2":
                        ActorsBirthday(data);
                        break;
                    case "3":
                        Articles(data);
                        break;
                    case "4":
                        FilmsAndArticle(data);
                        break;
                    case "5":
                        ActorFilms(data);
                        break;
                    case "6":
                        return;
                }
            }
        }

        public static void AllNames(List<object> data)
        {
            Console.Clear();
            var sorted = data.OfType<Film>().ToList();
            sorted.SelectMany(x => x.Actors)
                .Select(x => x.Name).Distinct()
                .ToList().ForEach(x => Console.WriteLine(x));
        }

        public static void ActorsBirthday(List<object> data)
        {
            Console.Clear();
            var sorted = data.OfType<Film>().ToList();
            sorted.SelectMany(x => x.Actors)
                .Where(x => x.Birthdate.Month == 8)
                .Select(x => x.Name).ToList()
                .ForEach(x => Console.WriteLine(x));
        }

        public static void Articles(List<object> data)
        {
            Console.Clear();
            data.OfType<Article>().GroupBy(a => a.Author)
                .Select(group => Tuple.Create(group.Key, group.Count()))
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.Item1} - {x.Item2}"));
        }

        public static void FilmsAndArticle(List<object> data)
        {
            data.OfType<ArtObject>()
                .GroupBy(a => a.Author)
                .Select(group => Tuple.Create(group.Key, group.Count()))
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.Item1} - {x.Item2}"));
        }

        public static void ActorFilms(List<object> data)
        {
            data.OfType<Film>()
                .GroupBy(a => a.Actors)
                .Select(group => Tuple.Create(group.Key, group.GroupBy(a => a.Name)))
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.Item1}-{x.Item2}"));
        }
    } 
}


