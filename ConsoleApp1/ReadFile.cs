using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class ReadFile
    {

        public static void readFromFile()
        {
            string fileName = @"C:\Users\deadf\source\repos\ConsoleApp1\input.txt";
            string readText = File.ReadAllText(fileName);
            var serverData = JsonConvert.DeserializeObject<Person[]>(readText);

            foreach (var person in serverData)
            {
                try
                {
                    DateTime dateTime = DateTime.Parse(person.dateOfBirth);
                    var age = DateTime.Now.Year - dateTime.Year;

                    Console.WriteLine(
                        "Name: " + person.Name +
                        "\n Surname: " + person.Surname +
                        "\n Sex: " + person.Sex +
                        "\n Nationality: " + person.Nationality + 
                        "\n DateOfBirth: " + age
                        );
                }
                catch (FormatException)
                {
                    Console.WriteLine("Unable to parse the specified date");
                }

            }
        }
    }
}
