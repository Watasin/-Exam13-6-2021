using System;

namespace Exam03
{
    class Program
    {
        static void Main(string[] args)
        {
            float Max = 0;
            float Min = 0;
            float Mean = 0;
            float n = 0;
            string A;
            string finding;

            A = Console.ReadLine();
            if (A != "End")
            {
                Max = float.Parse(A);
                Min = float.Parse(A);
                Mean += float.Parse(A);
            }
            while (A != "End")
            {
                A = Console.ReadLine();
                if (A != "End")
                {
                    if (float.Parse(A) > Max)
                    {
                        Max = float.Parse(A);
                    }
                    if (float.Parse(A) < Min)
                    {
                        Min = float.Parse(A);
                    }
                    Mean += float.Parse(A);
                    n++;
                }
            }
            finding = Console.ReadLine();
            while (finding != "FindMax " || finding != " FindMin " || finding != "FindMean")
            {
                if (finding == "FindMax")
                {
                    Console.Write(Max);
                }
                else
                if (finding == "FindMin")
                {
                    Console.Write(Min);
                }
                else
                if (finding == "FindMean")
                {
                    Console.Write(Mean / n);
                }
                else
                {
                    Console.Write("Invalid mode");
                }
                Console.ReadLine();
            }
        }
    }
}
