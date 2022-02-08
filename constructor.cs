using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo09_Constructor.Demo01
{

    public class Demo
    {
        public static void Run()
        {
            Employee emp = new Employee("First Employee");
            Console.WriteLine(emp.Name);
        }
    }



    class Employee
    {
        
        // Constructor
        // Initialize internal instance members
        public Employee(string name)
        {
            _name = name;
        }


        // backing data field
        private string _name;

        // Readonly Property
        public string Name
        {
            get
            {
                return _name;
            }
        }
    }
}
