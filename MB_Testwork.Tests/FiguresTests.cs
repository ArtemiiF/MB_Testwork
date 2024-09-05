using MB_Testwork.Figures;
using MB_Testwork.Interfaces;

namespace MB_Testwork.Tests
{
    [TestClass]
    public class FiguresTests
    {

        #region CircleTests

        [TestMethod]
        public void CheckCircleNegativeRadius()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle(-5));
        }

        [TestMethod]
        public void CheckCircleNegativFractionaleRadius()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle(-5.1));
        }

        [TestMethod]
        public void CheckCircleZeroRadius()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle(0));
        }

        [TestMethod]
        public void CheckCirclePositiveRadius()
        {
            //arrange
            Circle circle = new Circle(1);

            //act
            double circleSquare = circle.Square;

            //assert
            Assert.AreEqual(Math.PI, circleSquare);
        }

        [TestMethod]
        public void CheckCirclePositiveFractionalNumbersRadius()
        {
            //arrange
            Circle circle = new Circle(0.1);

            //act
            double circleSquare = circle.Square;

            //assert
            Assert.AreEqual(Math.PI * 0.01, circleSquare);
        }

        #endregion

        #region TriangleTests

        [TestMethod]
        public void CheckTriangleAllSidesNegative()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-10, -10, -10));
        }

        [TestMethod]
        public void CheckTriangleASideNegative()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-10, 10, 10));
        }

        [TestMethod]
        public void CheckTriangleBSideNegative()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(10, -10, 10));
        }

        [TestMethod]
        public void CheckTriangleCSideNegative()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(10, 10, -10));
        }

        [TestMethod]
        public void CheckTriangleAllSidePositive()
        {
            //arrange
            Triangle triangle = new Triangle(10, 15, 20);

            //act
            double triangleSquare = triangle.Square;

            //assert
            Assert.AreEqual(72.61843774138907, triangleSquare);
        }

        [TestMethod]
        public void CheckTriangleAllSidePositiveFractionalNumbers()
        {
            //arrange
            Triangle triangle = new Triangle(10.5, 15.5, 20.5);

            //act
            double triangleSquare = triangle.Square;

            //assert
            Assert.AreEqual(79.4847420499683, triangleSquare);
        }

        [TestMethod]
        public void CheckTriangleIsRightTrue()
        {
            //arrange
            Triangle triangle = new Triangle(3, 5, 4);

            //act
            bool isRightTriangle = triangle.IsRight;

            //assert
            Assert.AreEqual(true, isRightTriangle);
        }

        [TestMethod]
        public void CheckTriangleIsNotRightTrue()
        {
            //arrange
            Triangle triangle = new Triangle(7, 10, 4);

            //act
            bool isRightTriangle = triangle.IsRight;

            //assert
            Assert.AreEqual(false, isRightTriangle);
        }

        #endregion

        [TestMethod]
        public void CheckCircleSquareAsFigure()
        {
            //arrange
            ISquarable figure = new Circle(0.1);

            //act
            var figureSquare = figure.Square;

            //assert
            Assert.AreEqual(Math.PI * 0.01, figureSquare);
        }

        [TestMethod]
        public void CheckTriangleSquareAsFigure()
        {
            //arrange
            ISquarable figure = new Triangle(10, 15, 20);

            //act
            var figureSquare = figure.Square;

            //assert
            Assert.AreEqual(72.61843774138907, figureSquare);
        }
    }
}