using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Refactored.Heater
{
    public interface IHeater
    {
        void TurnOn();
        void TurnOff();
    }
}
