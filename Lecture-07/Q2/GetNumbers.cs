using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_07
{
    class GetNumbers
    {
        public double num1;
        public double num2;

        public void getFromUser()
        { 
            Console.WriteLine("Enter number 01 : ");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter number 02 : ");
            num2 = double.Parse(Console.ReadLine());

        }
}
}
