using System;
using System.Collections.Generic;
using System.Text;


namespace ECS.Refactored.TempSensor
{
    public class FakeTempSensor : ITempSensor
    {
        public int Temp { get; set; }

        public FakeTempSensor()
        {
            Temp = 0;
        }


        public int GetTemp()
        {
            return Temp;
        }
    }
}
