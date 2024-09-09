using NUnit.Framework;
using Math_Graphic.core.math.shapes;
using Math_Graphic.core.math;


/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 */

namespace Math_Graphic.Tests.GPT4.alsoWithContext
{
    [TestFixture]
    public class TriangleTests
    {
        private Triangle _triangle;
        private PointXy _p1, _p2, _p3;

        [SetUp]
        public void Setup()
        {
            // Punkt przykładowy 1
            _p1 = new PointXy(0, 0);
            // Punkt przykładowy 2
            _p2 = new PointXy(10, 0);
            // Punkt przykładowy 3
            _p3 = new PointXy(5, 10);

            _triangle = new Triangle(_p1, _p2, _p3);
        }

        [Test]
        public void Triangle_Is_Created_Correctly()
        {
            Assert.IsNotNull(_triangle);
            Assert.AreEqual(ShapeType.Triangle, _triangle.ShapeType);
        }

        [Test]
        public void Origin_Correctly_Calculated()
        {
            var origin = _triangle.Origin();
            Assert.AreEqual(0, origin.X);
            Assert.AreEqual(0, origin.Y);
        }

        [Test]
        public void Area_Calculated_Once()
        {
            int firstCall = _triangle.Area();
            int secondCall = _triangle.Area();
            Assert.AreEqual(firstCall, secondCall);
        }

        /* Test odrzucony
        [Test]
        public void DrawMe_Correct_Area()
        {
            _triangle.DrawMe();
            Assert.AreEqual(50, _triangle.Area()); // Przykładowa wartość, do weryfikacji
        }*/
    }
}

/*
using NUnit.Framework;
using Math_Graphic.core.math.shapes;
using Math_Graphic.core.math;

namespace Math_Graphic.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        private Triangle _triangle;
        private PointXy _p1, _p2, _p3;

        [SetUp]
        public void Setup()
        {
            // Punkt przykładowy 1
            _p1 = new PointXy(0, 0);
            // Punkt przykładowy 2
            _p2 = new PointXy(10, 0);
            // Punkt przykładowy 3
            _p3 = new PointXy(5, 10);

            _triangle = new Triangle(_p1, _p2, _p3);
        }

        [Test]
        public void Triangle_Is_Created_Correctly()
        {
            Assert.IsNotNull(_triangle);
            Assert.AreEqual(ShapeType.Triangle, _triangle.ShapeType);
        }

        [Test]
        public void Origin_Correctly_Calculated()
        {
            var origin = _triangle.Origin();
            Assert.AreEqual(0, origin.X);
            Assert.AreEqual(0, origin.Y);
        }

        [Test]
        public void Area_Calculated_Once()
        {
            int firstCall = _triangle.Area();
            int secondCall = _triangle.Area();
            Assert.AreEqual(firstCall, secondCall);
        }

        [Test]
        public void PointInTriangle_True_For_Inside_Point()
        {
            Assert.IsTrue(_triangle.PointInTriangle(5, 5));
        }

        [Test]
        public void PointInTriangle_False_For_Outside_Point()
        {
            Assert.IsFalse(_triangle.PointInTriangle(-1, -1));
        }

        [Test]
        public void DrawMe_Correct_Area()
        {
            _triangle.DrawMe();
            Assert.AreEqual(50, _triangle.Area()); // Przykładowa wartość, do weryfikacji
        }
    }
}
*/