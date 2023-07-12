using MB_Testwork.Figures;

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
        public void CheckCircleZeroRadius()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle(-5));
        }

        [TestMethod]
        public void CheckCirclePositiveRadius()
        {
            //arrange
            var circle = new Circle(1);

            //act
            var circleSquare = circle.Square;

            //assert
            Assert.AreEqual(Math.PI, circleSquare);
        }

        [TestMethod]
        public void CheckCirclePositiveFractionalNumbersRadius()
        {
            //arrange
            var circle = new Circle(0.1);

            //act
            var circleSquare = circle.Square;

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
            var triangle = new Triangle(10, 15, 20);

            //act
            var triangleSquare = triangle.Square;

            //assert
            Assert.AreEqual(72.61843774138907, triangleSquare);
        }

        [TestMethod]
        public void CheckTriangleAllSidePositiveFractionalNumbers()
        {
            //arrange
            var triangle = new Triangle(10.5, 15.5, 20.5);

            //act
            var triangleSquare = triangle.Square;

            //assert
            Assert.AreEqual(79.4847420499683, triangleSquare);
        }

        [TestMethod]
        public void CheckTriangleIsRightTrue()
        {
            //arrange
            var triangle = new Triangle(3, 5, 4);

            //act
            var isRightTriangle = triangle.IsRight;

            //assert
            Assert.AreEqual(true, isRightTriangle);
        }

        [TestMethod]
        public void CheckTriangleIsNotRightTrue()
        {
            //arrange
            var triangle = new Triangle(7, 10, 4);

            //act
            var isRightTriangle = triangle.IsRight;

            //assert
            Assert.AreEqual(false, isRightTriangle);
        }

        #endregion

        [TestMethod]
        public void CheckCircleSquareAsFigure()
        {
            //arrange
            Figure figure = new Circle(0.1);

            //act
            var figureSquare = figure.Square;

            //assert
            Assert.AreEqual(Math.PI * 0.01, figureSquare);
        }

        [TestMethod]
        public void CheckTriangleSquareAsFigure()
        {
            //arrange
            Figure figure = new Triangle(10, 15, 20);

            //act
            var figureSquare = figure.Square;

            //assert
            Assert.AreEqual(72.61843774138907, figureSquare);
        }
    }
}