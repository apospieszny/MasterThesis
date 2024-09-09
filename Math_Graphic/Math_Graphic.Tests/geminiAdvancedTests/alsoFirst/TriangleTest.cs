using Math_Graphic.core.common;
using Math_Graphic.core.math;
using Math_Graphic.core.math.shapes;
using NUnit.Framework;

/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 */

namespace Math_Graphic.Tests.geminiAdvanced.alsoFirst
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void Constructor_SetsShapeTypeAndPoints()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(3, 0);
            var p3 = new PointXy(0, 4);

            // Act
            var triangle = new Triangle(p1, p2, p3);

            // Assert
            Assert.AreEqual(ShapeType.Triangle, triangle.ShapeType);
        }


        [Test]
        public void DrawMe_CalculatesAreaAndCreatesBitmap()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(3, 0);
            var p3 = new PointXy(0, 4);
            var triangle = new Triangle(p1, p2, p3);

            // Act
            var bitmap = triangle.DrawMe();

            // Assert
            Assert.AreEqual(1000000, bitmap.GetSize()); // Assuming 1000x1000 bitmap
            // Additional assertions to check the content of the bitmap if needed
        }

        [Test]
        public void Origin_ReturnsCorrectOrigin()
        {
            // Arrange
            var p1 = new PointXy(2, 3);
            var p2 = new PointXy(5, 1);
            var p3 = new PointXy(0, 7);
            var triangle = new Triangle(p1, p2, p3);

            // Act
            var origin = triangle.Origin();

            // Assert
            Assert.AreEqual(0, origin.X);
            Assert.AreEqual(1, origin.Y);
        }
        /* Test odrzucony
        [Test]
        public void Area_CalculatesAreaOnceAndReturnsIt()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(3, 0);
            var p3 = new PointXy(0, 4);
            var triangle = new Triangle(p1, p2, p3);

            // Act
            var area1 = triangle.Area();
            var area2 = triangle.Area();

            // Assert
            Assert.AreEqual(6, area1);
            Assert.AreEqual(6, area2);
        }*/
    }
}

/*
using Math_Graphic.core.common;
using Math_Graphic.core.math;
using Math_Graphic.core.math.shapes;
using NUnit.Framework;

namespace Math_Graphic.core.tests.math.shapes
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void Constructor_SetsShapeTypeAndPoints()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(3, 0);
            var p3 = new PointXy(0, 4);

            // Act
            var triangle = new Triangle(p1, p2, p3);

            // Assert
            Assert.AreEqual(ShapeType.Triangle, triangle.ShapeType);
            Assert.AreEqual(p1, triangle._p1);
            Assert.AreEqual(p2, triangle._p2);
            Assert.AreEqual(p3, triangle._p3);
        }

        [Test]
        public void PointInTriangle_PointInside_ReturnsTrue()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(3, 0);
            var p3 = new PointXy(0, 4);
            var triangle = new Triangle(p1, p2, p3);

            // Act
            var result = triangle.PointInTriangle(1, 1);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void PointInTriangle_PointOutside_ReturnsFalse()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(3, 0);
            var p3 = new PointXy(0, 4);
            var triangle = new Triangle(p1, p2, p3);

            // Act
            var result = triangle.PointInTriangle(4, 1);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void PointInTriangle_PointOnEdge_ReturnsTrue()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(3, 0);
            var p3 = new PointXy(0, 4);
            var triangle = new Triangle(p1, p2, p3);

            // Act
            var result = triangle.PointInTriangle(1, 0);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void PointInTriangle_PointOnVertex_ReturnsTrue()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(3, 0);
            var p3 = new PointXy(0, 4);
            var triangle = new Triangle(p1, p2, p3);

            // Act
            var result = triangle.PointInTriangle(0, 0);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void DrawMe_CalculatesAreaAndCreatesBitmap()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(3, 0);
            var p3 = new PointXy(0, 4);
            var triangle = new Triangle(p1, p2, p3);

            // Act
            var bitmap = triangle.DrawMe();

            // Assert
            Assert.AreEqual(6, triangle._area); // Expected area of the triangle
            Assert.AreEqual(1000000, bitmap.GetSize()); // Assuming 1000x1000 bitmap
            // Additional assertions to check the content of the bitmap if needed
        }

        [Test]
        public void Origin_ReturnsCorrectOrigin()
        {
            // Arrange
            var p1 = new PointXy(2, 3);
            var p2 = new PointXy(5, 1);
            var p3 = new PointXy(0, 7);
            var triangle = new Triangle(p1, p2, p3);

            // Act
            var origin = triangle.Origin();

            // Assert
            Assert.AreEqual(0, origin.X);
            Assert.AreEqual(1, origin.Y);
        }

        [Test]
        public void Area_CalculatesAreaOnceAndReturnsIt()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(3, 0);
            var p3 = new PointXy(0, 4);
            var triangle = new Triangle(p1, p2, p3);

            // Act
            var area1 = triangle.Area();
            var area2 = triangle.Area();

            // Assert
            Assert.AreEqual(6, area1);
            Assert.AreEqual(6, area2);
        }
    }
}
*/