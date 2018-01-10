using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    /// <summary>
    ///  Refers to an object's ability to hide data and behavior that are not necessary to its user. 
    ///  Encapsulation enables a group of properties, 
    ///  methods and other members to be considered a single unit or object.
    /// </summary>
    class Encapsulation
    {
        public class Employee
        {
            private string firstName;
            private string lastName;

            public String FirstName
            {
                get { return firstName; }
                set
                {
                    firstName = value;
                }
            }

            public String LastName
            {
                get { return lastName; }
                set
                {
                    lastName = value;
                }
            }

            public string FullName()
            {
                return string.Format("{0} {1}", firstName, lastName);
            }
        }




    }
}
