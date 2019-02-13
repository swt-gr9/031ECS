using System;
using System.Collections.Generic;
using System.Text;
using ECS.Refactored.Heater;
using ECS.Refactored.TempSensor;

namespace ECS.Refactored.ECS
{
    public class ECS
    {
        public int _threshold { get; set; }
        private readonly ITempSensor _tempSensor;
        private readonly IHeater _heater;

        public ECS(int thr, IHeater heater, ITempSensor tempSensor)
        {
            _threshold = thr;
            _tempSensor = tempSensor;
            _heater = heater;
        }

        public int GetCurTemp()
        {
            return _tempSensor.GetTemp();
        }

        public void Regulate()
        {
            var t = _tempSensor.GetTemp();
            if (t < _threshold)
                _heater.TurnOn();
            else
                _heater.TurnOff();
        }
    }
}
