using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C#Assignment01
{
    class Person
    {
        // backing data field for the property Name
        private string _name;           

        // Property
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name cannot be empty");
                }
                else
                {
                    _name = value;
                }
            }
        }

        // backing field for the Age Property
        private int _age;

        // Property 
        public int Age
        {
            get 
            {
                return _age;
            }
            set
            {
                if( value >= 18 && value <= 65)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Invalid age!");
                }
            }
        }
    }
}
