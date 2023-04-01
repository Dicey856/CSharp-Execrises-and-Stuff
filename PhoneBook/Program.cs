using System;
using System.Collections.Generic;

namespace PhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the phone book!");
            Console.WriteLine("Type - A; In order to add a person and their contact information.");
            Console.WriteLine("Type - S; In order to search for a person.");
            Console.WriteLine("Type - E; In order to exit the app.");
            Dictionary<string, int> phonebook = new Dictionary<string, int>();

            while (true) {
                
                string input = Console.ReadLine();
                if (input == "A")
                {
                    Console.WriteLine("Please enter the name of the person: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Please enter the number of the person: ");
                    int number = int.Parse(Console.ReadLine());
                    if(!phonebook.ContainsKey(name)) 
                    {
                         phonebook.Add(name, number);
                         Console.WriteLine("Person has been added successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Person is already in the phonebook!");
                    }

                } 
                else if (input == "S")
                {
                    
                    Console.WriteLine("Please enter the name of the person you are looking for: ");
                    string searchname = Console.ReadLine();
                    if (phonebook.ContainsKey(searchname))
                    {
                        Console.WriteLine("Here is the information about the person you are looking for: ");
                        Console.WriteLine($"{searchname} -> {phonebook[searchname]}");
                    }
                    else
                    {
                        Console.WriteLine($"There isnt any record of {searchname} in the phonebook!");
                    }

                    
                } 
                else if (input == "E")
                {
                    break;
                } 
                else
                {
                    Console.WriteLine("Invalid input!");
                }





            }

        }
    }
}
