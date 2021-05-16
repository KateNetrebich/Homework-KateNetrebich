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
                Console.WriteLine("4.Articles");
                Console.WriteLine("5.Count");
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
                        Count(data);
                        break;
                    case "6":
                        return;
                }
            }
        }

        public static void AllNames(List<object> data)
        {
            var sorted = data.Where(n => n is Film).Cast<Film>().ToList();
            foreach (var film in sorted)
            {
                foreach (var actor in film.Actors)
                {
                    Console.WriteLine(actor.Name);
                }
            }
        }

        public static void ActorsBirthday(List<object> data)
        {
            var names = new List<string>();
            var sorted = data.Where(b => b is Film).Cast<Film>().ToList();
            foreach (var film in sorted)
            {
                foreach (var actor in film.Actors)
                {
                    if (actor.Birthdate.Month == 8)
                    {
                        if (!names.Contains(actor.Name))
                        {
                            names.Add(actor.Name);
                        }

                    }
                }
            }
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        public static void Articles(List<object> data)
        {
            var found = data.Where(a => a is Article).Cast<Article>().GroupBy(a => a.Author)
                .Select(group => Tuple.Create(group.Key, group.Count()));
            foreach (var objects in found)
            {
                var author = objects.Item1;
                var count = objects.Item2;
                Console.WriteLine($"{author} - {count}");
            }
        }

        public static void Count(List<object> data)
        {
            var found = data.Where(a => a is ArtObject).Cast<ArtObject>()
                .GroupBy(a=> a.GetType())
                .Select(byType => Tuple.Create(
                    byType.Key,
                    byType.GroupBy(a=>a.Author)
                        .Select(byAuthor=>Tuple.Create(byAuthor.Key, byAuthor.Count()))));
            foreach (var byType in found)
            {
                var type = byType.Item1;
                var authorsByType = byType.Item2;
            }
        }

        public static void FilmsAndArticle(List<object> data)
        {
            var found = data.Where(a => a is ArtObject).Cast<ArtObject>().GroupBy(a => a.Author)
                .Select(group => Tuple.Create(group.Key, group.Count()));
            foreach (var byType in found)
            {
                var type = byType.Item1;
                var authorsByType = byType.Item2;
                Console.WriteLine($"{type} - {authorsByType}");

            }
        }

        public static void ActorFilms(List<object> data)
        {
            var found = data.Where(d => d is Film).Cast<Film>().GroupBy(a=>a.Actors).Select(group => Tuple.Create(group.Key, group.GroupBy(a=>a.Name)));
            foreach (var films in found)
            {
                var film = films.Item1;
                var actor = films.Item2;
                Console.WriteLine($"{actor}-{film}");
            }
        }
    }
}
