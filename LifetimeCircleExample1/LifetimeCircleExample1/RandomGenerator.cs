using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifetimeCircleExample1
{
    public class RandomGenerator
    {
        private static Random _rand;

        public RandomGenerator() 
        {
            _rand = new Random();
            Number = _rand.Next(0, 100000);
        }

        public int Number { get; private set; }
        public string Guidos { get; private set; }
    }
}