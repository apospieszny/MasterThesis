using Math_Graphic.core.math.matrix;
using Math_Graphic.core.math.modules;
using NUnit.Framework;

/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 */

namespace Math_Graphic.Tests.geminiAdvanced.first;

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
    public void Constructor_WithoutParameters_Creates3x3Matrix()
    {
        var matrix = new Matrix();

        Assert.AreEqual(3, matrix.GetWidth());
        Assert.AreEqual(3, matrix.GetHeight());
    }

    [Test]
    public void CreateIMatrix_CreatesMatrixWithRealMatrix()
    {
        var realMatrix = MatrixUtils.CreateRealMatrix(2, 2);
        var matrix = new Matrix();
        var newMatrix = matrix.CreateIMatrix(realMatrix);

        Assert.AreEqual(realMatrix, ((Matrix)newMatrix).GetRealMatrix());
    }

    [Test]
    public void CreateIdentityMatrix_CreatesIdentityMatrix()
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
    /* Test odrzucony
    [Test]
    public void Determinant_CalculatesDeterminant()
    {
        var matrix = new Matrix();
        matrix.SetMatrixValues(new double[][]
        {
            new double[] { 1, 2, 3 },
            new double[] { 4, 5, 6 },
            new double[] { 7, 8, 9 }
        });

        var determinant = matrix.Determinant();

        Assert.AreEqual(0, determinant); // Determinant of this matrix is 0
    }*/

    [Test]
    public void GetMatrixValue_GetsValueAtRowAndColumn()
    {
        var matrix = new Matrix();
        matrix.SetMatrixValues(new double[][]
        {
            new double[] { 1, 2, 3 },
            new double[] { 4, 5, 6 },
            new double[] { 7, 8, 9 }
        });

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
    public void SetMatrixValues_SetsValuesFromDoubleArray()
    {
        var values = new double[][]
        {
            new double[] { 1, 2, 3 },
            new double[] { 4, 5, 6 },
            new double[] { 7, 8, 9 }
        };
        var matrix = new Matrix();
        matrix.SetMatrixValues(values);

        Assert.AreEqual(values, matrix.GetRealMatrix().GetData());
    }

    [Test]
    public void GetWidth_GetsColumnDimension()
    {
        var matrix = new Matrix();
        matrix.SetMatrixValues(new double[][]
        {
            new double[] { 1, 2, 3 },
            new double[] { 4, 5, 6 },
            new double[] { 7, 8, 9 }
        });

        var width = matrix.GetWidth();

        Assert.AreEqual(3, width);
    }

    [Test]
    public void GetHeight_GetsRowDimension()
    {
        var matrix = new Matrix();
        matrix.SetMatrixValues(new double[][]
        {
            new double[] { 1, 2, 3 },
            new double[] { 4, 5, 6 },
            new double[] { 7, 8, 9 }
        });

        var height = matrix.GetHeight();

        Assert.AreEqual(3, height);
    }
    /* Test odrzucony
    [Test]
    public void ToString_ReturnsFormattedMatrixString()
    {
        var matrix = new Matrix();
        matrix.SetMatrixValues(new double[][]
        {
            new double[] { 1, 2, 3 },
            new double[] { 4, 5, 6 },
            new double[] { 7, 8, 9 }
        });

        var matrixString = matrix.ToString();

        var expected = "<table>\n<tr>\n<td>1.0</td> <td>2.0</td> <td>3.0</td> \n</tr>\n<tr>\n<td>4.0</td> <td>5.0</td> <td>6.0</td> \n</tr>\n<tr>\n<td>7.0</td> <td>8.0</td> <td>9.0</td> \n</tr>\n</table>";
        Assert.AreEqual(expected, matrixString);
    }*/

    [Test]
    public void GetRealMatrix_ReturnsRealMatrix()
    {
        var realMatrix = MatrixUtils.CreateRealMatrix(2, 2);
        var matrix = new Matrix(realMatrix);

        Assert.AreEqual(realMatrix, matrix.GetRealMatrix());
    }
}

