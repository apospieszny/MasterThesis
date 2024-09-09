using NUnit.Framework;
using Math_Graphic.core.math.shapes;
using Math_Graphic.core.common;
using Math_Graphic.core.math;


/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 * Dodanie dodatkowej przestrzeni nazw
 */

namespace Math_Graphic.Tests.GPT4.first
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void Constructor_InitializesPropertiesCorrectly()
        {
            var center = new PointXy(100, 100);
            int radius = 50;

            var circle = new Circle(center, radius);

            Assert.AreEqual(ShapeType.Circle, circle.ShapeType);
            
        }
        /* Test odrzucony
        [Test]
        public void DrawMe_CreatesCorrectArea()
        {
            var center = new PointXy(500, 500);
            int radius = 100;
            var circle = new Circle(center, radius);

            var bitmap = circle.DrawMe();

            Assert.AreEqual(System.Math.PI * radius * radius, circle.Area(), 1.0); // Tolerancja błędu 1 piksel
        }*/

        [Test]
        public void DrawMe_CorrectlyDrawsCircle()
        {
            var center = new PointXy(500, 500);
            int radius = 30;
            var circle = new Circle(center, radius);

            var bitmap = circle.DrawMe();
            var array = bitmap.GetArray();

            // Sprawdzenie, czy punkt na obwodzie kręgu istnieje
            Assert.AreEqual(1, array[center.X, center.Y + radius]);
            Assert.AreEqual(1, array[center.X + radius, center.Y]);
            Assert.AreEqual(1, array[center.X, center.Y - radius]);
            Assert.AreEqual(1, array[center.X - radius, center.Y]);
        }
        /* Test odrzucony
        [Test]
        public void Area_ReturnsCorrectValue()
        {
            var center = new PointXy(250, 250);
            int radius = 50;
            var circle = new Circle(center, radius);

            // Wywołanie metody DrawMe, aby zainicjować wartość area
            circle.DrawMe();

            Assert.AreEqual(System.Math.PI * radius * radius, circle.Area(), 1.0); // Tolerancja błędu 1 piksel
        }

        [Test]
        public void Origin_ReturnsCorrectValue()
        {
            var center = new PointXy(300, 300);
            int radius = 100;
            var circle = new Circle(center, radius);

            var origin = circle.Origin();
            Assert.AreEqual(new PointXy(200, 200), origin);
        }*/
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
        public void Constructor_InitializesPropertiesCorrectly()
        {
            var center = new PointXy(100, 100);
            int radius = 50;

            var circle = new Circle(center, radius);

            Assert.AreEqual(ShapeType.Circle, circle.ShapeType);
            Assert.AreEqual(center, circle.Center); // Uwaga: ta linia zakłada, że `Center` jest właściwością publiczną klasy `Circle`
            Assert.AreEqual(radius, circle.Radius); // Podobnie, zakładamy publiczną właściwość `Radius`
        }

        [Test]
        public void DrawMe_CreatesCorrectArea()
        {
            var center = new PointXy(500, 500);
            int radius = 100;
            var circle = new Circle(center, radius);

            var bitmap = circle.DrawMe();

            Assert.AreEqual(Math.PI * radius * radius, circle.Area(), 1.0); // Tolerancja błędu 1 piksel
        }

        [Test]
        public void DrawMe_CorrectlyDrawsCircle()
        {
            var center = new PointXy(500, 500);
            int radius = 30;
            var circle = new Circle(center, radius);

            var bitmap = circle.DrawMe();
            var array = bitmap.GetArray();

            // Sprawdzenie, czy punkt na obwodzie kręgu istnieje
            Assert.AreEqual(1, array[center.X, center.Y + radius]);
            Assert.AreEqual(1, array[center.X + radius, center.Y]);
            Assert.AreEqual(1, array[center.X, center.Y - radius]);
            Assert.AreEqual(1, array[center.X - radius, center.Y]);
        }

        [Test]
        public void Area_ReturnsCorrectValue()
        {
            var center = new PointXy(250, 250);
            int radius = 50;
            var circle = new Circle(center, radius);

            // Wywołanie metody DrawMe, aby zainicjować wartość area
            circle.DrawMe();

            Assert.AreEqual(Math.PI * radius * radius, circle.Area(), 1.0); // Tolerancja błędu 1 piksel
        }

        [Test]
        public void Origin_ReturnsCorrectValue()
        {
            var center = new PointXy(300, 300);
            int radius = 100;
            var circle = new Circle(center, radius);

            var origin = circle.Origin();
            Assert.AreEqual(new PointXy(200, 200), origin);
        }
    }
}
*/