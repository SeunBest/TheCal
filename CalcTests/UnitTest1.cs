using Libraries;
using NUnit.Framework;
using System.Security.Cryptography.X509Certificates;

namespace CalcTests
{
    public class Tests
    {
        public double x { get; private set; }
        public double y { get; private set; }
        public double z { get; private set; }
        [SetUp]
        public void Setup()
        {
             x = 20;
             y = 15;
             z = 0;
        }

        [Test]
        public void AdditionTest()
        {
            //Arrange
            AllMethods tes = new AllMethods();

            //Act
            double actual = tes.Addition(x, y);
            double expected = 35;
            
            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}