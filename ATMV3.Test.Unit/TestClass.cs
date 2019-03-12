using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ATMV3.Test.Unit
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void Test1()
        {
            Assert.That(3, Is.EqualTo(1+2));
        }
    }
}
