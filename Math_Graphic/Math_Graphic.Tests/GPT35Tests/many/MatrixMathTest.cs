using Math_Graphic.core.math.matrix;
using Math_Graphic.core.math.modules;
using NUnit.Framework;

/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Dodana klasa pomocnicza nie implementowała całego interface
 */

namespace Math_Graphic.Tests.GPT35.alsoWithContext
{
    [TestFixture]
    public class MatrixMathTests
    {
        private MatrixMath _matrixMath;
        private IMatrix _matrix1;
        private IMatrix _matrix2;

        [SetUp]
        public void SetUp()
        {
            _matrixMath = new MatrixMath();
            _matrix1 = new MatrixMock(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            _matrix2 = new MatrixMock(new double[][]
            {
                new double[] { 5, 6 },
                new double[] { 7, 8 }
            });
        }

        [Test]
        public void InverseMatrix_ValidMatrix_ReturnsInverseMatrix()
        {
            var result = _matrixMath.InverseMatrix(_matrix1);
            var expected = new double[][]
            {
                new double[] { -2, 1 },
                new double[] { 1.5, -0.5 }
            };
            AssertMatrixEquality(expected, result);
        }

        [Test]
        public void MatrixAddition_ValidMatrices_ReturnsSumMatrix()
        {
            var result = _matrixMath.MatrixAddition(_matrix1, _matrix2);
            var expected = new double[][]
            {
                new double[] { 6, 8 },
                new double[] { 10, 12 }
            };
            AssertMatrixEquality(expected, result);
        }

        [Test]
        public void MatrixMultiplication_ValidMatrices_ReturnsProductMatrix()
        {
            var result = _matrixMath.MatrixMultiplication(_matrix1, _matrix2);
            var expected = new double[][]
            {
                new double[] { 19, 22 },
                new double[] { 43, 50 }
            };
            AssertMatrixEquality(expected, result);
        }

        [Test]
        public void MatrixSubtracting_ValidMatrices_ReturnsDifferenceMatrix()
        {
            var result = _matrixMath.MatrixSubtracting(_matrix1, _matrix2);
            var expected = new double[][]
            {
                new double[] { -4, -4 },
                new double[] { -4, -4 }
            };
            AssertMatrixEquality(expected, result);
        }

        [Test]
        public void MatrixTransposition_ValidMatrix_ReturnsTransposedMatrix()
        {
            var result = _matrixMath.MatrixTransposition(_matrix1);
            var expected = new double[][]
            {
                new double[] { 1, 3 },
                new double[] { 2, 4 }
            };
            AssertMatrixEquality(expected, result);
        }

        [Test]
        public void ScalarMultiplication_ValidMatrixAndScalar_ReturnsScaledMatrix()
        {
            var result = _matrixMath.ScalarMultiplication(_matrix1, 2);
            var expected = new double[][]
            {
                new double[] { 2, 4 },
                new double[] { 6, 8 }
            };
            AssertMatrixEquality(expected, result);
        }

        private void AssertMatrixEquality(double[][] expected, IMatrix result)
        {
            var resultData = result.GetRealMatrix().GetData();
            Assert.AreEqual(expected.Length, resultData.Length);
            for (var i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i].Length, resultData[i].Length);
                for (var j = 0; j < expected[i].Length; j++)
                {
                    Assert.AreEqual(expected[i][j], resultData[i][j], 1e-10);
                }
            }
        }
    }

    public class MatrixMock : IMatrix
    {
        private readonly RealMatrix _realMatrix;

        public MatrixMock(double[][] data)
        {
            _realMatrix = new RealMatrix(data);
        }

        public RealMatrix GetRealMatrix() => _realMatrix;

        public IMatrix CreateIMatrix(RealMatrix realMatrix) => new MatrixMock(realMatrix.GetData());

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
using Math_Graphic.core.math.matrix;
using Math_Graphic.core.math.modules;
using NUnit.Framework;

namespace Math_Graphic.Tests
{
    [TestFixture]
    public class MatrixMathTests
    {
        private MatrixMath _matrixMath;
        private IMatrix _matrix1;
        private IMatrix _matrix2;

        [SetUp]
        public void SetUp()
        {
            _matrixMath = new MatrixMath();
            _matrix1 = new MatrixMock(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            _matrix2 = new MatrixMock(new double[][]
            {
                new double[] { 5, 6 },
                new double[] { 7, 8 }
            });
        }

        [Test]
        public void InverseMatrix_ValidMatrix_ReturnsInverseMatrix()
        {
            var result = _matrixMath.InverseMatrix(_matrix1);
            var expected = new double[][]
            {
                new double[] { -2, 1 },
                new double[] { 1.5, -0.5 }
            };
            AssertMatrixEquality(expected, result);
        }

        [Test]
        public void MatrixAddition_ValidMatrices_ReturnsSumMatrix()
        {
            var result = _matrixMath.MatrixAddition(_matrix1, _matrix2);
            var expected = new double[][]
            {
                new double[] { 6, 8 },
                new double[] { 10, 12 }
            };
            AssertMatrixEquality(expected, result);
        }

        [Test]
        public void MatrixMultiplication_ValidMatrices_ReturnsProductMatrix()
        {
            var result = _matrixMath.MatrixMultiplication(_matrix1, _matrix2);
            var expected = new double[][]
            {
                new double[] { 19, 22 },
                new double[] { 43, 50 }
            };
            AssertMatrixEquality(expected, result);
        }

        [Test]
        public void MatrixSubtracting_ValidMatrices_ReturnsDifferenceMatrix()
        {
            var result = _matrixMath.MatrixSubtracting(_matrix1, _matrix2);
            var expected = new double[][]
            {
                new double[] { -4, -4 },
                new double[] { -4, -4 }
            };
            AssertMatrixEquality(expected, result);
        }

        [Test]
        public void MatrixTransposition_ValidMatrix_ReturnsTransposedMatrix()
        {
            var result = _matrixMath.MatrixTransposition(_matrix1);
            var expected = new double[][]
            {
                new double[] { 1, 3 },
                new double[] { 2, 4 }
            };
            AssertMatrixEquality(expected, result);
        }

        [Test]
        public void ScalarMultiplication_ValidMatrixAndScalar_ReturnsScaledMatrix()
        {
            var result = _matrixMath.ScalarMultiplication(_matrix1, 2);
            var expected = new double[][]
            {
                new double[] { 2, 4 },
                new double[] { 6, 8 }
            };
            AssertMatrixEquality(expected, result);
        }

        private void AssertMatrixEquality(double[][] expected, IMatrix result)
        {
            var resultData = result.GetRealMatrix().GetData();
            Assert.AreEqual(expected.Length, resultData.Length);
            for (var i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i].Length, resultData[i].Length);
                for (var j = 0; j < expected[i].Length; j++)
                {
                    Assert.AreEqual(expected[i][j], resultData[i][j], 1e-10);
                }
            }
        }
    }

    public class MatrixMock : IMatrix
    {
        private readonly RealMatrix _realMatrix;

        public MatrixMock(double[][] data)
        {
            _realMatrix = new RealMatrix(data);
        }

        public RealMatrix GetRealMatrix() => _realMatrix;

        public IMatrix CreateIMatrix(RealMatrix realMatrix) => new MatrixMock(realMatrix.GetData());

        public int GetHeight() => _realMatrix.GetRowDimension();

        public int GetWidth() => _realMatrix.GetColumnDimension();
    }
}
*/