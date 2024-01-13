using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBegToMas
{
    class ConstructorOverloading_35
    {
        // Constructor Overloading - is the concept of multiple constructor different parameter.
        // It is same like the method overloading.
        // Example
        public ConstructorOverloading_35()
        {
            Console.WriteLine("This is the first constructor.");
        }
        public ConstructorOverloading_35(int num1, int num2)
        {
            Console.WriteLine($"This is the second constructor: {num1 + num2}");
        }
        public ConstructorOverloading_35(string name, int age)
        {
            Console.WriteLine($"This is the third constructor: {name} {age}");
        }
        // NOTE - These will be invokes beased on parameters.
        public void  hello() { }
        public void hello(int age) { }
    }
}
