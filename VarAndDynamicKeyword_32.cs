using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBegToMas
{
    class VarAndDynamicKeyword_32
    {
        public static void Example()
        {
            // Var and Dynamic Keyword - Thesetwo keyword is use for the same purposes in c#.
            // But there are certain differences between them.
            // First we will cover the var keyword.

            // var 
            // The var kwyword introduced in c# 3.0.
            // var keyword is used to store any type of data in its variable.
            // The value of var is decided at the compile time.
            // We have to initialize the variable in case of var
            // var variable1;    // Error

            // For getting the type of variable we can use .GetType() method.

            // We cannot change the type of variable later, which is initialized using var keyword.
            var variable2 = "Abbas";
            // variable2 = 123;    // Error.

            Console.WriteLine(variable2.GetType());   // System.String
            Console.WriteLine(variable2.GetType() == typeof(string));   // True

            // Once, we initialize the variable with var variable, Then we cannot change the value of var with some other datatype.
            // We can use all the methods, properties of that specific datatype which is inside the var
            // Intellisense help is available for the var type of variable. Because is decided at the the of compile.
            // var variable cannot use for property or return values from a function. They can only be used as local variable in a function.
            // We cannot use var variable as a function parameter.
            // public static var function()   // Error
            // public static int function (var a)   // Error
            // public static var prop { get; set; }

            // var keyword is of value type.


            // Now lets begin with the dynamic keyword.
            // Dynamic Keyword

            // dynamic keyword was introduced in c# 4.0.
            // dynamic keyword is also used to store any type of data in its variable.
            // value of dynamic variable is decided at runtime.
            // Initializing is not mandatory when we declare a variable with dynamic keyword.
            dynamic variable3;   // No Error
            variable3 = 123;

            // For also getting the type of variable value
            Console.WriteLine(variable3.GetType());   // System.Int32
            Console.WriteLine(variable3.GetType() == typeof(int));   // True

            // We can change the datatype of dynamic variable later in the program
            variable3 = "Abbas";   // No Error

            // Intellisense help is not available fro dynamic type of variable, because it value decided on runtime.
            // Dynamic keyword can be used to create properties and return type.
            // We can also use dynamic keyword as a function parameter.
            // public static dynamic prop { get; set; }   // No Error
            // public static dynamic func() {}  // No Error
            // public static dynamic func(dynamic a) { return a; }  // No Error

            // Dynamic keyword is of reference type.
            // Dynamic keyword method
            Func(true);
            Func(123);
            Func("abc");   // No Errors at all.
        }
        // dynamic method
        public static dynamic Func(dynamic a)
        {
            return a;
        }
    }
}
