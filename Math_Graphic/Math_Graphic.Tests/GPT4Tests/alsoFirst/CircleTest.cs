using NUnit.Framework;
using Math_Graphic.core.math.shapes;
using Math_Graphic.core.common;
using Math_Graphic.core.math;


/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 */

namespace Math_Graphic.Tests.GPT4.alsoFirst
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void Constructor_ValidInput_SetsPropertiesCorrectly()
        {
            var center = new PointXy(10, 10);
            int radius = 5;
            var circle = new Circle(center, radius);

            Assert.AreEqual(ShapeType.Circle, circle.ShapeType);
        }
        /* Test odrzucony
        [Test]
        public void DrawMe_ValidCircle_CreatesCorrectBitmapAndCalculatesArea()
        {
            var center = new PointXy(500, 500);
            int radius = 10;
            var circle = new Circle(center, radius);
            var bitmap = circle.DrawMe();

            int expectedArea = 0;
            var array = bitmap.GetArray();
            for (int i = 0; i < 2 * radius; i++)
            {
                for (int j = 0; j < 2 * radius; j++)
                {
                    if ((i - radius) * (i - radius) + (j - radius) * (j - radius) <= radius * radius)
                    {
                        Assert.AreEqual(1, array[center.X - radius + i, center.Y - radius + j]);
                        expectedArea++;
                    }
                }
            }

            Assert.AreEqual(expectedArea, circle.Area());
        }

        [Test]
        public void Origin_CircleWithCenterAndRadius_ReturnsCorrectOrigin()
        {
            var center = new PointXy(500, 500);
            int radius = 10;
            var circle = new Circle(center, radius);
            var origin = circle.Origin();

            Assert.AreEqual(new PointXy(490, 490), origin);
        }
        */
        [Test]
        public void Area_AfterDrawing_ReturnsCorrectArea()
        {
            var center = new PointXy(500, 500);
            int radius = 10;
            var circle = new Circle(center, radius);
            var bitmap = circle.DrawMe();  // Ensure bitmap is drawn first

            int expectedArea = circle.Area();

            Assert.AreEqual(expectedArea, circle.Area());  // Check if area remains consistent
        }
    }
}


/*
Wygenerowany kod:

using NUnit.Framework;
using Math_Graphic.core.math.shapes;
using Math_Graphic.core.common;

namespace Math_Graphic.Tests
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void Constructor_ValidInput_SetsPropertiesCorrectly()
        {
            var center = new PointXy(10, 10);
            int radius = 5;
            var circle = new Circle(center, radius);

            Assert.AreEqual(ShapeType.Circle, circle.ShapeType);
            Assert.AreEqual(center, circle.Center);
            Assert.AreEqual(radius, circle.Radius);
        }

        [Test]
        public void DrawMe_ValidCircle_CreatesCorrectBitmapAndCalculatesArea()
        {
            var center = new PointXy(500, 500);
            int radius = 10;
            var circle = new Circle(center, radius);
            var bitmap = circle.DrawMe();

            int expectedArea = 0;
            var array = bitmap.GetArray();
            for (int i = 0; i < 2 * radius; i++)
            {
                for (int j = 0; j < 2 * radius; j++)
                {
                    if ((i - radius) * (i - radius) + (j - radius) * (j - radius) <= radius * radius)
                    {
                        Assert.AreEqual(1, array[center.X - radius + i, center.Y - radius + j]);
                        expectedArea++;
                    }
                }
            }
            
            Assert.AreEqual(expectedArea, circle.Area());
        }

        [Test]
        public void Origin_CircleWithCenterAndRadius_ReturnsCorrectOrigin()
        {
            var center = new PointXy(500, 500);
            int radius = 10;
            var circle = new Circle(center, radius);
            var origin = circle.Origin();

            Assert.AreEqual(new PointXy(490, 490), origin);
        }

        [Test]
        public void Area_AfterDrawing_ReturnsCorrectArea()
        {
            var center = new PointXy(500, 500);
            int radius = 10;
            var circle = new Circle(center, radius);
            var bitmap = circle.DrawMe();  // Ensure bitmap is drawn first

            int expectedArea = circle.Area();

            Assert.AreEqual(expectedArea, circle.Area());  // Check if area remains consistent
        }
    }
}
*/