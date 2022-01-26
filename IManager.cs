using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskmanager
{
    interface IManager
    {
        void PrintAllTasks();
        void KillTaskByName(string Name);
        void KillTaskByID(int ID);
        void FindTask(string s);

    }
}
