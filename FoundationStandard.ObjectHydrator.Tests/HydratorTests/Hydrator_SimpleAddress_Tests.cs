using FoundationStandard.ObjectHydrator.Tests.POCOs;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoundationStandard.ObjectHydrator.Tests.HydratorTests
{
    [TestFixture]
    public class Hydrator_SimpleAddress_Tests
    {
        [Test]
        public void SimpleTest()
        {
            var hydrator = new Hydrator<Address>();

            var checkme = hydrator.GetSingle();
            Assert.IsNotNull(checkme);
        }

        [Test]
        public void CityTest()
        {
            var hydrator = new Hydrator<Address>();

            var checkme = hydrator.GetSingle();
            Assert.IsNotNull(checkme);
        }

        [Test]
        public void StateTest()
        {
            var hydrator = new Hydrator<Address>();

            var checkme = hydrator.GetSingle();
            Assert.IsNotNull(checkme);
        }
    }
}

