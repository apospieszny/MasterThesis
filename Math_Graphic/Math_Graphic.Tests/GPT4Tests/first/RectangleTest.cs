using Math_Graphic.core.math.shapes;
using Math_Graphic.core.common;

/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 * Dodanie dodatkowej przestrzeni nazw
 * testy nie zostały napisane we frameworku NUnit
 * Testy zostały wygenerowane poza klasą
 * Użycie metody wbudowanej pod złą nazwą
 */

namespace Math_Graphic.Tests.GPT4.first
{
    [TestFixture]
    public class RectangleTest
    {
        /* Test odrzucony
        [Test]
        public void Constructor_InitializesCorrectlyWithOrderedPoints()
        {
            // Arrange
            var p1 = new PointXy(1, 1);
            var p2 = new PointXy(4, 1);
            var p3 = new PointXy(4, 3);
            var p4 = new PointXy(1, 3);

            // Act
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Assert
            Assert.Equals(1, rectangle.Origin().X);
            Assert.Equals(1, rectangle.Origin().Y);
            Assert.Equals(12, rectangle.Area()); // (4-1+1) * (3-1+1) = 12
        }

        [Test]
        public void Constructor_InitializesCorrectlyWithUnorderedPoints()
        {
            // Arrange
            var p1 = new PointXy(4, 3);
            var p2 = new PointXy(1, 3);
            var p3 = new PointXy(1, 1);
            var p4 = new PointXy(4, 1);

            // Act
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Assert
            Assert.Equals(1, rectangle.Origin().X);
            Assert.Equals(1, rectangle.Origin().Y);
            Assert.Equals(12, rectangle.Area());
        }

        [Test]
        public void DrawMe_CreatesCorrectBitmap()
        {
            // Arrange
            var p1 = new PointXy(1, 1);
            var p2 = new PointXy(3, 1);
            var p3 = new PointXy(3, 3);
            var p4 = new PointXy(1, 3);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var bitmap = rectangle.DrawMe();
            var array = bitmap.GetArray();

            // Assert
            for (int i = rectangle.Origin().X; i <= rectangle.Origin().X + 2; i++)
            {
                for (int j = rectangle.Origin().Y; j <= rectangle.Origin().Y + 2; j++)
                {
                    Assert.Equals(1, array[i, j]);
                }
            }
            Assert.Equals(1000 * 1000, bitmap.GetSize()); // Total size of the array
        }

        [Test]
        public void Area_CalculatesCorrectArea()
        {
            // Arrange
            var p1 = new PointXy(0, 0);
            var p2 = new PointXy(10, 0);
            var p3 = new PointXy(10, 5);
            var p4 = new PointXy(0, 5);
            var rectangle = new Rectangle(p1, p2, p3, p4);

            // Act
            var area = rectangle.Area();

            // Assert
            Assert.Equals(66, area); // (10 - 0 + 1) * (5 - 0 + 1) = 66
        }
        */
    }
    

}

/*
using Xunit;
using Math_Graphic.core.math.shapes;
using Math_Graphic.core.common;

public class RectangleTests
{
    [Fact]
    public void Constructor_InitializesCorrectlyWithOrderedPoints()
    {
        // Arrange
        var p1 = new PointXy(1, 1);
        var p2 = new PointXy(4, 1);
        var p3 = new PointXy(4, 3);
        var p4 = new PointXy(1, 3);

        // Act
        var rectangle = new Rectangle(p1, p2, p3, p4);

        // Assert
        Assert.Equal(1, rectangle.Origin().X);
        Assert.Equal(1, rectangle.Origin().Y);
        Assert.Equal(12, rectangle.Area()); // (4-1+1) * (3-1+1) = 12
    }

    [Fact]
    public void Constructor_InitializesCorrectlyWithUnorderedPoints()
    {
        // Arrange
        var p1 = new PointXy(4, 3);
        var p2 = new PointXy(1, 3);
        var p3 = new PointXy(1, 1);
        var p4 = new PointXy(4, 1);

        // Act
        var rectangle = new Rectangle(p1, p2, p3, p4);

        // Assert
        Assert.Equal(1, rectangle.Origin().X);
        Assert.Equal(1, rectangle.Origin().Y);
        Assert.Equal(12, rectangle.Area());
    }

    [Fact]
    public void DrawMe_CreatesCorrectBitmap()
    {
        // Arrange
        var p1 = new PointXy(1, 1);
        var p2 = new PointXy(3, 1);
        var p3 = new PointXy(3, 3);
        var p4 = new PointXy(1, 3);
        var rectangle = new Rectangle(p1, p2, p3, p4);

        // Act
        var bitmap = rectangle.DrawMe();
        var array = bitmap.GetArray();

        // Assert
        for (int i = rectangle.Origin().X; i <= rectangle.Origin().X + 2; i++)
        {
            for (int j = rectangle.Origin().Y; j <= rectangle.Origin().Y + 2; j++)
            {
                Assert.Equal(1, array[i, j]);
            }
        }
        Assert.Equal(1000 * 1000, bitmap.GetSize()); // Total size of the array
    }

    [Fact]
    public void Area_CalculatesCorrectArea()
    {
        // Arrange
        var p1 = new PointXy(0, 0);
        var p2 = new PointXy(10, 0);
        var p3 = new PointXy(10, 5);
        var p4 = new PointXy(0, 5);
        var rectangle = new Rectangle(p1, p2, p3, p4);

        // Act
        var area = rectangle.Area();

        // Assert
        Assert.Equal(66, area); // (10 - 0 + 1) * (5 - 0 + 1) = 66
    }
}
*/