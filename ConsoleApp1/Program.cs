using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var total = int.Parse(Console.ReadLine());
            for (int a0 = 0; a0 < total; a0++)
            {
                var tokens_n = Console.ReadLine().Split(' ');
                var cancellationThreshold = int.Parse(tokens_n[1]);
                var a_temp = Console.ReadLine().Split(' ');
                var studentEntryTimings = Array.ConvertAll(a_temp, Int32.Parse);
                var onTimeStudents = 0;
                foreach (var studentTiming in studentEntryTimings)
                {
                    if (studentTiming <= 0)
                        onTimeStudents++;

                    if (onTimeStudents == cancellationThreshold)
                        break;
                }

                if (onTimeStudents < cancellationThreshold)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");

            }
        }
    }
}
