using System;

namespace Exam_02
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Input size of array : ");
            int border = int.Parse(Console.ReadLine());
            int[] ar1 = new int[border];
            Console.WriteLine("This your size{0}", border);
            for (int i = 0; i < border; i++)
            {
                Console.Write("amount - {0} ", i);
                ar1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < border; i++)
            { 
                for(int j = i + 1; j < border; j++)
                   {
                   if (ar1[j] < ar1[i])
                   {
                        int tem = ar1[i];
                        ar1[i] = ar1[j];
                        ar1[j] = tem;

                    }
                }
            }
            Console.WriteLine("");
            for (int i = 0; i < border; i++)
            {
                Console.Write(ar1[i]);
                Console.Write(" ");
            }
            Console.WriteLine ("\n\n");

        }
    }
}
        
             
