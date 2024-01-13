using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBegToMas
{
    class Constructor_34
    {
        // Constructor in Oop - Constructor is a special member function of a class that is executed whenever we create the object of a class.
        // A constructor has exactly the same name as class name, and it has no return type.
        // There are two types of constructor 
        // 1. Default Constructor
        // 2. Parameterized Construstor

        // 1. Default Constructor.
        // A constructor without parameter is called default parameter. It initializes the same value of every instance of a class.
        // If we do not create the constructor of class, the compiler will automatically create the default constructor for a class.
        // We don't need to call the construto explicitly. It will automatically called when the object creates.
        // Example.
        //public Constructor_34()
        //{
        //    Console.WriteLine("Constructor called...!!!");
        //}

        // 2. Parameterized Constructor.
        // A constructo which has one or more than one parameter is called parameterized constructor.
        // Using this type of cnstructor we can iniitalize each instance of a class to different value.

        int Id;
        string Name;
        int Age;
        public Constructor_34(int Id, string Name, int Age)
        {
            // this - this keyword indicates the difference between class fields and parameter.
            // And this represent the current values of fields.
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
        }

        public void GetData()
        {
            Console.WriteLine($"Id : {this.Id}");
            Console.WriteLine($"Name : {this.Name}");
            Console.WriteLine($"Age : {this.Age}");
        }
            
    }
}
