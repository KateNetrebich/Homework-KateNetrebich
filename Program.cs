using System;
using System.Collections.Generic;
using System.Linq;

namespace BullsAndCows
{
    public class Program
    {
        const int AnswerSize = 4;
        private static IEnumerable<string> Relocating(int size)
        {
            if (size > 0)
            {
                foreach (string s in Relocating(size - 1))
                {
                    foreach (char n in "0123456789")
                    {
                        if (!s.Contains(n))
                        {
                            yield return s + n;
                        }
                    }
                }
            }
            else
            {
                yield return "";
            }
        }

        private static IEnumerable<T> Mix<T>(IEnumerable<T> source)
        {
            var random = new Random();
            var list = source.ToList();
            while (list.Count > 0)
            {
                int rnd = random.Next(list.Count);
                yield return list[rnd];
                list.RemoveAt(rnd);
            }
        }

        private static bool BullsAndCows(out int bulls, out int cows)
        {
            string[] input = Console.ReadLine().Split(',').ToArray();
            bulls = cows = 0;
            if (input.Length < 2)
            {
                return false;
            }
            return int.TryParse(input[0], out bulls) && int.TryParse(input[1], out cows);
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Start game");
            Console.WriteLine("");
            List<string> answers = Mix(Relocating(AnswerSize)).ToList();
            while (answers.Count > 1)
            {
                string guess = answers[0];
                Console.Write($"My option is - {guess}\n");
                Console.WriteLine("How many bulls, cows in this option I guessed?");
                if (!BullsAndCows(out var bulls, out var cows))
                {
                    Console.WriteLine("I cant understand your answer, please try again");
                }
                else
                {
                    for (int ans = answers.Count - 1; ans >= 0; ans--)
                    {
                        int b = 0, c = 0;
                        for (int i = 0; i < AnswerSize; i++)
                        {
                            if (answers[ans][i] == guess[i])
                            {
                                b++;
                            }
                            else if (answers[ans].Contains(guess[i]))
                            {
                                c++;
                            }
                        }
                        if (b != bulls || c != cows)
                        {
                            answers.RemoveAt(ans);
                        }
                    }
                }
            }
            if (answers.Count == 1)
            {
                Console.WriteLine($"I guessed the answer is {answers[0]}!");
            }
            else
            {
                Console.WriteLine("It's too hard! I can't find the right option.");
            }
        }
    }
}