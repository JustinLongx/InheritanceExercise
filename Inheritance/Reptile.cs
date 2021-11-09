using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            HasScales = true;
            LivesInDesert = true;
            IsColdBlooded = true;
            EatsInsects = true;
        }
        public bool HasScales { get; set; }
        public bool LivesInDesert { get; set; }
        public bool IsColdBlooded { get; set; }
        public bool EatsInsects { get; set; }

        public void ReptileMessage()
        {
            Console.WriteLine($"Do all reptiles have scales?: {HasScales}");
        }
    }

}
