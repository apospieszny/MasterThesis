using Math_Graphic.core.common;
using Math_Graphic.core.math;
using Math_Graphic.core.math.shapes;
using NUnit.Framework;

/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 */

namespace Math_Graphic.Tests.geminiAdvanced.alsoWithContext;

[TestFixture]
public class TriangleTests
{
    [Test]
    public void Constructor_ValidPoints_CreatesTriangle()
    {
        var p1 = new PointXy(0, 0);
        var p2 = new PointXy(3, 0);
        var p3 = new PointXy(0, 4);

        var triangle = new Triangle(p1, p2, p3);

        Assert.AreEqual(ShapeType.Triangle, triangle.ShapeType);
    }
    /* Test odrzucony
    [Test]
    public void DrawMe_CreatesBitmap_AndSetsArea()
    {
        var triangle = new Triangle(new PointXy(0, 0), new PointXy(3, 0), new PointXy(0, 4));

        var bitmap = triangle.DrawMe();

        Assert.AreEqual(6, triangle.Area()); // Area of the triangle should be 6
        Assert.AreEqual(1000000, bitmap.GetSize()); // Bitmap size should be 1000x1000

        // Sprawdzenie, czy punkty wewnątrz trójkąta mają wartość 1 w bitmapie
        Assert.AreEqual(1, bitmap.Get(0, 0));
        Assert.AreEqual(1, bitmap.Get(1, 0));
        Assert.AreEqual(1, bitmap.Get(2, 0));
        Assert.AreEqual(1, bitmap.Get(0, 1));
        Assert.AreEqual(1, bitmap.Get(0, 2));
        Assert.AreEqual(1, bitmap.Get(0, 3));
        Assert.AreEqual(1, bitmap.Get(1, 1));
        Assert.AreEqual(1, bitmap.Get(1, 2));

        // Sprawdzenie, czy punkty na zewnątrz trójkąta mają wartość 0 w bitmapie
        Assert.AreEqual(0, bitmap.Get(3, 0));
        Assert.AreEqual(0, bitmap.Get(0, 4));
        Assert.AreEqual(0, bitmap.Get(4, 4));
    }*/

    [Test]
    public void Origin_ReturnsCorrectOrigin()
    {
        var triangle = new Triangle(new PointXy(2, 3), new PointXy(5, 1), new PointXy(0, 0));

        var origin = triangle.Origin();

        Assert.AreEqual(0, origin.X);
        Assert.AreEqual(0, origin.Y);
    }
    /* Test odrzucony
    [Test]
    public void Area_CalculatesAreaCorrectly()
    {
        var triangle = new Triangle(new PointXy(0, 0), new PointXy(3, 0), new PointXy(0, 4));

        var area = triangle.Area();

        Assert.AreEqual(6, area);
    }

    [Test]
    public void Area_AfterDrawMe_ReturnsCachedArea()
    {
        var triangle = new Triangle(new PointXy(0, 0), new PointXy(3, 0), new PointXy(0, 4));

        triangle.DrawMe();
        var area = triangle.Area();

        Assert.AreEqual(6, area);
    }*/
}

/*
using Math_Graphic.core.common;
using Math_Graphic.core.math;
using Math_Graphic.core.math.shapes;
using NUnit.Framework;

namespace Math_Graphic.core.tests.math.shapes;

[TestFixture]
public class TriangleTests
{
    [Test]
    public void Constructor_ValidPoints_CreatesTriangle()
    {
        var p1 = new PointXy(0, 0);
        var p2 = new PointXy(3, 0);
        var p3 = new PointXy(0, 4);

        var triangle = new Triangle(p1, p2, p3);

        Assert.AreEqual(ShapeType.Triangle, triangle.ShapeType);
        Assert.AreEqual(p1, triangle._p1);
        Assert.AreEqual(p2, triangle._p2);
        Assert.AreEqual(p3, triangle._p3);
    }

    [Test]
    public void PointInTriangle_PointInside_ReturnsTrue()
    {
        var triangle = new Triangle(new PointXy(0, 0), new PointXy(3, 0), new PointXy(0, 4));

        var result = triangle.PointInTriangle(1, 1);

        Assert.IsTrue(result);
    }

    [Test]
    public void PointInTriangle_PointOutside_ReturnsFalse()
    {
        var triangle = new Triangle(new PointXy(0, 0), new PointXy(3, 0), new PointXy(0, 4));

        var result = triangle.PointInTriangle(4, 1);

        Assert.IsFalse(result);
    }

    [Test]
    public void PointInTriangle_PointOnEdge_ReturnsTrue()
    {
        var triangle = new Triangle(new PointXy(0, 0), new PointXy(3, 0), new PointXy(0, 4));

        var result = triangle.PointInTriangle(1, 0);

        Assert.IsTrue(result);
    }

    [Test]
    public void PointInTriangle_PointOnVertex_ReturnsTrue()
    {
        var triangle = new Triangle(new PointXy(0, 0), new PointXy(3, 0), new PointXy(0, 4));

        var result = triangle.PointInTriangle(0, 0);

        Assert.IsTrue(result);
    }

    [Test]
    public void DrawMe_CreatesBitmap_AndSetsArea()
    {
        var triangle = new Triangle(new PointXy(0, 0), new PointXy(3, 0), new PointXy(0, 4));

        var bitmap = triangle.DrawMe();

        Assert.AreEqual(6, triangle.Area()); // Area of the triangle should be 6
        Assert.AreEqual(1000000, bitmap.GetSize()); // Bitmap size should be 1000x1000

        // Sprawdzenie, czy punkty wewnątrz trójkąta mają wartość 1 w bitmapie
        Assert.AreEqual(1, bitmap.Get(0, 0));
        Assert.AreEqual(1, bitmap.Get(1, 0));
        Assert.AreEqual(1, bitmap.Get(2, 0));
        Assert.AreEqual(1, bitmap.Get(0, 1));
        Assert.AreEqual(1, bitmap.Get(0, 2));
        Assert.AreEqual(1, bitmap.Get(0, 3));
        Assert.AreEqual(1, bitmap.Get(1, 1));
        Assert.AreEqual(1, bitmap.Get(1, 2));

        // Sprawdzenie, czy punkty na zewnątrz trójkąta mają wartość 0 w bitmapie
        Assert.AreEqual(0, bitmap.Get(3, 0));
        Assert.AreEqual(0, bitmap.Get(0, 4));
        Assert.AreEqual(0, bitmap.Get(4, 4));
    }

    [Test]
    public void Origin_ReturnsCorrectOrigin()
    {
        var triangle = new Triangle(new PointXy(2, 3), new PointXy(5, 1), new PointXy(0, 0));

        var origin = triangle.Origin();

        Assert.AreEqual(0, origin.X);
        Assert.AreEqual(0, origin.Y);
    }

    [Test]
    public void Area_CalculatesAreaCorrectly()
    {
        var triangle = new Triangle(new PointXy(0, 0), new PointXy(3, 0), new PointXy(0, 4));

        var area = triangle.Area();

        Assert.AreEqual(6, area);
    }

    [Test]
    public void Area_AfterDrawMe_ReturnsCachedArea()
    {
        var triangle = new Triangle(new PointXy(0, 0), new PointXy(3, 0), new PointXy(0, 4));

        triangle.DrawMe();
        var area = triangle.Area();

        Assert.AreEqual(6, area);
    }
}
*/