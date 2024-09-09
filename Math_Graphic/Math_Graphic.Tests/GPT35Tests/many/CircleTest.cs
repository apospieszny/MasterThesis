using Math_Graphic.core.math.shapes;
using Math_Graphic.core.common;
using Math_Graphic.core.math;

/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * testy nie zostały napisane we frameworku NUnit
 */

namespace Math_Graphic.Tests.GPT35.alsoWithContext
{
    public class CircleTests
    {/* Test odrzucony
        [Test]
        public void Circle_Should_Initialize_Correctly()
        {
            // Arrange
            var center = new PointXy(5, 5);
            var radius = 3;

            // Act
            var circle = new Circle(center, radius);

            // Assert
            Assert.NotNull(circle);
            Assert.Equals(ShapeType.Circle, circle.ShapeType);
        }

        [Test]
        public void Circle_Should_Calculate_Area_Correctly()
        {
            // Arrange
            var center = new PointXy(0, 0);
            var radius = 5;
            var circle = new Circle(center, radius);

            // Act
            var area = circle.Area();

            // Assert
            Assert.True(area > 0); // Area should be greater than 0
            Assert.Equals(circle.Area(), area); // Calling Area again should return the same value
        }

        [Test]
        public void Circle_Should_Draw_Correct_Bitmap_Size()
        {
            // Arrange
            var center = new PointXy(10, 10);
            var radius = 5;
            var circle = new Circle(center, radius);

            // Act
            var bitmap = circle.DrawMe();

            // Assert
            Assert.NotNull(bitmap);
            Assert.Equals(1000 * 1000, bitmap.GetSize()); // Bitmap should be of size 1000x1000
        }

        [Test]
        public void Circle_Should_Draw_Correct_Number_Of_Pixels()
        {
            // Arrange
            var center = new PointXy(0, 0);
            var radius = 1;
            var circle = new Circle(center, radius);

            // Act
            var bitmap = circle.DrawMe();
            var array = bitmap.GetArray();

            // Assert
            Assert.Equals(5, circle.Area()); // For a circle with radius 1, the area should be 5 pixels (a rough approximation)
        }

        [Test]
        public void Circle_Should_Calculate_Origin_Correctly()
        {
            // Arrange
            var center = new PointXy(10, 10);
            var radius = 3;
            var circle = new Circle(center, radius);

            // Act
            var origin = circle.Origin();

            // Assert
            Assert.Equals(7, origin.X); // Origin X should be center.X - radius
            Assert.Equals(7, origin.Y); // Origin Y should be center.Y - radius
        }

        [Test]
        public void Circle_Should_Handle_Zero_Radius()
        {
            // Arrange
            var center = new PointXy(5, 5);
            var radius = 0;
            var circle = new Circle(center, radius);

            // Act
            var area = circle.Area();

            // Assert
            Assert.Equals(1, area); // For radius 0, the area should be 1 (just the center pixel)
        }*/

        [Test]
        public void Circle_Should_Handle_Large_Radius()
        {
            // Arrange
            var center = new PointXy(500, 500);
            var radius = 499;
            var circle = new Circle(center, radius);

            // Act
            var area = circle.Area();

            // Assert
            Assert.True(area > 0); // Large circles should have large areas
        }
    }
}

/*
Wygenerowany kod:

using Math_Graphic.core.math.shapes;
using Math_Graphic.core.common;
using Xunit;

namespace Math_Graphic.Tests
{
    public class CircleTests
    {
        [Fact]
        public void Circle_Should_Initialize_Correctly()
        {
            // Arrange
            var center = new PointXy(5, 5);
            var radius = 3;

            // Act
            var circle = new Circle(center, radius);

            // Assert
            Assert.NotNull(circle);
            Assert.Equal(ShapeType.Circle, circle.ShapeType);
        }

        [Fact]
        public void Circle_Should_Calculate_Area_Correctly()
        {
            // Arrange
            var center = new PointXy(0, 0);
            var radius = 5;
            var circle = new Circle(center, radius);

            // Act
            var area = circle.Area();

            // Assert
            Assert.True(area > 0); // Area should be greater than 0
            Assert.Equal(circle.Area(), area); // Calling Area again should return the same value
        }

        [Fact]
        public void Circle_Should_Draw_Correct_Bitmap_Size()
        {
            // Arrange
            var center = new PointXy(10, 10);
            var radius = 5;
            var circle = new Circle(center, radius);

            // Act
            var bitmap = circle.DrawMe();

            // Assert
            Assert.NotNull(bitmap);
            Assert.Equal(1000 * 1000, bitmap.GetSize()); // Bitmap should be of size 1000x1000
        }

        [Fact]
        public void Circle_Should_Draw_Correct_Number_Of_Pixels()
        {
            // Arrange
            var center = new PointXy(0, 0);
            var radius = 1;
            var circle = new Circle(center, radius);

            // Act
            var bitmap = circle.DrawMe();
            var array = bitmap.GetArray();

            // Assert
            Assert.Equal(5, circle.Area()); // For a circle with radius 1, the area should be 5 pixels (a rough approximation)
        }

        [Fact]
        public void Circle_Should_Calculate_Origin_Correctly()
        {
            // Arrange
            var center = new PointXy(10, 10);
            var radius = 3;
            var circle = new Circle(center, radius);

            // Act
            var origin = circle.Origin();

            // Assert
            Assert.Equal(7, origin.X); // Origin X should be center.X - radius
            Assert.Equal(7, origin.Y); // Origin Y should be center.Y - radius
        }

        [Fact]
        public void Circle_Should_Handle_Zero_Radius()
        {
            // Arrange
            var center = new PointXy(5, 5);
            var radius = 0;
            var circle = new Circle(center, radius);

            // Act
            var area = circle.Area();

            // Assert
            Assert.Equal(1, area); // For radius 0, the area should be 1 (just the center pixel)
        }

        [Fact]
        public void Circle_Should_Handle_Large_Radius()
        {
            // Arrange
            var center = new PointXy(500, 500);
            var radius = 499;
            var circle = new Circle(center, radius);

            // Act
            var area = circle.Area();

            // Assert
            Assert.True(area > 0); // Large circles should have large areas
        }
    }
}
*/