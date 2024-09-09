using NUnit.Framework;
using Math_Graphic.core.math.modules;
using Math_Graphic.core.math.matrix;


/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 * Dodanie dodatkowej przestrzeni nazw
 * testy nie zostały napisane we frameworku NUnit
 */

namespace Math_Graphic.Tests.GPT4.alsoFirst;

[TestFixture]
public class MatrixTests
{

    private Matrix _matrix;

    /* Test odrzucony
    [Test]
    public void Constructor_WithRealMatrix_SetsMatrix()
    {
        Assert.IsNotNull(_matrix.GetRealMatrix());
    }*/

    [Test]
    public void DefaultConstructor_Creates3x3Matrix()
    {
        var defaultMatrix = new Matrix();
        Assert.AreEqual(3, defaultMatrix.GetHeight());
        Assert.AreEqual(3, defaultMatrix.GetWidth());
    }

    /* Test odrzucony
    [Test]
    public void CreateIdentityMatrix_CreatesIdentityMatrix()
    {
        _matrix.CreateIdentityMatrix(3);
        Assert.AreEqual(1, _matrix.GetMatrixValue(0, 0));
        Assert.AreEqual(1, _matrix.GetMatrixValue(1, 1));
        Assert.AreEqual(1, _matrix.GetMatrixValue(2, 2));
        Assert.AreEqual(0, _matrix.GetMatrixValue(0, 1));
    }*/

}

/*
using NUnit.Framework;
using Moq;
using Math_Graphic.core.math.modules;
using Math_Graphic.core.math.matrix;

[TestFixture]
public class MatrixTests
{
    private Mock<RealMatrix> _mockRealMatrix;
    private Matrix _matrix;

    [SetUp]
    public void SetUp()
    {
        _mockRealMatrix = new Mock<RealMatrix>(new double[][] { new double[] { 1, 2 }, new double[] { 3, 4 } });
        _matrix = new Matrix(_mockRealMatrix.Object);
    }

    [Test]
    public void Constructor_WithRealMatrix_SetsMatrix()
    {
        Assert.IsNotNull(_matrix.GetRealMatrix());
    }

    [Test]
    public void DefaultConstructor_Creates3x3Matrix()
    {
        var defaultMatrix = new Matrix();
        Assert.AreEqual(3, defaultMatrix.GetHeight());
        Assert.AreEqual(3, defaultMatrix.GetWidth());
    }

    [Test]
    public void CreateIMatrix_ReturnsNewMatrixInstance()
    {
        var newMatrix = _matrix.CreateIMatrix(_mockRealMatrix.Object);
        Assert.IsNotNull(newMatrix);
        Assert.AreNotSame(_matrix, newMatrix);
    }

    [Test]
    public void CreateIdentityMatrix_CreatesIdentityMatrix()
    {
        _matrix.CreateIdentityMatrix(3);
        Assert.AreEqual(1, _matrix.GetMatrixValue(0, 0));
        Assert.AreEqual(1, _matrix.GetMatrixValue(1, 1));
        Assert.AreEqual(1, _matrix.GetMatrixValue(2, 2));
        Assert.AreEqual(0, _matrix.GetMatrixValue(0, 1));
    }

    [Test]
    public void Determinant_ReturnsCorrectValue()
    {
        _mockRealMatrix.Setup(m => m.GetData()).Returns(new double[][] { new double[] { 1, 0 }, new double[] { 0, 1 } });
        Assert.AreEqual(1, _matrix.Determinant());
    }

    [Test]
    public void GetMatrixValue_ReturnsCorrectValue()
    {
        _mockRealMatrix.Setup(m => m.GetData()).Returns(new double[][] { new double[] { 5, 6 }, new double[] { 7, 8 } });
        Assert.AreEqual(5, _matrix.GetMatrixValue(0, 0));
        Assert.AreEqual(6, _matrix.GetMatrixValue(0, 1));
    }

    [Test]
    public void SetMatrixValue_SetsValueCorrectly()
    {
        _matrix.SetMatrixValue(0, 0, 10);
        _mockRealMatrix.Verify(m => m.SetEntry(0, 0, 10), Times.Once);
    }

    [Test]
    public void SetMatrixValues_SetsValuesCorrectly()
    {
        var values = new double[][] { new double[] { 9, 8 }, new double[] { 7, 6 } };
        _matrix.SetMatrixValues(values);
        _mockRealMatrix.Setup(m => m.GetData()).Returns(values);
        Assert.AreEqual(9, _matrix.GetMatrixValue(0, 0));
    }

    [Test]
    public void ToString_ReturnsHtmlTable()
    {
        _mockRealMatrix.Setup(m => m.GetData()).Returns(new double[][] { new double[] { 1, 2 }, new double[] { 3, 4 } });
        string result = _matrix.ToString();
        StringAssert.Contains("<table>", result);
        StringAssert.Contains("<tr>", result);
        StringAssert.Contains("<td>1.0</td>", result);
    }

    [Test]
    public void GetWidth_ReturnsCorrectValue()
    {
        _mockRealMatrix.Setup(m => m.GetColumnDimension()).Returns(2);
        Assert.AreEqual(2, _matrix.GetWidth());
    }

    [Test]
    public void GetHeight_ReturnsCorrectValue()
    {
        _mockRealMatrix.Setup(m => m.GetRowDimension()).Returns(2);
        Assert.AreEqual(2, _matrix.GetHeight());
    }
}
*/