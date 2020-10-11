using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionExample
{
    class ClassA : Interface1
    {
        public void Method1()
        {
            Console.WriteLine("Hi from ClassA Method1");
        }

        public void Method2()
        {
            Console.WriteLine("Hi from Classa Method2");
        }
    }
}
