using Math_Graphic.core.common;
using Math_Graphic.core.math.shapes;
using NUnit.Framework;

/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 */

namespace Math_Graphic.Tests.gemini.first
{
    [TestFixture]
    public class RectangleTests
    {/* Test odrzucony
        [Test]
        public void Constructor_ValidPoints_CreatesCorrectRectangle()
        {
            // Arrange
            var p1 = new PointXy(1, 2);
            var p2 = new PointXy(5, 2);
            var p3 = new PointXy(5, 6);
            var p4 = new PointXy(1, 6);

            // Act
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Assert
            Assert.AreEqual(p1, rectangle.Origin());
        }

        [Test]
        public void Constructor_InvalidPoints_ThrowsArgumentException()
        {
            // Arrange
            var p1 = new PointXy(1, 2);
            var p2 = new PointXy(5, 2);
            var p3 = new PointXy(5, 6);
            var p4 = new PointXy(3, 4); // Non-rectangular points

            // Act
            Assert.Throws<ArgumentException>(() => new Rectangle(p1, p2, p3, p4));
        }

        [Test]
        public void DrawMe_ValidRectangle_ReturnsCorrectBitmap()
        {
            // Arrange
            var p1 = new PointXy(1, 2);
            var p2 = new PointXy(5, 2);
            var p3 = new PointXy(5, 6);
            var p4 = new PointXy(1, 6);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var bitmap = rectangle.DrawMe();

            // Assert
            Assert.AreEqual(4, bitmap.GetSize());
            Assert.AreEqual(1, bitmap.Get(0, 0));
            Assert.AreEqual(0, bitmap.Get(1, 4)); // Outside the rectangle
        }

        [Test]
        public void Area_ValidRectangle_ReturnsCorrectArea()
        {
            // Arrange
            var p1 = new PointXy(1, 2);
            var p2 = new PointXy(5, 2);
            var p3 = new PointXy(5, 6);
            var p4 = new PointXy(1, 6);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var area = rectangle.Area();

            // Assert
            Assert.AreEqual(12, area);
        }*/
    }
}

/*
using Math_Graphic.core.common;
using Math_Graphic.core.math.shapes;
using NUnit.Framework;

namespace Math_Graphic.core.math.shapes.Tests
{
    [TestFixture]
    public class RectangleTests
    {
        [Test]
        public void Constructor_ValidPoints_CreatesCorrectRectangle()
        {
            // Arrange
            var p1 = new PointXy(1, 2);
            var p2 = new PointXy(5, 2);
            var p3 = new PointXy(5, 6);
            var p4 = new PointXy(1, 6);

            // Act
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Assert
            Assert.AreEqual(ShapeType.Rectangle, rectangle.ShapeType);
            Assert.AreEqual(p1, rectangle.Origin());
            Assert.AreEqual(3, rectangle.Width);
            Assert.AreEqual(4, rectangle.Height);
        }

        [Test]
        public void Constructor_InvalidPoints_ThrowsArgumentException()
        {
            // Arrange
            var p1 = new PointXy(1, 2);
            var p2 = new PointXy(5, 2);
            var p3 = new PointXy(5, 6);
            var p4 = new PointXy(3, 4); // Non-rectangular points

            // Act
            Assert.Throws<ArgumentException>(() => new Rectangle(p1, p2, p3, p4));
        }

        [Test]
        public void DrawMe_ValidRectangle_ReturnsCorrectBitmap()
        {
            // Arrange
            var p1 = new PointXy(1, 2);
            var p2 = new PointXy(5, 2);
            var p3 = new PointXy(5, 6);
            var p4 = new PointXy(1, 6);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var bitmap = rectangle.DrawMe();

            // Assert
            Assert.AreEqual(4, bitmap.GetSize());
            Assert.AreEqual(1, bitmap.Get(0, 0));
            Assert.AreEqual(0, bitmap.Get(1, 4)); // Outside the rectangle
        }

        [Test]
        public void Area_ValidRectangle_ReturnsCorrectArea()
        {
            // Arrange
            var p1 = new PointXy(1, 2);
            var p2 = new PointXy(5, 2);
            var p3 = new PointXy(5, 6);
            var p4 = new PointXy(1, 6);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var area = rectangle.Area();

            // Assert
            Assert.AreEqual(12, area);
        }
    }
}
*/