using System.Collections.Generic;

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
            string csvFile = string.Empty;
            var uneditedNames = typeof(Person).GetProperties();
            string[] propertiesNames = new string[uneditedNames.Length];

            for (int i = 0; i < uneditedNames.Length; i++)
            {
                propertiesNames[i] = uneditedNames[i].ToString();
                propertiesNames[i] = propertiesNames[i].Split(' ')[1];
            }
            for (int i = 0; i < propertiesNames.Length; i++)
            {
                csvFile += propertiesNames[i] + ";";
            }
            csvFile = csvFile.Remove(csvFile.Length - 1, 1) + '\n';

            for (int i = 0; i < People.Count; i++)
            {
                csvFile += People[i].Age == 0
                    ? ";"
                    : People[i].Age + ";";
                csvFile += string.IsNullOrEmpty(People[i].EyeColor)
                    ? ";" 
                    : People[i].EyeColor + ";";
                csvFile += string.IsNullOrEmpty(People[i].Name) 
                    ?";" 
                    : People[i].Name + ";" ;
                csvFile += string.IsNullOrEmpty(People[i].Gender) 
                    ?";" 
                    : People[i].Gender + ";";
                csvFile += string.IsNullOrEmpty(People[i].Company) 
                    ?";" 
                    : People[i].Company + ";";
                csvFile += string.IsNullOrEmpty($"\"{ People[i].Address}\"")
                    ?";" 
                    : $"\"{ People[i].Address}\"" + ";";
                csvFile += People[i].Salary + "\n";
            }
            csvFile = csvFile.Remove(csvFile.Length - 1, 1);
            return csvFile; 
        }

    }
}
