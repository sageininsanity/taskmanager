using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskmanager
{
    class CommandProcessor
    {
        public static void GetCommand()
        {
            Console.WriteLine("Enter your command (print HELP if there are problems)");
            string command = Console.ReadLine();
            string[] command_array = command.Split(' ');
            ProcessCommand(command_array);
        }
        public static void ProcessCommand(string[] Command) 
        {
            var obj = new TaskManager();
            string instruction = "Commands are CASE SENSITIVE\nKill <ID of process> - kills a process based on given ID\nKill <Name of process> - kills a process based on given name\nFind <String> - finds all processes with names including a given string\nPrint all processes - prints a full list of processes and IDs\nExit - exits the task manager";
            if (Command[0] == "HELP")
            {
                Console.WriteLine(instruction);
                GetCommand();
            }
            else if (Command[0] == "Kill")
            {
                try { obj.KillTaskByName(Command[1]); }
                catch { obj.KillTaskByID(Convert.ToInt32(Command[1])); }
                GetCommand();
            }
            else if (Command[0] == "Print")
            {
                obj.PrintAllTasks();
                GetCommand();
            }
            else if (Command[0] == "Exit")
            {
                Environment.Exit(0);
            } else if (Command[0] == "Find")
            {
                obj.FindTask(Command[1]);
                GetCommand();
            }
            else
            {
                Console.WriteLine("Unknown command, please reiterate.");
                GetCommand();
            }
        }
    }
}
