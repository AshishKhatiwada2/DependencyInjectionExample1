using System;

namespace DependencyInjectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ClassA classA = new ClassA();
            ClassB classB = new ClassB();
            UseClassAB useClassAB = new UseClassAB(classA);
            useClassAB.ExecuteMethod1();
            useClassAB.ExecuteMethod2();
            UseClassAB useClassAB1 = new UseClassAB(classB);
            useClassAB1.ExecuteMethod1();
            useClassAB1.ExecuteMethod2();
            Console.ReadLine();
        }
    }
}
