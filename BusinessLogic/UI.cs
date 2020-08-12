using System;
using System.Threading.Tasks;
using static System.Console;
using System.Linq;

namespace Scheduler
{
    public class UI
    {
        public async Task Welcome()
        {
            while (true)
            {
                Clear();
                WriteLine("###########\n" +
                          "# Welcome #\n" +
                          "###########");
                WriteLine("1.\tEnter Students");
                WriteLine("2.\tEnter Teachers");
                WriteLine("3.\tEnter Equipements");
                WriteLine("4.\tEnter Modules");
                WriteLine("5.\tEnter Branches");
                WriteLine("6.\tVisualize");
                WriteLine("Q.\tExit");

                switch (ReadLine())
                {
                    case "1": await EnterStudent(); break;
                    case "6": Visualize(); break;
                    case "Q": Clear(); Environment.Exit(0); break;
                    default: break;
                }
            }
        }

        public void Visualize()
        {
            using SchedulerContext DB = new SchedulerContext();

            WriteLine("Studetns...");
            foreach (Student std in DB.Students.ToList())
                WriteLine($"\t{std.FirstName.PadRight(30 - std.FirstName.Length)}\t{std.LastName.PadRight(30 - std.LastName.Length)}");


            Write("Press Enter to continue..."); ReadLine();
        }

        public async Task EnterStudent()
        {
            using SchedulerContext db = new SchedulerContext();
            Student student = new Student();

            Write("How many would you like to enter?\t");
            int count = int.Parse(ReadLine());
            while (count > 0)
            {
                Clear();
                WriteLine($"Student number {count}");
                Write("First Name:\t"); student.FirstName = ReadLine();
                Write("Last Name:\t"); student.LastName = ReadLine();
                db.Students.Add(student);
                await db.SaveChangesAsync();
                count--;
            }
        }

    }
}