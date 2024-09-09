using NUnit.Framework;
using Math_Graphic.core.math.shapes;
using Math_Graphic.core.common;
using System;


/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 */

namespace Math_Graphic.Tests.GPT4.alsoWithContext
{
    [TestFixture]
    public class RectangleTests
    {
        [Test]
        public void Constructor_WithValidPoints_ShouldSetPropertiesCorrectly()
        {
            // Arrange
            var p1 = new PointXy(1, 1);
            var p2 = new PointXy(1, 4);
            var p3 = new PointXy(5, 4);
            var p4 = new PointXy(5, 1);

            // Act
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Assert
            Assert.AreEqual(1, rectangle.Origin().X);
            Assert.AreEqual(1, rectangle.Origin().Y);
            Assert.AreEqual(5 * 4, rectangle.Area());
        }
        /* Test odrzucony
        [Test]
        public void DrawMe_ShouldProduceCorrectBitmapSize()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(0, 3);
            var p3 = new PointXy(4, 3);
            var p4 = new PointXy(4, 0);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var bitmap = rectangle.DrawMe();

            // Assert
            Assert.AreEqual(1, bitmap.Get(0, 0));
            Assert.AreEqual(1, bitmap.Get(4, 3));
            Assert.AreEqual(0, bitmap.Get(5, 4));
            Assert.AreEqual(20, bitmap.GetSize());
        }*/

        [Test]
        public void Area_WithValidCoordinates_ShouldCalculateCorrectly()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(0, 3);
            var p3 = new PointXy(4, 3);
            var p4 = new PointXy(4, 0);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var area = rectangle.Area();

            // Assert
            Assert.AreEqual(20, area);
        }

        [Test]
        public void Constructor_WithPointsInRandomOrder_ShouldStillIdentifyCorrectCoordinates()
        {
            // Arrange
            var p1 = new PointXy(5, 4);
            var p2 = new PointXy(1, 4);
            var p3 = new PointXy(5, 1);
            var p4 = new PointXy(1, 1);

            // Act
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Assert
            Assert.AreEqual(1, rectangle.Origin().X);
            Assert.AreEqual(1, rectangle.Origin().Y);
            Assert.AreEqual(5 * 4, rectangle.Area());
        }
    }
}

/*
using NUnit.Framework;
using Math_Graphic.core.math.shapes;
using Math_Graphic.core.common;
using System;

namespace Math_Graphic.Tests
{
    [TestFixture]
    public class RectangleTests
    {
        [Test]
        public void Constructor_WithValidPoints_ShouldSetPropertiesCorrectly()
        {
            // Arrange
            var p1 = new PointXy(1, 1);
            var p2 = new PointXy(1, 4);
            var p3 = new PointXy(5, 4);
            var p4 = new PointXy(5, 1);

            // Act
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Assert
            Assert.AreEqual(1, rectangle.Origin().X);
            Assert.AreEqual(1, rectangle.Origin().Y);
            Assert.AreEqual(5 * 4, rectangle.Area());
        }

        [Test]
        public void DrawMe_ShouldProduceCorrectBitmapSize()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(0, 3);
            var p3 = new PointXy(4, 3);
            var p4 = new PointXy(4, 0);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var bitmap = rectangle.DrawMe();

            // Assert
            Assert.AreEqual(1, bitmap.Get(0, 0));
            Assert.AreEqual(1, bitmap.Get(4, 3));
            Assert.AreEqual(0, bitmap.Get(5, 4));
            Assert.AreEqual(20, bitmap.GetSize());
        }

        [Test]
        public void Area_WithValidCoordinates_ShouldCalculateCorrectly()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(0, 3);
            var p3 = new PointXy(4, 3);
            var p4 = new PointXy(4, 0);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var area = rectangle.Area();

            // Assert
            Assert.AreEqual(20, area);
        }

        [Test]
        public void Constructor_WithPointsInRandomOrder_ShouldStillIdentifyCorrectCoordinates()
        {
            // Arrange
            var p1 = new PointXy(5, 4);
            var p2 = new PointXy(1, 4);
            var p3 = new PointXy(5, 1);
            var p4 = new PointXy(1, 1);

            // Act
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Assert
            Assert.AreEqual(1, rectangle.Origin().X);
            Assert.AreEqual(1, rectangle.Origin().Y);
            Assert.AreEqual(5 * 4, rectangle.Area());
        }
    }
}

*/