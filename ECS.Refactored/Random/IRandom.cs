using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Refactored.Random
{
    public interface IRandom
    {
        int NextRandomNumber(int lower, int higher);
    }
}
