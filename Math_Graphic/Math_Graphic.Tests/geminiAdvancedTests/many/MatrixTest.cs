using Math_Graphic.core.math.matrix;
using Math_Graphic.core.math.modules;
using NUnit.Framework;

/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 */

namespace Math_Graphic.Tests.geminiAdvanced.alsoWithContext;

[TestFixture]
public class MatrixTests
{
    [Test]
    public void Constructor_WithRealMatrix_SetsRealMatrix()
    {
        var realMatrix = MatrixUtils.CreateRealMatrix(2, 2);
        var matrix = new Matrix(realMatrix);

        Assert.AreEqual(realMatrix, matrix.GetRealMatrix());
    }

    [Test]
    public void Constructor_Default_Creates3x3Matrix()
    {
        var matrix = new Matrix();

        Assert.AreEqual(3, matrix.GetWidth());
        Assert.AreEqual(3, matrix.GetHeight());
    }

    [Test]
    public void CreateIMatrix_ReturnsNewMatrixWithRealMatrix()
    {
        var realMatrix = MatrixUtils.CreateRealMatrix(2, 2);
        var matrix = new Matrix();
        var newMatrix = matrix.CreateIMatrix(realMatrix);

        Assert.AreEqual(realMatrix, ((Matrix)newMatrix).GetRealMatrix());
    }

    [Test]
    public void CreateIdentityMatrix_SetsRealMatrixToIdentityMatrix()
    {
        var matrix = new Matrix();
        matrix.CreateIdentityMatrix(3);

        var expected = new double[][]
        {
            new double[] { 1, 0, 0 },
            new double[] { 0, 1, 0 },
            new double[] { 0, 0, 1 }
        };

        Assert.AreEqual(expected, matrix.GetRealMatrix().GetData());
    }
    /* Test odrzucony*
    [Test]
    public void Determinant_ReturnsDeterminantOfRealMatrix()
    {
        var data = new double[][]
        {
            new double[] { 1, 2, 3 },
            new double[] { 4, 5, 6 },
            new double[] { 7, 8, 9 }
        };
        var realMatrix = new RealMatrix(data);
        var matrix = new Matrix(realMatrix);

        var determinant = matrix.Determinant();

        Assert.AreEqual(0, determinant); // Determinant of this matrix is 0
    }*/

    [Test]
    public void GetMatrixValue_ReturnsValueAtRowAndColumn()
    {
        var data = new double[][]
        {
            new double[] { 1, 2, 3 },
            new double[] { 4, 5, 6 },
            new double[] { 7, 8, 9 }
        };
        var realMatrix = new RealMatrix(data);
        var matrix = new Matrix(realMatrix);

        var value = matrix.GetMatrixValue(1, 2);

        Assert.AreEqual(6, value);
    }

    [Test]
    public void SetMatrixValue_SetsValueAtRowAndColumn()
    {
        var matrix = new Matrix();
        matrix.SetMatrixValue(0, 1, 5);

        Assert.AreEqual(5, matrix.GetMatrixValue(0, 1));
    }

    [Test]
    public void SetMatrixValues_SetsRealMatrixToNewValues()
    {
        var data = new double[][]
        {
            new double[] { 1, 2 },
            new double[] { 3, 4 }
        };
        var matrix = new Matrix();
        matrix.SetMatrixValues(data);

        Assert.AreEqual(data, matrix.GetRealMatrix().GetData());
    }

    [Test]
    public void GetWidth_ReturnsColumnDimensionOfRealMatrix()
    {
        var realMatrix = MatrixUtils.CreateRealMatrix(2, 3);
        var matrix = new Matrix(realMatrix);

        var width = matrix.GetWidth();

        Assert.AreEqual(3, width);
    }

    [Test]
    public void GetHeight_ReturnsRowDimensionOfRealMatrix()
    {
        var realMatrix = MatrixUtils.CreateRealMatrix(2, 3);
        var matrix = new Matrix(realMatrix);

        var height = matrix.GetHeight();

        Assert.AreEqual(2, height);
    }
    /* Test odrzucony
    [Test]
    public void ToString_ReturnsFormattedStringRepresentation()
    {
        var data = new double[][]
        {
            new double[] { 1.123, 2.456 },
            new double[] { 3.789, 4.012 }
        };
        var realMatrix = new RealMatrix(data);
        var matrix = new Matrix(realMatrix);

        var str = matrix.ToString();

        var expected = "<table>\n<tr>\n<td>1.1</td> <td>2.5</td> \n</tr>\n<tr>\n<td>3.8</td> <td>4.0</td> \n</tr>\n</table>";
        Assert.AreEqual(expected, str);
    }*/

    [Test]
    public void GetRealMatrix_ReturnsRealMatrix()
    {
        var realMatrix = MatrixUtils.CreateRealMatrix(2, 2);
        var matrix = new Matrix(realMatrix);

        var result = matrix.GetRealMatrix();

        Assert.AreEqual(realMatrix, result);
    }
}

