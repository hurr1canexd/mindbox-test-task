using AreaCalculatorLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AreaCalculatorLibraryTests
{
    [TestClass]
    public class ShapesUnitTest
    {
        [TestMethod]
        public void NegativeCircleRadiusTest()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(-1));
        }

        [TestMethod]
        public void NegativeLengthsOfTriangleSidesTest()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-1, 1, 1));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(1, -1, 1));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(1, 1, -1));
        }

        [TestMethod]
        public void IncorrectSidesLengthsTest()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(8, 5, 2));
        }

        [TestMethod]
        public void CalculateCircleAreaTest()
        {
            var circle = new Circle(5);
            var expectedArea = Math.PI * 25;
            var area = circle.GetArea();

            Assert.AreEqual(expectedArea, area);
        }

        [TestMethod]
        public void CalculateTriangleAreaTest()
        {
            var triangle = new Triangle(3, 4, 5);
            double area = triangle.GetArea();
            
            Assert.AreEqual(6, area);
        }

        [TestMethod]
        public void TriangleIsRightTest()
        {
            var triangle = new Triangle(3, 4, 5);
            bool isRight = triangle.IsRight();
            
            Assert.AreEqual(true, isRight);
        }

        [TestMethod]
        public void TriangleIsNotRightTest()
        {
            var triangle = new Triangle(4, 5, 6);
            bool isRight = triangle.IsRight();
            
            Assert.AreEqual(false, isRight);
        }
    }
}
