using NUnit.Framework;
using Math_Graphic.core.math.shapes;
using Math_Graphic.core.common;

/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 */

namespace Math_Graphic.Tests.GPT35.alsoFirst
{
    [TestFixture]
    public class RectangleTests
    {/* Test odrzucony
        [Test]
        public void Rectangle_Constructor_ShouldInitializePointsCorrectly()
        {
            // Arrange
            var p1 = new PointXy(1, 1);
            var p2 = new PointXy(1, 5);
            var p3 = new PointXy(4, 5);
            var p4 = new PointXy(4, 1);

            // Act
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Assert
            Assert.AreEqual(new PointXy(1, 1), rectangle.Origin());
        }*/

        [Test]
        public void DrawMe_ShouldReturnCorrectBitmap()
        {
            // Arrange
            var p1 = new PointXy(2, 2);
            var p2 = new PointXy(2, 5);
            var p3 = new PointXy(5, 5);
            var p4 = new PointXy(5, 2);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var bitmap = rectangle.DrawMe();
            var array = bitmap.GetArray();

            // Assert
            Assert.AreEqual(1, array[2, 2]);
            Assert.AreEqual(1, array[3, 3]);
            Assert.AreEqual(1, array[4, 4]);
            Assert.AreEqual(0, array[0, 0]); // Ensure outside rectangle is 0
        }
        /* Test odrzucony
        [Test]
        public void Origin_ShouldReturnCorrectOrigin()
        {
            // Arrange
            var p1 = new PointXy(2, 2);
            var p2 = new PointXy(2, 5);
            var p3 = new PointXy(5, 5);
            var p4 = new PointXy(5, 2);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var origin = rectangle.Origin();

            // Assert
            Assert.AreEqual(new PointXy(2, 2), origin);
        }

        [Test]
        public void Area_ShouldReturnCorrectArea()
        {
            // Arrange
            var p1 = new PointXy(2, 2);
            var p2 = new PointXy(2, 5);
            var p3 = new PointXy(5, 5);
            var p4 = new PointXy(5, 2);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var area = rectangle.Area();

            // Assert
            Assert.AreEqual(12, area); // Area is (5-2+1) * (5-2+1) = 12
        }*/
    }
}

/*
using NUnit.Framework;
using Math_Graphic.core.math.shapes;
using Math_Graphic.core.common;

namespace Math_Graphic.Tests
{
    [TestFixture]
    public class RectangleTests
    {
        [Test]
        public void Rectangle_Constructor_ShouldInitializePointsCorrectly()
        {
            // Arrange
            var p1 = new PointXy(1, 1);
            var p2 = new PointXy(1, 5);
            var p3 = new PointXy(4, 5);
            var p4 = new PointXy(4, 1);

            // Act
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Assert
            Assert.AreEqual(new PointXy(1, 1), rectangle.Origin());
        }

        [Test]
        public void DrawMe_ShouldReturnCorrectBitmap()
        {
            // Arrange
            var p1 = new PointXy(2, 2);
            var p2 = new PointXy(2, 5);
            var p3 = new PointXy(5, 5);
            var p4 = new PointXy(5, 2);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var bitmap = rectangle.DrawMe();
            var array = bitmap.GetArray();

            // Assert
            Assert.AreEqual(1, array[2, 2]);
            Assert.AreEqual(1, array[3, 3]);
            Assert.AreEqual(1, array[4, 4]);
            Assert.AreEqual(0, array[0, 0]); // Ensure outside rectangle is 0
        }

        [Test]
        public void Origin_ShouldReturnCorrectOrigin()
        {
            // Arrange
            var p1 = new PointXy(2, 2);
            var p2 = new PointXy(2, 5);
            var p3 = new PointXy(5, 5);
            var p4 = new PointXy(5, 2);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var origin = rectangle.Origin();

            // Assert
            Assert.AreEqual(new PointXy(2, 2), origin);
        }

        [Test]
        public void Area_ShouldReturnCorrectArea()
        {
            // Arrange
            var p1 = new PointXy(2, 2);
            var p2 = new PointXy(2, 5);
            var p3 = new PointXy(5, 5);
            var p4 = new PointXy(5, 2);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var area = rectangle.Area();

            // Assert
            Assert.AreEqual(12, area); // Area is (5-2+1) * (5-2+1) = 12
        }
    }
}
*/