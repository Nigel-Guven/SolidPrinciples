using System;

namespace SolidPrinciples.Liskov_Substitution_Principle
{
    /*
     * In this abstraction, Shark conforms to the Liskov Substitution Principle, there is a new class for Fish who Swim, not Speak
     * Mammal has been split from Animal class to account for land creatures
     */
    public class LSPCompliance
    {
        abstract partial class Animal{ }

        abstract partial class Mammal : Animal
        {
            void Speak()
            {
                Console.WriteLine("");
            }

        }

        abstract partial class Fish
        {
            void Swim()
            {
                Console.WriteLine("");
            }

        }

        class Dog : Mammal
        {
            void Speak()
            {
                Console.WriteLine("Bark");
            }
        }

        class Cat : Mammal
        {
            void Speak()
            {
                Console.WriteLine("Meow");
            }
        }

        class Bird : Mammal
        {
            void Speak()
            {
                Console.WriteLine("Cawcaw");
            }
        }

        class Shark : Fish
        {
            void Swim()
            {
                Console.WriteLine("Swimming not speaking");
            }
        }



    }
}
