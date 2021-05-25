using System;
using System.Collections.Generic;
using System.Linq;

namespace CSVFile
{
    public class CSVConvert
    {
        public CSVConvert(List<Person> person)
        {
            People = person;
        }
        public List<Person> People { get; set; }

        public string Export()
        {
            Console.WriteLine("Input properties to export");
            string input = Console.ReadLine();
            string[] inputDivided = input.Split(',');
            string csvFile = string.Empty;
            var propertiesNames = typeof(Person).GetProperties()
                .Select(x=>x.ToString()
                .Split(' ')[1]).ToList();

            for (int i = 0; i < propertiesNames.Count; i++)
            {
                csvFile += propertiesNames[i] + ";";
            }
            csvFile = csvFile.Remove(csvFile.Length - 1, 1) + '\n';
            for (int i = 0; i < People.Count; i++)
            {
                for (int n = 0; n < inputDivided.Length; n++)
                {
                    if (propertiesNames.Contains(inputDivided[n]))
                    {
                        csvFile += People[i].GetType().GetProperty(inputDivided[n]).GetValue(People[i], null) + ";";
                    }
                    else
                    {
                        csvFile += ";";
                    }
                }
                csvFile = csvFile.Remove(csvFile.Length - 1, 1) + '\n';
            }
            csvFile = csvFile.Remove(csvFile.Length - 1, 1);
            return csvFile; 
        }

    }
}
