using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            
            
            int[,] num = new int[3, 3];
            
            
            num[0, 0] = int.Parse(Console.ReadLine());
            
            num[0, 1] = int.Parse(Console.ReadLine());
            
            num[0, 2] = int.Parse(Console.ReadLine());
            
            num[1, 0] = int.Parse(Console.ReadLine());
            
            num[1, 1] = int.Parse(Console.ReadLine());
            
            num[1, 2] = int.Parse(Console.ReadLine());
            
            num[2, 0] = int.Parse(Console.ReadLine());
            
            num[2, 1] = int.Parse(Console.ReadLine());
            
            num[2, 2] = int.Parse(Console.ReadLine());
            
            
            int a = int.Parse(Console.ReadLine());
            
            Console.WriteLine("");
            
            
            for (i = 0; i < 3; i++)
                
            {
                for (j = 0; j < 3; j++)
                    
                {
                    Console.Write(num[i, j]);
                    
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }
    }
}
