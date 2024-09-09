using Math_Graphic.core.common;
using Math_Graphic.core.math;
using Math_Graphic.core.math.shapes;
using NUnit.Framework;

/* 
 * Usystematyzowanie namespace
 * Poniżej został zakomentowany wygenerowany kod
 * Poprawki w kodzie:
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 */

namespace Math_Graphic.Tests.geminiAdvanced.alsoFirst
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void Constructor_SetsPropertiesCorrectly()
        {
            // Arrange
            var center = new PointXy(5, 3);
            var radius = 2;

            // Act
            var circle = new Circle(center, radius);

            // Assert
            Assert.AreEqual(ShapeType.Circle, circle.ShapeType); 
        }

        [Test]
        public void DrawMe_CreatesBitmapAndCalculatesArea()
        {
            // Arrange
            var center = new PointXy(3, 3);
            var radius = 2;
            var circle = new Circle(center, radius);

            // Act
            var bitmap = circle.DrawMe();

            // Assert
            Assert.AreEqual(13, circle.Area()); 
            Assert.AreEqual(1000 * 1000, bitmap.GetSize()); 
        }
        /* Test odrzucony
        [Test]
        public void Origin_CalculatesCorrectOrigin()
        {
            // Arrange
            var center = new PointXy(5, 3);
            var radius = 2;
            var circle = new Circle(center, radius);

            // Act
            var origin = circle.Origin();

            // Assert
            Assert.AreEqual(new PointXy(3, 1), origin); 
        }*/

        [Test]
        public void Area_CalculatesAreaOnceAndReturnsCachedValue()
        {
            // Arrange
            var center = new PointXy(3, 3);
            var radius = 2;
            var circle = new Circle(center, radius);

            // Act
            var area1 = circle.Area();
            var area2 = circle.Area();

            // Assert
            Assert.AreEqual(area1, area2); 
        }
    }
}

/*
using Math_Graphic.core.common;
using Math_Graphic.core.math;
using Math_Graphic.core.math.shapes;
using NUnit.Framework;


namespace Math_Graphic.Tests.geminiAdvanced.alsoFirst
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void Constructor_SetsPropertiesCorrectly()
        {
            // Arrange
            var center = new PointXy(5, 3);
            var radius = 2;

            // Act
            var circle = new Circle(center, radius);

            // Assert
            Assert.AreEqual(center, circle._center); 
            Assert.AreEqual(radius, circle._r); 
            Assert.AreEqual(ShapeType.Circle, circle.ShapeType); 
        }

        [Test]
        public void DrawMe_CreatesBitmapAndCalculatesArea()
        {
            // Arrange
            var center = new PointXy(3, 3);
            var radius = 2;
            var circle = new Circle(center, radius);

            // Act
            var bitmap = circle.DrawMe();

            // Assert
            Assert.AreEqual(13, circle.Area()); 
            Assert.AreEqual(1000 * 1000, bitmap.GetSize()); 
        }

        [Test]
        public void Origin_CalculatesCorrectOrigin()
        {
            // Arrange
            var center = new PointXy(5, 3);
            var radius = 2;
            var circle = new Circle(center, radius);

            // Act
            var origin = circle.Origin();

            // Assert
            Assert.AreEqual(new PointXy(3, 1), origin); 
        }

        [Test]
        public void Area_CalculatesAreaOnceAndReturnsCachedValue()
        {
            // Arrange
            var center = new PointXy(3, 3);
            var radius = 2;
            var circle = new Circle(center, radius);

            // Act
            var area1 = circle.Area();
            var area2 = circle.Area();

            // Assert
            Assert.AreEqual(area1, area2); 
        }
    }
}

*/