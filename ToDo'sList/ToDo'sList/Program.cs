﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_sList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the To Do List Program!");
            List<string> tasklist = new List<string>();
            string option = "";
            while (option != "e")
            {
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("Enter 1 to add a task to the list.");
                Console.WriteLine("Enter 2 to remove a task from the list.");
                Console.WriteLine("Enter 3 to view the list.");
                Console.WriteLine("Enter e to exit the program.\n");

                option = Console.ReadLine();
                if (option == "1") // Add item
                {
                    Console.WriteLine("Please enter the name of the task to add to the list.");
                    string task = Console.ReadLine();
                    tasklist.Add(task);
                    Console.WriteLine("Task added to list.");
                }
                else if (option == "2") // Remove item
                {
                    for (int i = 0; i < tasklist.Count; i++)
                    {
                        Console.WriteLine(i + " : " + tasklist[i]);
                    }

                    Console.WriteLine("Please enter the number of the task to remove.");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    tasklist.RemoveAt(taskNumber);
                }
                else if (option == "3") // View list
                {
                    Console.WriteLine("The tasks in the to do list : ");

                    for (int i = 0; i < tasklist.Count; i++)
                    {
                        Console.WriteLine(tasklist[i]);
                    }
                }
                else if (option == "e") // Exit
                {
                    Console.WriteLine("Exiting program.");
                }
                else // Incorrect input
                {
                    Console.WriteLine("Invalid option, please try again.");
                }
            }
            Console.WriteLine("Thank you for using the To Do List program.");
            Console.ReadLine();
        }
    }
}
