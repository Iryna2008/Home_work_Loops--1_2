using System;

namespace Home_work_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // № 1 (прямоугольник)
            Console.WriteLine("Enter a columns count");

            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a rows count");

            int b = int.Parse(Console.ReadLine());

            int y = 0;

            while (y < b)
            {

                int x = 0;

                while (x < a)
                {
                    Console.Write("*");
                    x++;
                }

                y++;

                Console.WriteLine();

            }
            // № 2 (треугольник)
            //*
            //**
            //***
            Console.WriteLine("Enter rows count");

            int c = int.Parse(Console.ReadLine());

            for (int d = 0; d < c; d++)
            {

                for (int f = 0; f <= d; f++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
