using Math_Graphic.core.math.shapes;

/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 * testy nie zostały napisane we frameworku NUnit
 */

namespace Math_Graphic.Tests.gemini.first
{
    public class TriangleTests
    {

        /* Test odrzucony
        [Test]
        public void DrawMe_ReturnsBitmapWithCorrectPixelValues()
        {
            // Arrange
            var triangle = new Triangle(new PointXy(0, 0), new PointXy(10, 0), new PointXy(5, 10));

            // Act
            var bitmap = triangle.DrawMe();

            // Assert
            Assert.NotNull(bitmap);
            Assert.Equals(1000, bitmap.GetSize());

            // Check pixel values within the triangle
            Assert.Equals(1, bitmap.Get(5, 5));
            Assert.Equals(1, bitmap.Get(0, 0));
            Assert.Equals(1, bitmap.Get(10, 0));
            Assert.Equals(1, bitmap.Get(5, 10));

            // Check pixel values outside the triangle
            Assert.Equals(0, bitmap.Get(12, 12));
            Assert.Equals(0, bitmap.Get(-2, -2));
        }

        [Test]
        public void Area_ReturnsCorrectArea()
        {
            // Arrange
            var triangle = new Triangle(new PointXy(0, 0), new PointXy(10, 0), new PointXy(5, 10));

            // Act
            var area = triangle.Area();

            // Assert
            Assert.Equals(50, area);
        }

        [Test]
        public void Origin_ReturnsCorrectOrigin()
        {
            // Arrange
            var triangle = new Triangle(new PointXy(1, 2), new PointXy(3, 4), new PointXy(5, 6));

            // Act
            var origin = triangle.Origin();

            // Assert
            Assert.Equals(new PointXy(1, 2), origin);
        }*/
    }
}

/*
using Math_Graphic.core.math.shapes;
using Xunit;

namespace Math_Graphic.core.math.shapes.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void Constructor_CreatesTriangleWithCorrectPoints()
        {
            // Arrange
            var p1 = new PointXy(1, 2);
            var p2 = new PointXy(3, 4);
            var p3 = new PointXy(5, 6);

            // Act
            var triangle = new Triangle(p1, p2, p3);

            // Assert
            Assert.Equal(p1, triangle._p1);
            Assert.Equal(p2, triangle._p2);
            Assert.Equal(p3, triangle._p3);
            Assert.Equal(ShapeType.Triangle, triangle.ShapeType);
        }

        [Fact]
        public void PointInTriangle_ReturnsTrueForPointsInsideTriangle()
        {
            // Arrange
            var triangle = new Triangle(new PointXy(0, 0), new PointXy(10, 0), new PointXy(5, 10));

            // Act
            var isInside = triangle.PointInTriangle(5, 5);

            // Assert
            Assert.True(isInside);
        }

        [Fact]
        public void PointInTriangle_ReturnsFalseForPointsOutsideTriangle()
        {
            // Arrange
            var triangle = new Triangle(new PointXy(0, 0), new PointXy(10, 0), new PointXy(5, 10));

            // Act
            var isInside = triangle.PointInTriangle(12, 12);

            // Assert
            Assert.False(isInside);
        }

        [Fact]
        public void DrawMe_ReturnsBitmapWithCorrectPixelValues()
        {
            // Arrange
            var triangle = new Triangle(new PointXy(0, 0), new PointXy(10, 0), new PointXy(5, 10));

            // Act
            var bitmap = triangle.DrawMe();

            // Assert
            Assert.NotNull(bitmap);
            Assert.Equal(1000, bitmap.GetSize());

            // Check pixel values within the triangle
            Assert.Equal(1, bitmap.Get(5, 5));
            Assert.Equal(1, bitmap.Get(0, 0));
            Assert.Equal(1, bitmap.Get(10, 0));
            Assert.Equal(1, bitmap.Get(5, 10));

            // Check pixel values outside the triangle
            Assert.Equal(0, bitmap.Get(12, 12));
            Assert.Equal(0, bitmap.Get(-2, -2));
        }

        [Fact]
        public void Area_ReturnsCorrectArea()
        {
            // Arrange
            var triangle = new Triangle(new PointXy(0, 0), new PointXy(10, 0), new PointXy(5, 10));

            // Act
            var area = triangle.Area();

            // Assert
            Assert.Equal(50, area);
        }

        [Fact]
        public void Origin_ReturnsCorrectOrigin()
        {
            // Arrange
            var triangle = new Triangle(new PointXy(1, 2), new PointXy(3, 4), new PointXy(5, 6));

            // Act
            var origin = triangle.Origin();

            // Assert
            Assert.Equal(new PointXy(1, 2), origin);
        }
    }
}
*/