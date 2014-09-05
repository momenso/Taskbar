using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Taskbar
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Count() != 1)
            {
                Console.WriteLine("Usage: TaskBar <SHOW|HIDE>");
                return;
            }

            string option = args[0].ToUpper();
            switch (option)
            {
                case "HIDE":
                    Taskbar.Hide();
                    break;

                case "SHOW":
                    Taskbar.Show();
                    break;
            }
        }
    }
}
