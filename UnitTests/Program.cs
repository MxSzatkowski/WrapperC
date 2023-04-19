using NUnit.Framework;
using FakeItEasy;
using Wrapper;
using NUnit.Framework.Internal.Execution;
using System.Runtime.InteropServices;
using CLI;

namespace UnitTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void UseAddNumber_return30()
        {
            var wrapperContext = new CPlusPlusWraper();

            var c = 30;

            var result = wrapperContext.UseAddNumbers(10, 20);

            Assert.That(result, Is.EqualTo(c));
        }

        [Test]
        public void add_return30()
        {
            Entity wrap = new Entity();

            var c = 30;

            var result = wrap.add(10, 20);

            Assert.That(result, Is.EqualTo(c));
        }
    }
}
