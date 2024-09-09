using NUnit.Framework;
using Math_Graphic.core.math.matrix;
using Math_Graphic.core.math.modules;


/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Dodana klasa pomocnicza nie implementowała całego interface
 */

namespace Math_Graphic.Tests.GPT4.alsoFirst;

[TestFixture]
public class MatrixMathTests
{
    private MatrixMath _matrixMath;
    private IMatrix _matrix1;
    private IMatrix _matrix2;
    private IMatrix _resultMatrix;
    private RealMatrix _realMatrix1;
    private RealMatrix _realMatrix2;

    [SetUp]
    public void Setup()
    {
        _matrixMath = new MatrixMath();
        _realMatrix1 = new RealMatrix(new double[][] {
            new double[] {1, 2},
            new double[] {3, 4}
        });

        _realMatrix2 = new RealMatrix(new double[][] {
            new double[] {5, 6},
            new double[] {7, 8}
        });

        _matrix1 = new MatrixMock(_realMatrix1);
        _matrix2 = new MatrixMock(_realMatrix2);
    }

    [Test]
    public void InverseMatrix_ValidInput_ReturnsCorrectResult()
    {
        _resultMatrix = _matrixMath.InverseMatrix(_matrix1);
        Assert.IsNotNull(_resultMatrix);
        // Assume correct inverse is calculated by MatrixUtils.Inverse
    }
    /* Test odrzucony
    [Test]
    public void MatrixAddition_ValidInput_ReturnsCorrectResult()
    {
        _resultMatrix = _matrixMath.MatrixAddition(_matrix1, _matrix2);
        Assert.AreEqual(new double[,] { { 6, 8 }, { 10, 12 } }, _resultMatrix.GetRealMatrix().GetData());
    }*/

    [Test]
    public void MatrixAddition_InvalidDimension_ThrowsException()
    {
        var _matrix3 = new MatrixMock(new RealMatrix(new double[][] { new double[] { 1 } }));
        Assert.Throws<InvalidDimensionException>(() => _matrixMath.MatrixAddition(_matrix1, _matrix3));
    }
    /* Test odrzucony
    [Test]
    public void MatrixMultiplication_ValidInput_ReturnsCorrectResult()
    {
        _resultMatrix = _matrixMath.MatrixMultiplication(_matrix1, _matrix2);
        Assert.AreEqual(new double[,] { { 19, 22 }, { 43, 50 } }, _resultMatrix.GetRealMatrix().GetData());
    }*/

    [Test]
    public void MatrixMultiplication_InvalidDimension_ThrowsException()
    {
        var _matrix3 = new MatrixMock(new RealMatrix(new double[][] { new double[] { 1, 2, 3 } }));
        Assert.Throws<InvalidDimensionException>(() => _matrixMath.MatrixMultiplication(_matrix1, _matrix3));
    }
    /* Test odrzucony
    [Test]
    public void MatrixSubtracting_ValidInput_ReturnsCorrectResult()
    {
        _resultMatrix = _matrixMath.MatrixSubtracting(_matrix1, _matrix2);
        Assert.AreEqual(new double[,] { { -4, -4 }, { -4, -4 } }, _resultMatrix.GetRealMatrix().GetData());
    }*/

    [Test]
    public void MatrixSubtracting_InvalidDimension_ThrowsException()
    {
        var _matrix3 = new MatrixMock(new RealMatrix(new double[][] { new double[] { 1 } }));
        Assert.Throws<InvalidDimensionException>(() => _matrixMath.MatrixSubtracting(_matrix1, _matrix3));
    }
    /* Test odrzucony
    [Test]
    public void MatrixTransposition_ValidInput_ReturnsCorrectResult()
    {
        _resultMatrix = _matrixMath.MatrixTransposition(_matrix1);
        Assert.AreEqual(new double[,] { { 1, 3 }, { 2, 4 } }, _resultMatrix.GetRealMatrix().GetData());
    }

    [Test]
    public void ScalarMultiplication_ValidInput_ReturnsCorrectResult()
    {
        _resultMatrix = _matrixMath.ScalarMultiplication(_matrix1, 2);
        Assert.AreEqual(new double[,] { { 2, 4 }, { 6, 8 } }, _resultMatrix.GetRealMatrix().GetData());
    }*/

    private class MatrixMock : IMatrix
    {
        private RealMatrix _realMatrix;

        public MatrixMock(RealMatrix realMatrix)
        {
            _realMatrix = realMatrix;
        }

        public RealMatrix GetRealMatrix() => _realMatrix;

        public IMatrix CreateIMatrix(RealMatrix realMatrix)
        {
            return new MatrixMock(realMatrix);
        }

        public int GetHeight() => _realMatrix.GetRowDimension();

        public int GetWidth() => _realMatrix.GetColumnDimension();

        // dodane dodatkowe funkcje
        public double Determinant()
        {
            return 0;
        }

