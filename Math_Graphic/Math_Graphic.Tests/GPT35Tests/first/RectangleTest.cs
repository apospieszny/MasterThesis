using NUnit.Framework;
using Math_Graphic.core.common;
using Math_Graphic.core.math.shapes;

/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 */

namespace Math_Graphic.Tests.GPT35.first
{
    [TestFixture]
    public class RectangleTests
    {
        [Test]
        public void Constructor_InitializesRectangleCorrectly()
        {
            // Arrange
            var p1 = new PointXy(1, 1);
            var p2 = new PointXy(5, 1);
            var p3 = new PointXy(5, 4);
            var p4 = new PointXy(1, 4);

            // Act
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Assert
            Assert.AreEqual(1, rectangle.Origin().X);
            Assert.AreEqual(1, rectangle.Origin().Y);
        }

        [Test]
        public void DrawMe_CreatesCorrectBitmap()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(3, 0);
            var p3 = new PointXy(3, 2);
            var p4 = new PointXy(0, 2);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var bitmap = rectangle.DrawMe();
            var array = bitmap.GetArray();

            // Assert
            Assert.AreEqual(1, array[0, 0]);
            Assert.AreEqual(1, array[1, 0]);
            Assert.AreEqual(1, array[2, 0]);
            Assert.AreEqual(1, array[0, 1]);
            Assert.AreEqual(1, array[1, 1]);
            Assert.AreEqual(1, array[2, 1]);
            Assert.AreEqual(0, array[3, 3]); // Check some out-of-bound index
        }

        [Test]
        public void Origin_ReturnsCorrectPoint()
        {
            // Arrange
            var p1 = new PointXy(3, 4);
            var p2 = new PointXy(7, 4);
            var p3 = new PointXy(7, 9);
            var p4 = new PointXy(3, 9);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var origin = rectangle.Origin();

            // Assert
            Assert.AreEqual(3, origin.X);
            Assert.AreEqual(4, origin.Y);
        }
        /* Test odrzucony
        [Test]
        public void Area_CalculatesCorrectly()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(4, 0);
            var p3 = new PointXy(4, 3);
            var p4 = new PointXy(0, 3);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var area = rectangle.Area();

            // Assert
            Assert.AreEqual(15, area); // (4 * 3) - 1 due to 0-based indexing
        }*/
    }
}

/*
using NUnit.Framework;
using Math_Graphic.core.common;
using Math_Graphic.core.math.shapes;

namespace Math_Graphic.Tests
{
    [TestFixture]
    public class RectangleTests
    {
        [Test]
        public void Constructor_InitializesRectangleCorrectly()
        {
            // Arrange
            var p1 = new PointXy(1, 1);
            var p2 = new PointXy(5, 1);
            var p3 = new PointXy(5, 4);
            var p4 = new PointXy(1, 4);

            // Act
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Assert
            Assert.AreEqual(1, rectangle.Origin().X);
            Assert.AreEqual(1, rectangle.Origin().Y);
        }

        [Test]
        public void DrawMe_CreatesCorrectBitmap()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(3, 0);
            var p3 = new PointXy(3, 2);
            var p4 = new PointXy(0, 2);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var bitmap = rectangle.DrawMe();
            var array = bitmap.GetArray();

            // Assert
            Assert.AreEqual(1, array[0, 0]);
            Assert.AreEqual(1, array[1, 0]);
            Assert.AreEqual(1, array[2, 0]);
            Assert.AreEqual(1, array[0, 1]);
            Assert.AreEqual(1, array[1, 1]);
            Assert.AreEqual(1, array[2, 1]);
            Assert.AreEqual(0, array[3, 3]); // Check some out-of-bound index
        }

        [Test]
        public void Origin_ReturnsCorrectPoint()
        {
            // Arrange
            var p1 = new PointXy(3, 4);
            var p2 = new PointXy(7, 4);
            var p3 = new PointXy(7, 9);
            var p4 = new PointXy(3, 9);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var origin = rectangle.Origin();

            // Assert
            Assert.AreEqual(3, origin.X);
            Assert.AreEqual(4, origin.Y);
        }

        [Test]
        public void Area_CalculatesCorrectly()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(4, 0);
            var p3 = new PointXy(4, 3);
            var p4 = new PointXy(0, 3);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var area = rectangle.Area();

            // Assert
            Assert.AreEqual(15, area); // (4 * 3) - 1 due to 0-based indexing
        }
    }
}
*/