using System;

namespace SolidPrinciples.Liskov_Substitution_Principle
{
    /*
     * In this abstraction, Shark breaks the Liskov Substitution Principle since it cannot speak like a Dog or Cat
     */

    internal class LSPViolation
    {
        abstract partial class Animal
        {
            void Speak()
            {
                Console.WriteLine("");
            }

        }

        class Dog : Animal
        {
            void Speak()
            {
                Console.WriteLine("Bark");
            }
        }

        class Cat : Animal
        {
            void Speak()
            {
                Console.WriteLine("Meow");
            }
        }

        class Bird : Animal
        {
            void Speak()
            {
                Console.WriteLine("Cawcaw");
            }
        }

        class Shark : Animal
        {
            void Speak()
            {
                Console.WriteLine("Shark cannot speak");
            }
        }
    }
}
