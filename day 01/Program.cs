﻿using System;

namespace day_01
{
    class Program
    {
        static void Main(string[] args)
        {
           
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                    Console.WriteLine(i);

                }
            }
        }
    }
}
