using System;
using System.Text;
using DI.App.Abstractions;
using DI.App.Abstractions.BLL;

namespace DI.App.Services.PL
{
    public class CommandManager
    {
        private readonly ICommandProcessor processor;

        public CommandManager()
        {
            var inMemoryDb = new InMemoryDatabaseService<IUser>();
            var repository = new UserStore(inMemoryDb);
            this.processor = new CommandProcessor(repository);
        }

        public void Start()
        {
            var info = this.BuildInfo();

            while (true)
            {
                Console.Clear();
                Console.WriteLine(info);

                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input)
                    ||
                    !int.TryParse(input, out var command))
                {
                    continue;
                }

                this.processor.Process(command);

                Console.WriteLine("RETURN to continue...");
                Console.ReadLine();
            }
        }

        private string BuildInfo()
        {
            var sb = new StringBuilder();
            var commands = this.processor.Commands;

            sb.AppendLine("Select operation:");

            foreach (var command in commands)
            {
                sb.AppendLine($"{command.Number}. {command.DisplayName}");
            }

            return sb.ToString();
        }
    }
}