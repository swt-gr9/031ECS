using System;
using System.Collections.Generic;
using System.Text;
using ECS.Refactored.Logger;

namespace ECS.Refactored.Heater
{
    public class FakeHeater : IHeater
    {
        public int TurnOnCalledTimes { get; set; }
        public int TurnOffCalledTimes { get; set; }

        public FakeHeater()
        {
            TurnOnCalledTimes = 0;
            TurnOffCalledTimes = 0;
        }

        public void TurnOn()
        {
            TurnOnCalledTimes++;
        }

        public void TurnOff()
        {
            TurnOffCalledTimes++;
        }
    }
}
