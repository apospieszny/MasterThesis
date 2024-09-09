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
    public class RectangleTests
    {
        [Test]
        public void Constructor_OrdersPointsCorrectly()
        {
            // Arrange
            var p1 = new PointXy(3, 5);
            var p2 = new PointXy(1, 2);
            var p3 = new PointXy(7, 8);
            var p4 = new PointXy(4, 6);

            // Act
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Assert
            Assert.AreEqual(1, rectangle.Origin().X);
            Assert.AreEqual(2, rectangle.Origin().Y);
        }
        /* Test odrzucony
        [Test]
        public void DrawMe_CreatesBitmapWithCorrectDimensions()
        {
            // Arrange
            var p1 = new PointXy(2, 3);
            var p2 = new PointXy(2, 7);
            var p3 = new PointXy(6, 7);
            var p4 = new PointXy(6, 3);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var bitmap = rectangle.DrawMe();

            // Assert
            Assert.AreEqual(1000, bitmap.GetSize()); // Zakładając, że Bitmap ma stały rozmiar 1000x1000
            for (var i = 0; i <= 4; i++)
            {
                for (var j = 0; j <= 4; j++)
                {
                    Assert.AreEqual(1, bitmap.Get(2 + i, 3 + j));
                }
            }
        }*/

        [Test]
        public void Area_CalculatesCorrectly()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(0, 5);
            var p3 = new PointXy(3, 5);
            var p4 = new PointXy(3, 0);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var area = rectangle.Area();

            // Assert
            Assert.AreEqual(4 * 6, area);
        }

        [Test]
        public void ShapeType_IsSetCorrectly()
        {
            // Arrange & Act
            var rectangle = new Rectangle(new PointXy(), new PointXy(), new PointXy(), new PointXy());

            // Assert
            Assert.AreEqual(ShapeType.Rectangle, rectangle.ShapeType);
        }
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
    public class RectangleTests
    {
        [Test]
        public void Constructor_OrdersPointsCorrectly()
        {
            // Arrange
            var p1 = new PointXy(3, 5);
            var p2 = new PointXy(1, 2);
            var p3 = new PointXy(7, 8);
            var p4 = new PointXy(4, 6);

            // Act
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Assert
            Assert.AreEqual(1, rectangle.Origin().X);
            Assert.AreEqual(2, rectangle.Origin().Y);
            Assert.AreEqual(7, rectangle._p3.X);
            Assert.AreEqual(8, rectangle._p3.Y);
        }

        [Test]
        public void DrawMe_CreatesBitmapWithCorrectDimensions()
        {
            // Arrange
            var p1 = new PointXy(2, 3);
            var p2 = new PointXy(2, 7);
            var p3 = new PointXy(6, 7);
            var p4 = new PointXy(6, 3);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var bitmap = rectangle.DrawMe();

            // Assert
            Assert.AreEqual(1000, bitmap.GetSize()); // Zakładając, że Bitmap ma stały rozmiar 1000x1000
            for (var i = 0; i <= 4; i++)
            {
                for (var j = 0; j <= 4; j++)
                {
                    Assert.AreEqual(1, bitmap.Get(2 + i, 3 + j));
                }
            }
        }

        [Test]
        public void Area_CalculatesCorrectly()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(0, 5);
            var p3 = new PointXy(3, 5);
            var p4 = new PointXy(3, 0);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var area = rectangle.Area();

            // Assert
            Assert.AreEqual(4 * 6, area);
        }

        [Test]
        public void ShapeType_IsSetCorrectly()
        {
            // Arrange & Act
            var rectangle = new Rectangle(new PointXy(), new PointXy(), new PointXy(), new PointXy());

            // Assert
            Assert.AreEqual(ShapeType.Rectangle, rectangle.ShapeType);
        }
    }
}
*/