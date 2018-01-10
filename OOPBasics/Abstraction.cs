using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    /// <summary>
    /// Abstraction means providing the essential features without showing its inner 
    /// details or hiding internal implementation.
    /// Abstraction is the act of representing essential information without including background details and explanations.
    /// 
    /// Advantages of abstraction are the hiding of implementation details, 
    /// component reuse, extensibility, and testability. 
    /// When we hide implementation details, we reveal a cleaner, more comprehensible and usable interface to our users. 
    /// </summary>
    class Abstraction
    {

        public abstract class Shape
        {
            private int _width;
            private int _height;
            
            public int Width
            {
                get { return _width; }
                set { _width = value; }
            }

            public int Height
            {
                get { return _height; }
                set { _height = value; }
            }
            
            public abstract float CalculateArea();
                        
        }

        public class Rectangle : Shape
        {
            public override float CalculateArea()
            {
                return Width * Height;
            }
        }



    }
}
