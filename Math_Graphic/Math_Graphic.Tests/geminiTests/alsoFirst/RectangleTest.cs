using NUnit.Framework;
using Math_Graphic.core.math;
using Math_Graphic.core.math.shapes;

/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 */

namespace Math_Graphic.Tests.gemini.alsoFirst
{
    [TestFixture]
    public class RectangleTests
    {
        [Test]
        public void Constructor_ValidInput_CreatesRectangle()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(5, 0);
            var p3 = new PointXy(5, 3);
            var p4 = new PointXy(0, 3);

            // Act
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Assert
            Assert.AreEqual(ShapeType.Rectangle, rectangle.ShapeType);
        }
        /* Test odrzucony
        [Test]
        public void DrawMe_ValidRectangle_ReturnsBitmap()
        {
            // Arrange
            var rectangle = new Rectangle(new PointXy(0, 0), new PointXy(5, 0), new PointXy(5, 3), new PointXy(0, 3));

            // Act
            var bitmap = rectangle.DrawMe();

            // Assert
            Assert.NotNull(bitmap);
            Assert.AreEqual(1000, bitmap.GetSize());
            Assert.AreEqual(1, bitmap.Get(0, 0));
            Assert.AreEqual(0, bitmap.Get(6, 0));
        }

        [Test]
        public void Origin_ValidRectangle_ReturnsTopLeftPoint()
        {
            // Arrange
            var rectangle = new Rectangle(new PointXy(2, 3), new PointXy(7, 3), new PointXy(7, 8), new PointXy(2, 8));

            // Act
            var origin = rectangle.Origin();

            // Assert
            Assert.AreEqual(new PointXy(2, 3), origin);
        }

        [Test]
        public void Area_ValidRectangle_ReturnsCorrectArea()
        {
            // Arrange
            var rectangle = new Rectangle(new PointXy(0, 0), new PointXy(4, 0), new PointXy(4, 3), new PointXy(0, 3));

            // Act
            var area = rectangle.Area();

            // Assert
            Assert.AreEqual(12, area);
        }
        */
    }
}

/*
using NUnit.Framework;

namespace Math_Graphic.core.math.shapes.Tests
{
    [TestFixture]
    public class RectangleTests
    {
        [Test]
        public void Constructor_ValidInput_CreatesRectangle()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(5, 0);
            var p3 = new PointXy(5, 3);
            var p4 = new PointXy(0, 3);

            // Act
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Assert
            Assert.AreEqual(ShapeType.Rectangle, rectangle.ShapeType);
            Assert.AreEqual(p1, rectangle._p1);
            Assert.AreEqual(p2, rectangle._p2);
            Assert.AreEqual(p3, rectangle._p3);
            Assert.AreEqual(p4, rectangle._p4);
        }

        // ... (add more tests for different scenarios)

        [Test]
        public void DrawMe_ValidRectangle_ReturnsBitmap()
        {
            // Arrange
            var rectangle = new Rectangle(new PointXy(0, 0), new PointXy(5, 0), new PointXy(5, 3), new PointXy(0, 3));

            // Act
            var bitmap = rectangle.DrawMe();

            // Assert
            Assert.NotNull(bitmap);
            Assert.AreEqual(1000, bitmap.GetSize());
            Assert.AreEqual(1, bitmap.Get(0, 0));
            Assert.AreEqual(0, bitmap.Get(6, 0));
        }

        // ... (add more tests for different scenarios)

        [Test]
        public void Origin_ValidRectangle_ReturnsTopLeftPoint()
        {
            // Arrange
            var rectangle = new Rectangle(new PointXy(2, 3), new PointXy(7, 3), new PointXy(7, 8), new PointXy(2, 8));

            // Act
            var origin = rectangle.Origin();

            // Assert
            Assert.AreEqual(new PointXy(2, 3), origin);
        }

        // ... (add more tests for different scenarios)

        [Test]
        public void Area_ValidRectangle_ReturnsCorrectArea()
        {
            // Arrange
            var rectangle = new Rectangle(new PointXy(0, 0), new PointXy(4, 0), new PointXy(4, 3), new PointXy(0, 3));

            // Act
            var area = rectangle.Area();

            // Assert
            Assert.AreEqual(12, area);
        }

        // ... (add more tests for different scenarios)
    }
}
*/