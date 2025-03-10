using System;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using DiscreteEventSimulation.objects;

namespace UnitTests
{
    [TestFixture]
    public class TestStandardUnit
    {
        [Test]
        public void TestStandardUnitType()
        {
            StandardUnit test = new StandardUnit("Test Lot", "Test Product", "Test FlowPlan", 25);
            
            ClassicAssert.AreEqual("Standard", test.GetUnitType());
        }
    }
}