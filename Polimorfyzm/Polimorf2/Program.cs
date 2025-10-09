using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorf2
{
    internal class Program
    {

        class Animal
        {
            public virtual void Speak()
            {
                Console.WriteLine("i can speak");
            }
        }

        class Dog : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("woof");
            }
        }

        class Cat : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("meow");
            }
        }
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
            Animal[] animals = { dog, cat};

            foreach (var item in animals)
            {
                item.Speak();
            }
        }
    }
}
