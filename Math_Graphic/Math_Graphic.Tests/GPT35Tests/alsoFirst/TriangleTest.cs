using Math_Graphic.core.math.shapes;
using Math_Graphic.core.common;
using NUnit.Framework;
using Math_Graphic.core.math;

/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 */

namespace Math_Graphic.Tests.GPT35.alsoFirst;

[TestFixture]
public class TriangleTests
{
    private PointXy _p1;
    private PointXy _p2;
    private PointXy _p3;
    private Triangle _triangle;

    [SetUp]
    public void Setup()
    {
        _p1 = new PointXy(0, 0);
        _p2 = new PointXy(5, 0);
        _p3 = new PointXy(0, 5);
        _triangle = new Triangle(_p1, _p2, _p3);
    }
    /* Test odrzucony
    [Test]
    public void Constructor_ShouldInitializeTriangle()
    {
        Assert.AreEqual(_p1, _triangle.Origin());
        Assert.AreEqual(ShapeType.Triangle, _triangle.ShapeType);
    }*/

    [Test]
    public void DrawMe_CreatesBitmapAndCalculatesArea()
    {
        Bitmap bitmap = _triangle.DrawMe();
        int area = _triangle.Area();

        // Sprawdzenie czy bitmapa została utworzona
        Assert.IsNotNull(bitmap);

        // Sprawdzenie czy area został poprawnie wyliczony
        Assert.AreEqual(area, _triangle.Area());
    }

    [Test]
    public void Origin_ReturnsCorrectOriginPoint()
    {
        PointXy origin = _triangle.Origin();
        Assert.AreEqual(0, origin.X);
        Assert.AreEqual(0, origin.Y);
    }

    [Test]
    public void Area_CalculatesAreaCorrectly()
    {
        int area = _triangle.Area();
        Assert.Greater(area, 0);
    }
    /* Test odrzucony
    [Test]
    public void Area_CalledBeforeDrawMe_CalculatesArea()
    {
        // Resetowanie obszaru na -1 przed wywołaniem Area
        Triangle triangle = new Triangle(_p1, _p2, _p3);
        Assert.AreEqual(-1, triangle.Area());
    }*/
}

/*
using Math_Graphic.core.math.shapes;
using Math_Graphic.core.common;
using NUnit.Framework;
using Math_Graphic.core.math;

[TestFixture]
public class TriangleTests
{
    private PointXy _p1;
    private PointXy _p2;
    private PointXy _p3;
    private Triangle _triangle;

    [SetUp]
    public void Setup()
    {
        _p1 = new PointXy(0, 0);
        _p2 = new PointXy(5, 0);
        _p3 = new PointXy(0, 5);
        _triangle = new Triangle(_p1, _p2, _p3);
    }

    [Test]
    public void Constructor_ShouldInitializeTriangle()
    {
        Assert.AreEqual(_p1, _triangle.Origin());
        Assert.AreEqual(ShapeType.Triangle, _triangle.ShapeType);
    }

    [Test]
    public void PointInTriangle_PointInside_ReturnsTrue()
    {
        bool result = _triangle.PointInTriangle(1, 1);
        Assert.IsTrue(result);
    }

    [Test]
    public void PointInTriangle_PointOutside_ReturnsFalse()
    {
        bool result = _triangle.PointInTriangle(6, 6);
        Assert.IsFalse(result);
    }

    [Test]
    public void DrawMe_CreatesBitmapAndCalculatesArea()
    {
        Bitmap bitmap = _triangle.DrawMe();
        int area = _triangle.Area();

        // Sprawdzenie czy bitmapa została utworzona
        Assert.IsNotNull(bitmap);

        // Sprawdzenie czy area został poprawnie wyliczony
        Assert.AreEqual(area, _triangle.Area());
    }

    [Test]
    public void Origin_ReturnsCorrectOriginPoint()
    {
        PointXy origin = _triangle.Origin();
        Assert.AreEqual(0, origin.X);
        Assert.AreEqual(0, origin.Y);
    }

    [Test]
    public void Area_CalculatesAreaCorrectly()
    {
        int area = _triangle.Area();
        Assert.Greater(area, 0);
    }

    [Test]
    public void Area_CalledBeforeDrawMe_CalculatesArea()
    {
        // Resetowanie obszaru na -1 przed wywołaniem Area
        Triangle triangle = new Triangle(_p1, _p2, _p3);
        Assert.AreEqual(-1, triangle.Area());
    }
}
*/