/*
using Math_Graphic.core.math.matrix;
using Math_Graphic.core.math.modules;
using NUnit.Framework;

namespace Math_Graphic.core.math.tests.matrix;

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
    public void Constructor_WithoutParameters_Creates3x3Matrix()
    {
        var matrix = new Matrix();

        Assert.AreEqual(3, matrix.GetWidth());
        Assert.AreEqual(3, matrix.GetHeight());
    }

    [Test]
    public void CreateIMatrix_CreatesMatrixWithRealMatrix()
    {
        var realMatrix = MatrixUtils.CreateRealMatrix(2, 2);
        var matrix = new Matrix();
        var newMatrix = matrix.CreateIMatrix(realMatrix);

        Assert.AreEqual(realMatrix, ((Matrix)newMatrix).GetRealMatrix());
    }

    [Test]
    public void CreateIdentityMatrix_CreatesIdentityMatrix()
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
    public void Determinant_CalculatesDeterminant()
    {
        var matrix = new Matrix();
        matrix.SetMatrixValues(new double[][]
        {
            new double[] { 1, 2, 3 },
            new double[] { 4, 5, 6 },
            new double[] { 7, 8, 9 }
        });

        var determinant = matrix.Determinant();

        Assert.AreEqual(0, determinant); // Determinant of this matrix is 0
    }

    [Test]
    public void GetMatrixValue_GetsValueAtRowAndColumn()
    {
        var matrix = new Matrix();
        matrix.SetMatrixValues(new double[][]
        {
            new double[] { 1, 2, 3 },
            new double[] { 4, 5, 6 },
            new double[] { 7, 8, 9 }
        });

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
    public void SetMatrixValues_SetsValuesFromDoubleArray()
    {
        var values = new double[][]
        {
            new double[] { 1, 2, 3 },
            new double[] { 4, 5, 6 },
            new double[] { 7, 8, 9 }
        };
        var matrix = new Matrix();
        matrix.SetMatrixValues(values);

        Assert.AreEqual(values, matrix.GetRealMatrix().GetData());
    }

    [Test]
    public void GetWidth_GetsColumnDimension()
    {
        var matrix = new Matrix();
        matrix.SetMatrixValues(new double[][]
        {
            new double[] { 1, 2, 3 },
            new double[] { 4, 5, 6 },
            new double[] { 7, 8, 9 }
        });

        var width = matrix.GetWidth();

        Assert.AreEqual(3, width);
    }

    [Test]
    public void GetHeight_GetsRowDimension()
    {
        var matrix = new Matrix();
        matrix.SetMatrixValues(new double[][]
        {
            new double[] { 1, 2, 3 },
            new double[] { 4, 5, 6 },
            new double[] { 7, 8, 9 }
        });

        var height = matrix.GetHeight();

        Assert.AreEqual(3, height);
    }

    [Test]
    public void ToString_ReturnsFormattedMatrixString()
    {
        var matrix = new Matrix();
        matrix.SetMatrixValues(new double[][]
        {
            new double[] { 1, 2, 3 },
            new double[] { 4, 5, 6 },
            new double[] { 7, 8, 9 }
        });

        var matrixString = matrix.ToString();

        var expected = "<table>\n<tr>\n<td>1.0</td> <td>2.0</td> <td>3.0</td> \n</tr>\n<tr>\n<td>4.0</td> <td>5.0</td> <td>6.0</td> \n</tr>\n<tr>\n<td>7.0</td> <td>8.0</td> <td>9.0</td> \n</tr>\n</table>";
        Assert.AreEqual(expected, matrixString);
    }

    [Test]
    public void GetRealMatrix_ReturnsRealMatrix()
    {
        var realMatrix = MatrixUtils.CreateRealMatrix(2, 2);
        var matrix = new Matrix(realMatrix);

        Assert.AreEqual(realMatrix, matrix.GetRealMatrix());
    }
}
*/