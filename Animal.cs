using System;

namespace VirtualOverrideDemo
{
    public class Animal
    {
        //Animal properties
        private string Name { get; set; }
        private int Age { get; set; }
        private bool IsHungry { get; set; }
        
        //Animal Constructor
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            IsHungry = true;
        }
        
        //The noise the animal makes
        public virtual void MakeSound()
        {
            
        }
        
        //The animal will eat when it is hungry
        public virtual void Eat()
        {
            if (IsHungry)
            {
                Console.WriteLine($"{Name} is eating.");
            }
            else
            {
                Console.WriteLine($"{Name} is not hungry.");
            }
        }
        
        //The animal will play
        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing.");
        }
    }
}