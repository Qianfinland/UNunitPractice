
using NUnit.Framework;
namespace Calculator.Tests
{
    [TestFixture]
    public class SimpleCalculatorTests
    {
        [Test]
        public void ShouldAddTwoNumbers()
        {
            var sut = new SimpleCalculator();
            var result = sut.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void ShouldMultiplyTwoNumbers()
        {
            var sut = new SimpleCalculator();
            var result = sut.Multiply(3, 10);
            Assert.That(result, Is.EqualTo(30));
        }

        [Test]
        public void ShouldAddDoubles()
        {
            var sut = new SimpleCalculator();
            var result = sut.AddDoubles(1.1, 2.2);
            Assert.That(result, Is.EqualTo(3.3));
        }

        [Test]
        public void ShouldAddDoubles_WithTolerance()
        {
            var sut = new SimpleCalculator();
            var result = sut.AddDoubles(1.1, 2.2);
            Assert.That(result, Is.EqualTo(3.3).Within(0.01));
        }

        [Test]
        public void ShouldAddDoubles_WithPercentageTolerance()
        {
            var sut = new SimpleCalculator();
            var result = sut.AddDoubles(50, 52);
            Assert.That(result, Is.EqualTo(101).Within(1).Percent);
        }

        //bad example of tolerance, Test pass but shouldn't 
        [Test]
        public void ShouldAddDoubles_BadTolerance()
        {
            var sut = new SimpleCalculator();
            var result = sut.AddDoubles(1.1, 2.2);
            Assert.That(result, Is.EqualTo(30).Within(100));
        }
    }
}
