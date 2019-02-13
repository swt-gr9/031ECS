using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Refactored.Heater
{
    public interface IHeater
    {
        int TurnOnCalledTimes { get; set; }
        int TurnOffCalledTimes { get; set; }
        void TurnOn();
        void TurnOff();
    }
}
