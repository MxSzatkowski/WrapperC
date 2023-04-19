using NUnit.Framework;
using FakeItEasy;
using Wrapper;
using NUnit.Framework.Internal.Execution;
using System.Runtime.InteropServices;

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
    }
}
