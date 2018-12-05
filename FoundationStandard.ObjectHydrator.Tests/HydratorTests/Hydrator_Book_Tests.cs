using FoundationStandard.ObjectHydrator.Tests.POCOs;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoundationStandard.ObjectHydrator.Tests.HydratorTests
{
    [TestFixture]
    public class Hydrator_Book_Tests
    {
        [Test]
        public void SimpleTest()
        {
            var hydrator = new Hydrator<Book>();
            var book = hydrator.Generate();

            Assert.IsTrue(book.ISBN.StartsWith("978-"), "Should start with 978");

        }
    }
}
