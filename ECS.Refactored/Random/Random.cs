using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Refactored.Random
{
    public class Random : IRandom
    {
        private System.Random ran = new System.Random();

        public int NextRandomNumber(int lower, int higher)
        {
            return ran.Next(lower, higher);
        }
    }
}
