using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    /// <summary>
    /// The word polymorphism means having many forms. In object-oriented programming paradigm, 
    /// polymorphism is often expressed as 'one interface, multiple functions'.
    /// It allows you to invoke methods of derived class through base class reference during runtime.
    /// It has the ability for classes to provide different implementations of methods that are called through the same name.
    /// 
    /// Polymorphism can be static or dynamic. 
    /// In static polymorphism, the response to a function is determined at the compile time. (overloading)
    /// In dynamic polymorphism, it is decided at run-time.  (overriding)
    /// </summary>
    class Polymorphism
    {

        public class Overloading
        {
            public void Add(string a1, string a2)
            {
                Console.WriteLine("Adding Two String :" + a1 + a2);
            }

            public void Add(int a1, int a2)
            {
                Console.WriteLine("Adding Two Integer :" + (a1 + a2));
            }
        }

        public class Overriding
        {
            public class Base
            {
                public virtual void Show()
                {
                    Console.WriteLine("Show() From Base Class.");
                }
            }

            public class Derived : Base
            {
                public override void Show()
                {
                    Console.WriteLine("Show() From Derived Class.");
                }
            }

        }

    }
}
