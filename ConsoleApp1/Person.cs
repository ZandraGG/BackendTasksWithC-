using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Person
    {

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Surname")]
        public string Surname { get; set; }

        [JsonProperty("Sex")]
        public string Sex { get; set; }

        [JsonProperty("Nationality")]
        public string Nationality { get; set; }

        [JsonProperty("dateOfBirth")]
        public string dateOfBirth { get; set; }
        public Person(string firstName, string lastName,  string sex, string nationaity, string birthDate)
        {
            Name = firstName;
            Surname = lastName;
            Sex = sex;
            Nationality = nationaity;
            dateOfBirth = birthDate;
        }
    }
}
