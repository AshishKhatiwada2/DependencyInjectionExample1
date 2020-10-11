using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionExample
{
    class ClassB : Interface1
    {
        public void Method1()
        {
            Console.WriteLine("Hi from ClassB Method1");
        }

        public void Method2()
        {
            Console.WriteLine("Hi from ClassB Method2");
        }

    }
}
