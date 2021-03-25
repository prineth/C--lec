using System;

namespace Lecture_07
{
    class Program
    {
        static void Main(string[] args)
        {
            GetNumbers obj = new GetNumbers();
            Summation objSum = new Summation();
            Multiplication objMulti = new Multiplication();
            Substraction objSub = new Substraction();
            Division objDiv = new Division();

            //obj.getFromUser();
    
            Console.WriteLine("Summation = " + objSum.sumMethod());
            Console.WriteLine("___________________________________________________________");
            Console.WriteLine("Substraction = " + objSub.subMethod());
            Console.WriteLine("___________________________________________________________");
            Console.WriteLine("Multiplication = " + objMulti.multiMethod());
            Console.WriteLine("___________________________________________________________");
            Console.WriteLine("Division = " + objDiv.divMethod());
            Console.WriteLine("___________________________________________________________");



            Console.ReadKey();
        }
    }
}
