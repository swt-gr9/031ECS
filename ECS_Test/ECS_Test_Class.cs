﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECS.Refactored.Heater;
using ECS.Refactored.Logger;
using ECS.Refactored.Random;
using ECS.Refactored.TempSensor;
using NUnit;
using NUnit.Framework;


namespace ECS_Test
{
    using ECS.Refactored.ECS;
    [TestFixture]
    class ECS_Test_Class
    {
        private ECS uut;
        private TempSensor _temp;
        private IRandom rand;
        private ILogger log;
        private IHeater heat;

        [TestCase(10, 10)]
        [TestCase(5, 10)]
        public void TestTempAlwaysReturn10(int num, int result)
        {
            rand = new FakeRandom();
            Assert.That(rand.NextRandomNumber(num, num), Is.EqualTo(result));
        }

        [TestCase(10)]
        public void TestTempReturnsResult(int result)
        {
            rand = new FakeRandom();
            _temp = new TempSensor(rand);
            Assert.That(_temp.GetTemp(), Is.EqualTo(result));
        }

        [TestCase("Hello")]
        public void TestLogInputIsWritten(string input)
        {
            log = new FakeLogger();
            log.WriteLogLine(input);
            Assert.That(log.input, Is.EqualTo(input));
        }

        [TestCase(5)]
        [TestCase(10)]
        public void HeaterOnNTimes(int n)
        {
            heat = new FakeHeater();
            for (int i = 0; i < n; i++)
            {
                heat.TurnOn();
            }

            Assert.That(heat.TurnOnCalledTimes, Is.EqualTo(n));
        }

        [TestCase(5)]
        [TestCase(10)]
        public void HeaterOffNTimes(int n)
        {
            heat = new FakeHeater();
            for (int i = 0; i < n; i++)
            {
                heat.TurnOff();
            }

            Assert.That(heat.TurnOffCalledTimes, Is.EqualTo(n));
        }
       
    }
}
