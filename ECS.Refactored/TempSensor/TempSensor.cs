using System;
using System.Collections.Generic;
using System.Text;
using ECS.Refactored.Random;

namespace ECS.Refactored.TempSensor
{
    public class TempSensor : ITempSensor
    {
        private IRandom _gen;

        public TempSensor(IRandom gen)
        {
            _gen = gen;
        }
        public int GetTemp()
        {
            return _gen.NextRandomNumber(-5, 45);
        }
    }
}
