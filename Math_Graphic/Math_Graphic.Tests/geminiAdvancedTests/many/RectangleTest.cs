using Math_Graphic.core.common;
using Math_Graphic.core.math.shapes;
using NUnit.Framework;

/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 */

namespace Math_Graphic.Tests.geminiAdvanced.alsoWithContext
{
    [TestFixture]
    public class RectangleTests
    {
        /* Test odrzucony
        [Test]
        public void DrawMe_CreatesCorrectBitmap()
        {
            // Arrange
            var p1 = new PointXy(2, 1);
            var p2 = new PointXy(2, 5);
            var p3 = new PointXy(6, 5);
            var p4 = new PointXy(6, 1);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var bitmap = rectangle.DrawMe();

            // Assert
            // Sprawdź, czy rozmiar bitmapy jest poprawny
            Assert.AreEqual(1000, bitmap.GetSize());

            // Sprawdź, czy piksele wewnątrz prostokąta są ustawione na 1
            for (int i = 2; i <= 6; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Assert.AreEqual(1, bitmap.Get(i, j));
                }
            }

            // Sprawdź, czy piksele poza prostokątem są ustawione na 0 (domyślnie)
            Assert.AreEqual(0, bitmap.Get(1, 1));
            Assert.AreEqual(0, bitmap.Get(7, 5));
        }*/

        [Test]
        public void Origin_ReturnsCorrectPoint()
        {
            // Arrange
            var p1 = new PointXy(2, 3);
            var p2 = new PointXy(5, 1);
            var p3 = new PointXy(8, 7);
            var p4 = new PointXy(0, 4);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var origin = rectangle.Origin();

            // Assert
            Assert.AreEqual(0, origin.X);
            Assert.AreEqual(1, origin.Y);
        }
        /* Test odrzucony
        [Test]
        public void Area_CalculatesCorrectly()
        {
            // Arrange
            var p1 = new PointXy(1, 2);
            var p2 = new PointXy(1, 6);
            var p3 = new PointXy(5, 6);
            var p4 = new PointXy(5, 2);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var area = rectangle.Area();

            // Assert
            Assert.AreEqual(20, area); // (5 - 1 + 1) * (6 - 2 + 1) = 20
        }*/

    }
}

/*
using Math_Graphic.core.common;
using Math_Graphic.core.math.shapes;
using NUnit.Framework;

namespace Math_Graphic.core.Tests
{
    [TestFixture]
    public class RectangleTests
    {
        [Test]
        public void Constructor_OrdersPointsCorrectly()
        {
            // Arrange
            var p1 = new PointXy(3, 2);
            var p2 = new PointXy(1, 4);
            var p3 = new PointXy(5, 6);
            var p4 = new PointXy(7, 0);

            // Act
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Assert
            Assert.AreEqual(1, rectangle._p1.X);
            Assert.AreEqual(0, rectangle._p1.Y);
            Assert.AreEqual(7, rectangle._p2.X);
            Assert.AreEqual(0, rectangle._p2.Y);
            Assert.AreEqual(7, rectangle._p3.X);
            Assert.AreEqual(6, rectangle._p3.Y);
            Assert.AreEqual(1, rectangle._p4.X);
            Assert.AreEqual(6, rectangle._p4.Y);
        }

        [Test]
        public void DrawMe_CreatesCorrectBitmap()
        {
            // Arrange
            var p1 = new PointXy(2, 1);
            var p2 = new PointXy(2, 5);
            var p3 = new PointXy(6, 5);
            var p4 = new PointXy(6, 1);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var bitmap = rectangle.DrawMe();

            // Assert
            // Sprawdź, czy rozmiar bitmapy jest poprawny
            Assert.AreEqual(1000, bitmap.GetSize());

            // Sprawdź, czy piksele wewnątrz prostokąta są ustawione na 1
            for (int i = 2; i <= 6; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Assert.AreEqual(1, bitmap.Get(i, j));
                }
            }

            // Sprawdź, czy piksele poza prostokątem są ustawione na 0 (domyślnie)
            Assert.AreEqual(0, bitmap.Get(1, 1));
            Assert.AreEqual(0, bitmap.Get(7, 5));
        }

        [Test]
        public void Origin_ReturnsCorrectPoint()
        {
            // Arrange
            var p1 = new PointXy(2, 3);
            var p2 = new PointXy(5, 1);
            var p3 = new PointXy(8, 7);
            var p4 = new PointXy(0, 4);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var origin = rectangle.Origin();

            // Assert
            Assert.AreEqual(0, origin.X);
            Assert.AreEqual(1, origin.Y);
        }

        [Test]
        public void Area_CalculatesCorrectly()
        {
            // Arrange
            var p1 = new PointXy(1, 2);
            var p2 = new PointXy(1, 6);
            var p3 = new PointXy(5, 6);
            var p4 = new PointXy(5, 2);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var area = rectangle.Area();

            // Assert
            Assert.AreEqual(20, area); // (5 - 1 + 1) * (6 - 2 + 1) = 20
        }

    }
}
*/