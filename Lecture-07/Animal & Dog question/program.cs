using System;

namespace Lecture_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animalObj = new Animal();
            Dog dogObj = new Dog();

            animalObj.method01();
            dogObj.method02();

            Console.ReadKey();
        }
    }
}