        public void SetMatrixValue(int row, int column, double value)
        {

        }

        public void SetMatrixValues(double[][] values)
        {

        }

        public void CreateIdentityMatrix(int size)
        {

        }


        public double GetMatrixValue(int row, int column)
        {
            return 0;
        }

    }
}

/*
using NUnit.Framework;
using Math_Graphic.core.math.matrix;
using Math_Graphic.core.math.modules;

[TestFixture]
public class MatrixMathTests
{
    private MatrixMath _matrixMath;
    private IMatrix _matrix1;
    private IMatrix _matrix2;
    private IMatrix _resultMatrix;
    private RealMatrix _realMatrix1;
    private RealMatrix _realMatrix2;

    [SetUp]
    public void Setup()
    {
        _matrixMath = new MatrixMath();
        _realMatrix1 = new RealMatrix(new double[][] {
            new double[] {1, 2},
            new double[] {3, 4}
        });

        _realMatrix2 = new RealMatrix(new double[][] {
            new double[] {5, 6},
            new double[] {7, 8}
        });

        _matrix1 = new MatrixMock(_realMatrix1);
        _matrix2 = new MatrixMock(_realMatrix2);
    }

    [Test]
    public void InverseMatrix_ValidInput_ReturnsCorrectResult()
    {
        _resultMatrix = _matrixMath.InverseMatrix(_matrix1);
        Assert.IsNotNull(_resultMatrix);
        // Assume correct inverse is calculated by MatrixUtils.Inverse
    }

    [Test]
    public void MatrixAddition_ValidInput_ReturnsCorrectResult()
    {
        _resultMatrix = _matrixMath.MatrixAddition(_matrix1, _matrix2);
        Assert.AreEqual(new double[,] { { 6, 8 }, { 10, 12 } }, _resultMatrix.GetRealMatrix().GetData());
    }

    [Test]
    public void MatrixAddition_InvalidDimension_ThrowsException()
    {
        var _matrix3 = new MatrixMock(new RealMatrix(new double[][] { new double[] { 1 } }));
        Assert.Throws<InvalidDimensionException>(() => _matrixMath.MatrixAddition(_matrix1, _matrix3));
    }

    [Test]
    public void MatrixMultiplication_ValidInput_ReturnsCorrectResult()
    {
        _resultMatrix = _matrixMath.MatrixMultiplication(_matrix1, _matrix2);
        Assert.AreEqual(new double[,] { { 19, 22 }, { 43, 50 } }, _resultMatrix.GetRealMatrix().GetData());
    }

    [Test]
    public void MatrixMultiplication_InvalidDimension_ThrowsException()
    {
        var _matrix3 = new MatrixMock(new RealMatrix(new double[][] { new double[] { 1, 2, 3 } }));
        Assert.Throws<InvalidDimensionException>(() => _matrixMath.MatrixMultiplication(_matrix1, _matrix3));
    }

    [Test]
    public void MatrixSubtracting_ValidInput_ReturnsCorrectResult()
    {
        _resultMatrix = _matrixMath.MatrixSubtracting(_matrix1, _matrix2);
        Assert.AreEqual(new double[,] { { -4, -4 }, { -4, -4 } }, _resultMatrix.GetRealMatrix().GetData());
    }

    [Test]
    public void MatrixSubtracting_InvalidDimension_ThrowsException()
    {
        var _matrix3 = new MatrixMock(new RealMatrix(new double[][] { new double[] { 1 } }));
        Assert.Throws<InvalidDimensionException>(() => _matrixMath.MatrixSubtracting(_matrix1, _matrix3));
    }

    [Test]
    public void MatrixTransposition_ValidInput_ReturnsCorrectResult()
    {
        _resultMatrix = _matrixMath.MatrixTransposition(_matrix1);
        Assert.AreEqual(new double[,] { { 1, 3 }, { 2, 4 } }, _resultMatrix.GetRealMatrix().GetData());
    }

    [Test]
    public void ScalarMultiplication_ValidInput_ReturnsCorrectResult()
    {
        _resultMatrix = _matrixMath.ScalarMultiplication(_matrix1, 2);
        Assert.AreEqual(new double[,] { { 2, 4 }, { 6, 8 } }, _resultMatrix.GetRealMatrix().GetData());
    }

    private class MatrixMock : IMatrix
    {
        private RealMatrix _realMatrix;

        public MatrixMock(RealMatrix realMatrix)
        {
            _realMatrix = realMatrix;
        }

        public RealMatrix GetRealMatrix() => _realMatrix;

        public IMatrix CreateIMatrix(RealMatrix realMatrix)
        {
            return new MatrixMock(realMatrix);
        }

        public int GetHeight() => _realMatrix.GetRowDimension();

        public int GetWidth() => _realMatrix.GetColumnDimension();
    }
}
*/