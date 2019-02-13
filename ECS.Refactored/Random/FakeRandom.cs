using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Refactored.Random
{
    public class FakeRandom : IRandom
    {
        public int NextRandomNumber(int lower, int higher)
        {
            return 10;
        }
    }
}
