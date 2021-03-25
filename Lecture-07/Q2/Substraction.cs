using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_07
{
    class Substraction : GetNumbers
    {
       
        public double subMethod()
        {
            getFromUser();

            return num1 - num2;
        }
    }
}
