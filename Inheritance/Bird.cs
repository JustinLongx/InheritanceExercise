using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        
        public Bird()
        {
            HasFeathers = true;
            HasBeak = true;
            HasTalons = true;
            LaysEggs = true;
        }
        public bool HasFeathers { get; set; }
        public bool HasBeak { get; set;  }
        public bool HasTalons { get; set; }
        public bool LaysEggs { get; set; }

        public void BirdMessage()
        {
            Console.WriteLine($"Is it true that all birds have feathers?: {HasFeathers}");
            Console.WriteLine($"Is it true that all birds have beaks?: {HasBeak}");
        }
    }
}
