using System;

namespace _4_6_Lab_sean
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saterday", "Sunday"};
            string[] tasks =new string[7];

            for (int i = 0; i < days.Length; i++)

            {
                Console.WriteLine("What are you going to do on " + days[i]);
                tasks[i] = days[i] + ":" + Console.ReadLine();
            }
            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(tasks[i]);
            }
        }
    }
}
