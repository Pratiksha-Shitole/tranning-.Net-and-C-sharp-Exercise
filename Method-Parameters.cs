using System;

namespace Demo03_MethodParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;

            // copy of the data is sent into the method
            Console.WriteLine("DEMO OF Pass By Value");
            i = 10;
            Console.WriteLine("i = {0}", i);
            DemoOfPassByValue(i);
            Console.WriteLine("i now = {0}", i);
            Console.WriteLine();

            // reference to the data is sent to the method
            Console.WriteLine("DEMO OF Pass By Reference");
            i = 10;
            Console.WriteLine("i = {0}", i);
            DemoOfPassByReference(ref i);
            Console.WriteLine("i now = {0}", i);
            Console.WriteLine();


            // the value of the data variable IS NOT sent into the method
            // only the reference of the data variable is sent to the method.
            // the value HAS TO BE initialized inside the method before you exit the method.
            Console.WriteLine("DEMO OF Pass By Out (Output)");
            i = 10;
            Console.WriteLine("i = {0}", i);
            DemoOfPassByOut(out i);
            Console.WriteLine("i now = {0}", i);
            Console.WriteLine();

            DemoOfVariableNumberOfParameters();
            DemoOfVariableNumberOfParameters(10, 20);
            DemoOfVariableNumberOfParameters(30);
            DemoOfVariableNumberOfParameters(10, 20, 30, 40, 50);
        }

        static void DemoOfPassByValue(int a)
        {
            Console.WriteLine("-- Received a = {0}", a);
            a = 50;
            Console.WriteLine("-- after change, a = {0}", a);
        }

        static void DemoOfPassByReference(ref int a)
        {
            Console.WriteLine("-- Received a = {0}", a);
            a = 50;
            Console.WriteLine("-- after change, a = {0}", a);
        }

        static void DemoOfPassByOut(out int a)
        {
            // Console.WriteLine("-- Received a = {0}", a);         not compile
            a = 50;
            Console.WriteLine("-- after change, a = {0}", a);
        }

        // PASS BY VALUE ONLY!
        static void DemoOfVariableNumberOfParameters( params int[] arr )
        {

        }

    }
}
