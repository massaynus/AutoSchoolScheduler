using System;
using System.Threading.Tasks;

namespace Scheduler
{
    class Program
    {
        static UI UI = new UI();
        static void Main(string[] args)
        {
            Task.Run(UI.Welcome).Wait();
        }
    }
}
