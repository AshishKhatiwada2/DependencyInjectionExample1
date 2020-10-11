using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionExample
{
    class UseClassAB
    {
        Interface1 _interface1;
        public UseClassAB(Interface1 interface1)
        {
            _interface1 = interface1;
        }

        public void ExecuteMethod1()
        {
            _interface1.Method1();
        }
        public void ExecuteMethod2()
        {
            _interface1.Method2();
        }
    }
}
