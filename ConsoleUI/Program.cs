using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\ADMIN\Desktop\Train C#\ConsoleUI\ConsoleUI\data.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();
            List<Info> people = new List<Info>();
            
            foreach(var line in lines)
            {
                string[] entries = line.Split(',');

                Info newPeople = new Info();

                newPeople.Name = entries[0];
                newPeople.Age = entries[1];
                newPeople.Number = entries[2];

                people.Add(newPeople);
            }

            foreach(var person in people)
            {
                Console.WriteLine($"{person.Name} {person.Age} {person.Number}");
            }


            people.Add(new Info { Name = "Hoang Thuy Thi", Age = "24", Number = "0214732539" });
                        
            List<string> output = new List<string>();
            foreach(var person in people)
            {
                output.Add($"{person.Name} {person.Age} {person.Number}");
            }
            File.WriteAllLines(filePath, output);
            Console.ReadLine();
        }
    }
}
