﻿using System;

namespace _06._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfiteracion = int.Parse(Console.ReadLine());
            int openCount = 0;
            int closeCount = 0;

            for (int i = 1; i <=numberOfiteracion; i++)
            {

                string input = (Console.ReadLine());

                if (input == "(")
                {
                    openCount++;
                }
                else if(input==")")
                {
                    closeCount++;
                    if (openCount - closeCount != 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }

            }
            if (openCount == closeCount)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
