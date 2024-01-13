using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBegToMas
{
    class ClassesAndObjects_33
    {
        // Classes and obejct - C# programs are composed of classes that represents the entitiesof the program which also iclude to instantiatethe class and obejct
        // When the program runs, the object created.
        // The classes are blue print for creating and manipulating the object.
        // We can take an example of car.
        // Car
        // Characteristic - Brand: Toyota; Color Blue; Wheel: Four; etc
        // Behaviour - Runs, Breaks, Runs Fast, Reverse etc
        // Lets take an exmaple.
        public string brand;
        public string color;
        public int wheels;
        public string transmition;
        public int speed;

        // this keyword - represent the current value of object, which is assigned to that field.

        public void Break()
        {
            Console.WriteLine($"This {this.brand} car can break very fast");
        }
        public void Speed()
        {
            Console.WriteLine($"This {this.brand} car can go {this.speed} kmph.");
        }
        public void Wheels()
        {
            Console.WriteLine($"This {this.brand} car has {this.wheels}.");
        }
        // Now lets create the object in program.cs file
    }
}
