using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace taskmanager
{
    class TaskManager : IManager
    {
        public void FindTask(string s)
        {
            var task_list = Process.GetProcesses();
            for (int i = 0; i < task_list.Length; i++)
            {
                if (task_list[i].ProcessName.ToLower().IndexOf(s.ToLower()) >= 0)
                {
                    Console.WriteLine(task_list[i].ProcessName);
                } 
            }
        }

        public void KillTaskByID(int ID)
        {
            var task_list = Process.GetProcesses();
            for (int i = 0; i < task_list.Length; i++)
            {
                if (task_list[i].Id == ID)
                {
                    task_list[i].Kill();
                    break;
                }
            }
        }

        public void KillTaskByName(string Name)
        {
            var task_list = Process.GetProcesses();
            for (int i = 0; i < task_list.Length; i++)
            {
                if (task_list[i].ProcessName == Name)
                {
                    task_list[i].Kill();
                }
            }
        }

        public void PrintAllTasks()
        {
            var task_list = Process.GetProcesses();
            for (int i = 0; i < task_list.Length; i++)
            {
                Console.WriteLine($"{task_list[i].Id, 7} {task_list[i].ProcessName}");
            }
        }
    }
}
