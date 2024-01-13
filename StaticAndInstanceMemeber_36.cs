using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBegToMas
{
    class StaticAndInstanceMemeber_36
    {
        // Static and Instance Member - These both the concepts of class implementation.
        // First We will see the Instance or Non-static.

        // Instance.
        // Instance member belongs to the object of the class.
        // Every time the object create the memory create for every object separately.
        // Each instance fields/function are different for each object.
        // We have to create object for accessing instance member of class.
        // We can use static fields and method with instance methods

        // Public keyword - We will cover these keyword in access modifier lectures.
        // Bydefault the fields are private, Therefore we wrote the keyword public
        public string Name;
        public int Age;

        public void Detail()
        {
            Console.WriteLine($"Name: {this.Name}\nAge: {this.Age}");
        }

        // The memory create separately for every time the object creates
        // Instance method/fields are deoendent on object.

        // 2. Static Member
        // Static member is the property of class.
        // The memory allocation of static member is one time.
        // It will remain same for each and every instance of class throughout the program.
        // NOTE - We cannot use instance method/fields inside the static fields and methods.
        // But we can use static method/fields inside the instance fields or methods.
        // static keyword is used to create the statoc member of class.
        // We dont need to create the object to access the static fields or methods.
        // We can just use the class name to access the static member of class.
        // The staic members are also bydefault private

        public static string country = "Pakistan";
        public static string region = "Khyber Pakhtunkhwa";
        public static void AboutReg()
        {
            Console.WriteLine($"This program is for only {country} and the Province {region}");
            // Console.WriteLine(this.Name);   // Error
            // Detail();   // Error
        }



    }

    // This class is just for calling/invoking the main one.
    class ExampleForStaticInstance
    {
        public static void Example()
        {
            // Instance Member
            StaticAndInstanceMemeber_36 obj = new StaticAndInstanceMemeber_36();
            obj.Name = "Abbas";
            obj.Age = 23;
            obj.Detail();

            StaticAndInstanceMemeber_36 obj2 = new StaticAndInstanceMemeber_36();   // Both the objects have different memory location.
            obj2.Name = "Ahmed";
            obj2.Age = 30;
            obj2.Detail();

            // Static Member
            StaticAndInstanceMemeber_36.AboutReg();
        }
    }
}
