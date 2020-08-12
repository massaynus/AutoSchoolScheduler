using System;
using System.Threading.Tasks;

namespace Scheduler
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(new UI().Welcome).Wait();
        }
    }
}
