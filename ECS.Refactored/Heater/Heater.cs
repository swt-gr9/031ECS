using System;
using System.Collections.Generic;
using System.Text;
using ECS.Refactored.Logger;

namespace ECS.Refactored.Heater
{
    public class Heater : IHeater
    {
        private readonly ILogger _logger;

        public Heater(ILogger logger)
        {
            _logger = logger;
        }
        public void TurnOn()
        {
            _logger.WriteLogLine("Heater is on");
        }

        public void TurnOff()
        {
            _logger.WriteLogLine("Heater is off");
        }

    }
}
