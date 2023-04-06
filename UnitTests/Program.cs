using NUnit.Framework;
using FakeItEasy;
using Wrapper;
using NUnit.Framework.Internal.Execution;
using Test;
using ExecFile;

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

            var result = wrapperContext.UseAddNumbers();

            Assert.That(result, Is.EqualTo(c));
        }

        [Test]
        public void Testowanko2_return30()
        {
            var ExecContext = new ExecWrapper();

            var c = 30;

            var result = ExecContext.UseWrapperMethod();

            Assert.That(result, Is.EqualTo(c));
        }

        [Test]
        public void UseWrapperFunction_IsEqualToUseAddNumbers()
        {
            var ExecContext = new ExecWrapper();

            var ciape= new CPlusPlusWraper();

            var ciap = ciape.UseAddNumbers();

            var result = ExecContext.UseWrapperMethod();

            Assert.That(result, Is.EqualTo(ciap));
        }



    }
}
