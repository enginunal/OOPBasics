using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    /// <summary>
    /// When you define a class to derive from another class, 
    /// the derived class implicitly gains all the members of the base class, 
    /// except for its constructors and finalizers. 
    /// The derived class can thereby reuse the code in the base class without having to 
    /// re-implement it. In the derived class, you can add more members. 
    /// In this manner, the derived class extends the functionality of the base class.
    /// </summary>
    class Inheritance
    {

        public class Shape
        {
            public double Width;
            public double Height;
            public void ShowDim()
            {
                Console.WriteLine("Width and height are " + Width + " and " + Height);
            }
        }

        public class Triangle : Shape
        {
            public string Style;

            public void ShowArea()
            {
                Console.WriteLine("Area is " +  Width * Height / 2);
            }

            public void ShowStyle()
            {
                Console.WriteLine("Triangle is " + Style);
            }
        }


    }
}
