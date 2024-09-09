using Math_Graphic.core.math.shapes;
using Math_Graphic.core.common;


/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 * testy nie zostały napisane we frameworku NUnit
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 */

namespace Math_Graphic.Tests.GPT35.alsoWithContext
{
    public class TriangleTests
    {
        /* Test odrzucony
        [Test]
        public void DrawMe_ShouldReturnBitmapWithCorrectArea()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(5, 0);
            var p3 = new PointXy(0, 5);
            var triangle = new Triangle(p1, p2, p3);

            // Act
            var bitmap = triangle.DrawMe();

            // Assert
            var array = bitmap.GetArray();
            int expectedArea = 6; // The area of a right-angled triangle with legs of length 5 is (5*5)/2 = 12/2 = 6
            Assert.Equals(expectedArea, triangle.Area());
        }

        [Test]
        public void Area_ShouldReturnCorrectValueAfterDrawMe()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(4, 0);
            var p3 = new PointXy(0, 3);
            var triangle = new Triangle(p1, p2, p3);

            // Act
            var area = triangle.Area();

            // Assert
            Assert.Equals(6, area); // Area of triangle with base 4 and height 3 is 6
        }*/
    }
}

/*
using Xunit;
using Math_Graphic.core.math.shapes;
using Math_Graphic.core.common;

namespace Math_Graphic.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void PointInTriangle_ShouldReturnTrue_WhenPointIsInsideTriangle()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(5, 0);
            var p3 = new PointXy(0, 5);
            var triangle = new Triangle(p1, p2, p3);

            // Act
            var result = triangle.PointInTriangle(1, 1);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void PointInTriangle_ShouldReturnTrue_WhenPointIsOnEdgeOfTriangle()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(5, 0);
            var p3 = new PointXy(0, 5);
            var triangle = new Triangle(p1, p2, p3);

            // Act
            var result = triangle.PointInTriangle(0, 0); // Point on the edge

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void PointInTriangle_ShouldReturnFalse_WhenPointIsOutsideTriangle()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(5, 0);
            var p3 = new PointXy(0, 5);
            var triangle = new Triangle(p1, p2, p3);

            // Act
            var result = triangle.PointInTriangle(6, 6);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void DrawMe_ShouldReturnBitmapWithCorrectArea()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(5, 0);
            var p3 = new PointXy(0, 5);
            var triangle = new Triangle(p1, p2, p3);

            // Act
            var bitmap = triangle.DrawMe();

            // Assert
            var array = bitmap.GetArray();
            int expectedArea = 6; // The area of a right-angled triangle with legs of length 5 is (5*5)/2 = 12/2 = 6
            Assert.Equal(expectedArea, triangle.Area());
        }

        [Fact]
        public void Area_ShouldReturnCorrectValueAfterDrawMe()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(4, 0);
            var p3 = new PointXy(0, 3);
            var triangle = new Triangle(p1, p2, p3);

            // Act
            var area = triangle.Area();

            // Assert
            Assert.Equal(6, area); // Area of triangle with base 4 and height 3 is 6
        }
    }
}
*/