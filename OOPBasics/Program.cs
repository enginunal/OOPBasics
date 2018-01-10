using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Encapsulation
            //Encapsulation is used to restrict access to the members of a class so as to prevent 
            //the user of a given class from manipulating objects in ways that are not intended by the designer.
            Encapsulation.Employee enc = new Encapsulation.Employee{ FirstName = "Engin", LastName = "My LastName" };
            Console.WriteLine(enc.FullName());

            //2.Abstraction
            //Abstraction involves the facility to define objects that represent abstract "actors" that 
            //can perform work, report on and change their state, and "communicate" with other objects in the system.
            Abstraction.Rectangle abs = new Abstraction.Rectangle { Width = 3, Height = 5 };
            Console.WriteLine(abs.CalculateArea());

            //3.Inheritance
            //Inheritance enables you to create new classes that reuse, extend, and modify the behavior that is 
            //defined in other classes. The class whose members are inherited is called the base class, 
            //and the class that inherits those members is called the derived class. 
            //A derived class can have only one direct base class.
            Inheritance.Triangle inh = new Inheritance.Triangle { Height = 18, Width = 40, Style = "Test" };
            inh.ShowArea();


            //4.Polymorphism
            //Allows you to invoke derived class methods through a base class reference during run-time.
            //They won’t necessarily have to be the same object type
            Polymorphism.Overloading poly1 = new Polymorphism.Overloading();
            poly1.Add(1, 2);
            poly1.Add("1", "2");
            Polymorphism.Overriding.Derived poly2 = new Polymorphism.Overriding.Derived();
            poly2.Show();
            Polymorphism.Overriding.Base poly3;
            poly3 = poly2;
            poly3.Show();


        }
    }
}
