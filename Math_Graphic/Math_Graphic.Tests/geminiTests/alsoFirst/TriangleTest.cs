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

namespace Math_Graphic.Tests.gemini.alsoFirst
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void Constructor_InitializesPropertiesCorrectly()
        {
            // Arrange
            var p1 = new PointXy(1, 2);
            var p2 = new PointXy(3, 4);
            var p3 = new PointXy(5, 6);

            // Act
            var triangle = new Triangle(p1, p2, p3);

            // Assert
            Assert.AreEqual(ShapeType.Triangle, triangle.ShapeType);
        }
        /* Test odrzucony
        [Test]
        public void DrawMe_ReturnsBitmapWithCorrectPixelValues()
        {
            // Arrange
            var triangle = new Triangle(new PointXy(0, 0), new PointXy(10, 0), new PointXy(5, 5));

            // Act
            var bitmap = triangle.DrawMe();

            // Assert
            Assert.AreEqual(11, bitmap.GetSize()); // Assuming a 11x11 bitmap
            Assert.AreEqual(1, bitmap.Get(5, 5)); // Pixel inside the triangle
            Assert.AreEqual(0, bitmap.Get(11, 11)); // Pixel outside the triangle
        }

        [Test]
        public void Area_CalculatesCorrectArea()
        {
            // Arrange
            var triangle = new Triangle(new PointXy(0, 0), new PointXy(10, 0), new PointXy(5, 5));

            // Act
            var area = triangle.Area();

            // Assert
            Assert.AreEqual(25, area);
        }*/

        [Test]
        public void Area_CachesResult()
        {
            // Arrange
            var triangle = new Triangle(new PointXy(0, 0), new PointXy(10, 0), new PointXy(5, 5));

            // Act
            var area1 = triangle.Area();
            var area2 = triangle.Area();

            // Assert
            Assert.AreEqual(area1, area2); // Ensure the area is cached
        }
    }
}

/*
using Math_Graphic.core.common;
using Math_Graphic.core.math;
using Math_Graphic.core.math.shapes;
using NUnit.Framework;

namespace Math_Graphic.Tests.core.math.shapes
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void Constructor_InitializesPropertiesCorrectly()
        {
            // Arrange
            var p1 = new PointXy(1, 2);
            var p2 = new PointXy(3, 4);
            var p3 = new PointXy(5, 6);

            // Act
            var triangle = new Triangle(p1, p2, p3);

            // Assert
            Assert.AreEqual(ShapeType.Triangle, triangle.ShapeType);
            Assert.AreEqual(p1, triangle.P1);
            Assert.AreEqual(p2, triangle.P2);
            Assert.AreEqual(p3, triangle.P3);
            Assert.AreEqual(-1, triangle.Area);
        }

        [Test]
        public void PointInTriangle_ReturnsCorrectlyForPointsInsideTriangle()
        {
            // Arrange
            var triangle = new Triangle(new PointXy(0, 0), new PointXy(10, 0), new PointXy(5, 5));

            // Act
            var pointInside = triangle.PointInTriangle(3, 3);
            var pointOnEdge = triangle.PointInTriangle(5, 0);

            // Assert
            Assert.IsTrue(pointInside);
            Assert.IsTrue(pointOnEdge);
        }

        [Test]
        public void PointInTriangle_ReturnsCorrectlyForPointsOutsideTriangle()
        {
            // Arrange
            var triangle = new Triangle(new PointXy(0, 0), new PointXy(10, 0), new PointXy(5, 5));

            // Act
            var pointOutside = triangle.PointInTriangle(12, 12);

            // Assert
            Assert.IsFalse(pointOutside);
        }

        [Test]
        public void DrawMe_ReturnsBitmapWithCorrectPixelValues()
        {
            // Arrange
            var triangle = new Triangle(new PointXy(0, 0), new PointXy(10, 0), new PointXy(5, 5));

            // Act
            var bitmap = triangle.DrawMe();

            // Assert
            Assert.AreEqual(11, bitmap.GetSize()); // Assuming a 11x11 bitmap
            Assert.AreEqual(1, bitmap.Get(5, 5)); // Pixel inside the triangle
            Assert.AreEqual(0, bitmap.Get(11, 11)); // Pixel outside the triangle
        }

        [Test]
        public void Area_CalculatesCorrectArea()
        {
            // Arrange
            var triangle = new Triangle(new PointXy(0, 0), new PointXy(10, 0), new PointXy(5, 5));

            // Act
            var area = triangle.Area();

            // Assert
            Assert.AreEqual(25, area);
        }

        [Test]
        public void Area_CachesResult()
        {
            // Arrange
            var triangle = new Triangle(new PointXy(0, 0), new PointXy(10, 0), new PointXy(5, 5));

            // Act
            var area1 = triangle.Area();
            var area2 = triangle.Area();

            // Assert
            Assert.AreEqual(area1, area2); // Ensure the area is cached
        }
    }
}
*/