/*
using Math_Graphic.core.math.matrix;
using Math_Graphic.core.math.modules;
using NUnit.Framework;

namespace Math_Graphic.core.math.tests.matrix;

[TestFixture]
public class MatrixTests
{
    [Test]
    public void Constructor_WithRealMatrix_SetsRealMatrix()
    {
        var realMatrix = MatrixUtils.CreateRealMatrix(2, 2);
        var matrix = new Matrix(realMatrix);

        Assert.AreEqual(realMatrix, matrix.GetRealMatrix());
    }

    [Test]
    public void Constructor_Default_Creates3x3Matrix()
    {
        var matrix = new Matrix();

        Assert.AreEqual(3, matrix.GetWidth());
        Assert.AreEqual(3, matrix.GetHeight());
    }

    [Test]
    public void CreateIMatrix_ReturnsNewMatrixWithRealMatrix()
    {
        var realMatrix = MatrixUtils.CreateRealMatrix(2, 2);
        var matrix = new Matrix();
        var newMatrix = matrix.CreateIMatrix(realMatrix);

        Assert.AreEqual(realMatrix, ((Matrix)newMatrix).GetRealMatrix());
    }

    [Test]
    public void CreateIdentityMatrix_SetsRealMatrixToIdentityMatrix()
    {
        var matrix = new Matrix();
        matrix.CreateIdentityMatrix(3);

        var expected = new double[][]
        {
            new double[] { 1, 0, 0 },
            new double[] { 0, 1, 0 },
            new double[] { 0, 0, 1 }
        };

        Assert.AreEqual(expected, matrix.GetRealMatrix().GetData());
    }

    [Test]
    public void Determinant_ReturnsDeterminantOfRealMatrix()
    {
        var data = new double[][]
        {
            new double[] { 1, 2, 3 },
            new double[] { 4, 5, 6 },
            new double[] { 7, 8, 9 }
        };
        var realMatrix = new RealMatrix(data);
        var matrix = new Matrix(realMatrix);

        var determinant = matrix.Determinant();

        Assert.AreEqual(0, determinant); // Determinant of this matrix is 0
    }

    [Test]
    public void GetMatrixValue_ReturnsValueAtRowAndColumn()
    {
        var data = new double[][]
        {
            new double[] { 1, 2, 3 },
            new double[] { 4, 5, 6 },
            new double[] { 7, 8, 9 }
        };
        var realMatrix = new RealMatrix(data);
        var matrix = new Matrix(realMatrix);

        var value = matrix.GetMatrixValue(1, 2);

        Assert.AreEqual(6, value);
    }

    [Test]
    public void SetMatrixValue_SetsValueAtRowAndColumn()
    {
        var matrix = new Matrix();
        matrix.SetMatrixValue(0, 1, 5);

        Assert.AreEqual(5, matrix.GetMatrixValue(0, 1));
    }

    [Test]
    public void SetMatrixValues_SetsRealMatrixToNewValues()
    {
        var data = new double[][]
        {
            new double[] { 1, 2 },
            new double[] { 3, 4 }
        };
        var matrix = new Matrix();
        matrix.SetMatrixValues(data);

        Assert.AreEqual(data, matrix.GetRealMatrix().GetData());
    }

    [Test]
    public void GetWidth_ReturnsColumnDimensionOfRealMatrix()
    {
        var realMatrix = MatrixUtils.CreateRealMatrix(2, 3);
        var matrix = new Matrix(realMatrix);

        var width = matrix.GetWidth();

        Assert.AreEqual(3, width);
    }

    [Test]
    public void GetHeight_ReturnsRowDimensionOfRealMatrix()
    {
        var realMatrix = MatrixUtils.CreateRealMatrix(2, 3);
        var matrix = new Matrix(realMatrix);

        var height = matrix.GetHeight();

        Assert.AreEqual(2, height);
    }

    [Test]
    public void ToString_ReturnsFormattedStringRepresentation()
    {
        var data = new double[][]
        {
            new double[] { 1.123, 2.456 },
            new double[] { 3.789, 4.012 }
        };
        var realMatrix = new RealMatrix(data);
        var matrix = new Matrix(realMatrix);

        var str = matrix.ToString();

        var expected = "<table>\n<tr>\n<td>1.1</td> <td>2.5</td> \n</tr>\n<tr>\n<td>3.8</td> <td>4.0</td> \n</tr>\n</table>";
        Assert.AreEqual(expected, str);
    }

    [Test]
    public void GetRealMatrix_ReturnsRealMatrix()
    {
        var realMatrix = MatrixUtils.CreateRealMatrix(2, 2);
        var matrix = new Matrix(realMatrix);

        var result = matrix.GetRealMatrix();

        Assert.AreEqual(realMatrix, result);
    }
}
*/