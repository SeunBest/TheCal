using Libraries;
using NUnit.Framework;
using System;
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

        [Test]
        public void SubtractionTest()
        {
            //Arrange
            AllMethods tes = new AllMethods();

            //Act
            double actual = tes.Subtraction(x, y);
            double expected = 5;

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void MultiplicationTest()
        {
            //Arrange
            AllMethods tes = new AllMethods();

            //Act
            double actual = tes.Multiplication(x, y);
            double expected = 300;

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void DivideByZeroTest()
        {
            //Arrange
            AllMethods tes = new AllMethods();

            //Act
            //Assert
            Assert.That(() => tes.Division(x, z), Throws.TypeOf<DivideByZeroException>());
        }

        [Test]
        public void DivisionTest()
        {
            //Arrange
            y = 2;
            AllMethods tes = new AllMethods();

            //Act
            double actual = tes.Division(x, y);
            double expected = 10;

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

    }
}