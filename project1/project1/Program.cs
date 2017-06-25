using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            Console.WriteLine("Welcome to C# DBMS version 0.1.\n" + "Enter Command: " );
            while(exit != true)
            {
                string command = Console.ReadLine();
                commandParser parsey = new commandParser();
                parsey.parseCommand(command);
            }

        }
    }
}
