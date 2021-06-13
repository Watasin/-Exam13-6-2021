using System;

namespace Exam_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Many City : ");


            int Many_City = int.Parse(Console.ReadLine());


            int Level = 0;

            string text;
            for (int i = 0; i < Many_City; i++)
            {
                Level.ToString();


                Many_City City_loop;

                City_loop = (Many_City)i;

                Console.WriteLine("{0} = {1}", City_loop, Level);
            }
        }
    }
}
