using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        [TestCase(10, 10)]
        [TestCase(5, 10)]
        public void TestTempAlwaysReturn10(int num, int result)
        {
            rand = new FakeRandom();
            Assert.That(rand.NextRandomNumber(num, num), Is.EqualTo(result));
        }

        [TestCase(10)]
        public void TestTemp(int result)
        {
            rand = new FakeRandom();
            _temp = new TempSensor(rand);
            Assert.That(_temp.GetTemp(), Is.EqualTo(result));
        }
    }
}
