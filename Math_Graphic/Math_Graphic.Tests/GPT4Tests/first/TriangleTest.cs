using NUnit.Framework;
using Math_Graphic.core.math.shapes;
using Math_Graphic.core.common;

/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 * Dodanie dodatkowej przestrzeni nazw
 * Użycie metody wbudowanej pod złą nazwą
 */

namespace Math_Graphic.Tests.GPT4.first
{
    [TestFixture]
    public class TriangleTests
    {
        private PointXy p1;
        private PointXy p2;
        private PointXy p3;
        private Triangle triangle;

        [SetUp]
        public void Setup()
        {
            // Inicjalizacja punktów dla trójkąta
            p1 = new PointXy(0, 0);
            p2 = new PointXy(4, 0);
            p3 = new PointXy(2, 3);
            triangle = new Triangle(p1, p2, p3);
        }

        [Test]
        public void Constructor_AssignsPointsCorrectly()
        {
            Assert.AreEqual(0, triangle.Origin().X);
            Assert.AreEqual(0, triangle.Origin().Y);
        }
        /* Test odrzucony
        [Test]
        public void DrawMe_CreatesBitmap_AndCalculatesArea()
        {
            var bitmap = triangle.DrawMe();
            Assert.AreEqual(6, triangle.Area());
            Assert.AreEqual(1, bitmap.Get(2, 1)); // Sprawdzenie, czy punkt wewnątrz jest poprawnie rysowany
        }

        [Test]
        public void Area_WithoutDrawMe_CalculatesOnFirstCall()
        {
            Assert.AreEqual(6, triangle.Area());
        }*/

        [Test]
        public void Origin_FindsCorrectCoordinates()
        {
            var origin = triangle.Origin();
            Assert.AreEqual(0, origin.X);
            Assert.AreEqual(0, origin.Y);
        }
    }
}

/*
using NUnit.Framework;
using Math_Graphic.core.math.shapes;
using Math_Graphic.core.common;

namespace Math_Graphic.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        private PointXy p1;
        private PointXy p2;
        private PointXy p3;
        private Triangle triangle;

        [SetUp]
        public void Setup()
        {
            // Inicjalizacja punktów dla trójkąta
            p1 = new PointXy(0, 0);
            p2 = new PointXy(4, 0);
            p3 = new PointXy(2, 3);
            triangle = new Triangle(p1, p2, p3);
        }

        [Test]
        public void Constructor_AssignsPointsCorrectly()
        {
            Assert.AreEqual(0, triangle.Origin().X);
            Assert.AreEqual(0, triangle.Origin().Y);
        }

        [Test]
        public void PointInTriangle_Inside_ReturnsTrue()
        {
            Assert.IsTrue(triangle.PointInTriangle(2, 1));
        }

        [Test]
        public void PointInTriangle_Outside_ReturnsFalse()
        {
            Assert.IsFalse(triangle.PointInTriangle(0, 4));
        }

        [Test]
        public void DrawMe_CreatesBitmap_AndCalculatesArea()
        {
            var bitmap = triangle.DrawMe();
            Assert.AreEqual(6, triangle.Area());
            Assert.AreEqual(1, bitmap.Get(2, 1)); // Sprawdzenie, czy punkt wewnątrz jest poprawnie rysowany
        }

        [Test]
        public void Area_WithoutDrawMe_CalculatesOnFirstCall()
        {
            Assert.AreEqual(6, triangle.Area());
        }

        [Test]
        public void Origin_FindsCorrectCoordinates()
        {
            var origin = triangle.Origin();
            Assert.AreEqual(0, origin.X);
            Assert.AreEqual(0, origin.Y);
        }
    }
}

*/