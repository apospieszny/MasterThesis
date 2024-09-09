using NUnit.Framework;
using Math_Graphic.core.math.modules;
using Math_Graphic.core.math.matrix;

/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Dodana klasa pomocnicza nie implementowała całego interface
 */

namespace Math_Graphic.Tests.GPT35.first
{
    [TestFixture]
    public class MatrixMathTests
    {
        private MatrixMath _matrixMath;

        [SetUp]
        public void SetUp()
        {
            _matrixMath = new MatrixMath();
        }

        [Test]
        public void InverseMatrix_ValidMatrix_ReturnsInverse()
        {
            var matrix = new RealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });

            var imatrix = new TestMatrix(matrix);
            var result = _matrixMath.InverseMatrix(imatrix);

            var expectedInverse = new RealMatrix(new double[][]
            {
                new double[] { -2, 1 },
                new double[] { 1.5, -0.5 }
            });

            AssertMatricesEqual(expectedInverse, result.GetRealMatrix());
        }

        [Test]
        public void MatrixAddition_ValidMatrices_ReturnsSum()
        {
            var matrix1 = new RealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });

            var matrix2 = new RealMatrix(new double[][]
            {
                new double[] { 5, 6 },
                new double[] { 7, 8 }
            });

            var imatrix1 = new TestMatrix(matrix1);
            var imatrix2 = new TestMatrix(matrix2);
            var result = _matrixMath.MatrixAddition(imatrix1, imatrix2);

            var expectedSum = new RealMatrix(new double[][]
            {
                new double[] { 6, 8 },
                new double[] { 10, 12 }
            });

            AssertMatricesEqual(expectedSum, result.GetRealMatrix());
        }

        [Test]
        public void MatrixMultiplication_ValidMatrices_ReturnsProduct()
        {
            var matrix1 = new RealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });

            var matrix2 = new RealMatrix(new double[][]
            {
                new double[] { 5, 6 },
                new double[] { 7, 8 }
            });

            var imatrix1 = new TestMatrix(matrix1);
            var imatrix2 = new TestMatrix(matrix2);
            var result = _matrixMath.MatrixMultiplication(imatrix1, imatrix2);

            var expectedProduct = new RealMatrix(new double[][]
            {
                new double[] { 19, 22 },
                new double[] { 43, 50 }
            });

            AssertMatricesEqual(expectedProduct, result.GetRealMatrix());
        }

        [Test]
        public void MatrixSubtracting_ValidMatrices_ReturnsDifference()
        {
            var matrix1 = new RealMatrix(new double[][]
            {
                new double[] { 5, 6 },
                new double[] { 7, 8 }
            });

            var matrix2 = new RealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });

            var imatrix1 = new TestMatrix(matrix1);
            var imatrix2 = new TestMatrix(matrix2);
            var result = _matrixMath.MatrixSubtracting(imatrix1, imatrix2);

            var expectedDifference = new RealMatrix(new double[][]
            {
                new double[] { 4, 4 },
                new double[] { 4, 4 }
            });

            AssertMatricesEqual(expectedDifference, result.GetRealMatrix());
        }

        [Test]
        public void MatrixTransposition_ValidMatrix_ReturnsTranspose()
        {
            var matrix = new RealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });

            var imatrix = new TestMatrix(matrix);
            var result = _matrixMath.MatrixTransposition(imatrix);

            var expectedTranspose = new RealMatrix(new double[][]
            {
                new double[] { 1, 3 },
                new double[] { 2, 4 }
            });

            AssertMatricesEqual(expectedTranspose, result.GetRealMatrix());
        }

        [Test]
        public void ScalarMultiplication_ValidMatrix_ReturnsScaledMatrix()
        {
            var matrix = new RealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });

            var imatrix = new TestMatrix(matrix);
            var result = _matrixMath.ScalarMultiplication(imatrix, 2.0);

            var expectedScaledMatrix = new RealMatrix(new double[][]
            {
                new double[] { 2, 4 },
                new double[] { 6, 8 }
            });

            AssertMatricesEqual(expectedScaledMatrix, result.GetRealMatrix());
        }

        private void AssertMatricesEqual(RealMatrix expected, RealMatrix actual)
        {
            Assert.AreEqual(expected.GetRowDimension(), actual.GetRowDimension());
            Assert.AreEqual(expected.GetColumnDimension(), actual.GetColumnDimension());

            for (int i = 0; i < expected.GetRowDimension(); i++)
            {
                for (int j = 0; j < expected.GetColumnDimension(); j++)
                {
                    Assert.AreEqual(expected.GetData()[i][j], actual.GetData()[i][j], 1e-10);
                }
            }
        }
    }

    // Dummy implementation for IMatrix
    public class TestMatrix : IMatrix
    {
        private readonly RealMatrix _realMatrix;

        public TestMatrix(RealMatrix realMatrix)
        {
            _realMatrix = realMatrix;
        }

        public RealMatrix GetRealMatrix()
        {
            return _realMatrix;
        }

        public IMatrix CreateIMatrix(RealMatrix realMatrix)
        {
            return new TestMatrix(realMatrix);
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
using Math_Graphic.core.math.modules;
using Math_Graphic.core.math.matrix;

namespace Math_Graphic.Tests
{
    [TestFixture]
    public class MatrixMathTests
    {
        private MatrixMath _matrixMath;

        [SetUp]
        public void SetUp()
        {
            _matrixMath = new MatrixMath();
        }

        [Test]
        public void InverseMatrix_ValidMatrix_ReturnsInverse()
        {
            var matrix = new RealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });

            var imatrix = new TestMatrix(matrix);
            var result = _matrixMath.InverseMatrix(imatrix);

            var expectedInverse = new RealMatrix(new double[][]
            {
                new double[] { -2, 1 },
                new double[] { 1.5, -0.5 }
            });

            AssertMatricesEqual(expectedInverse, result.GetRealMatrix());
        }

        [Test]
        public void MatrixAddition_ValidMatrices_ReturnsSum()
        {
            var matrix1 = new RealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });

            var matrix2 = new RealMatrix(new double[][]
            {
                new double[] { 5, 6 },
                new double[] { 7, 8 }
            });

            var imatrix1 = new TestMatrix(matrix1);
            var imatrix2 = new TestMatrix(matrix2);
            var result = _matrixMath.MatrixAddition(imatrix1, imatrix2);

            var expectedSum = new RealMatrix(new double[][]
            {
                new double[] { 6, 8 },
                new double[] { 10, 12 }
            });

            AssertMatricesEqual(expectedSum, result.GetRealMatrix());
        }

        [Test]
        public void MatrixMultiplication_ValidMatrices_ReturnsProduct()
        {
            var matrix1 = new RealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });

            var matrix2 = new RealMatrix(new double[][]
            {
                new double[] { 5, 6 },
                new double[] { 7, 8 }
            });

            var imatrix1 = new TestMatrix(matrix1);
            var imatrix2 = new TestMatrix(matrix2);
            var result = _matrixMath.MatrixMultiplication(imatrix1, imatrix2);

            var expectedProduct = new RealMatrix(new double[][]
            {
                new double[] { 19, 22 },
                new double[] { 43, 50 }
            });

            AssertMatricesEqual(expectedProduct, result.GetRealMatrix());
        }

        [Test]
        public void MatrixSubtracting_ValidMatrices_ReturnsDifference()
        {
            var matrix1 = new RealMatrix(new double[][]
            {
                new double[] { 5, 6 },
                new double[] { 7, 8 }
            });

            var matrix2 = new RealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });

            var imatrix1 = new TestMatrix(matrix1);
            var imatrix2 = new TestMatrix(matrix2);
            var result = _matrixMath.MatrixSubtracting(imatrix1, imatrix2);

            var expectedDifference = new RealMatrix(new double[][]
            {
                new double[] { 4, 4 },
                new double[] { 4, 4 }
            });

            AssertMatricesEqual(expectedDifference, result.GetRealMatrix());
        }

        [Test]
        public void MatrixTransposition_ValidMatrix_ReturnsTranspose()
        {
            var matrix = new RealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });

            var imatrix = new TestMatrix(matrix);
            var result = _matrixMath.MatrixTransposition(imatrix);

            var expectedTranspose = new RealMatrix(new double[][]
            {
                new double[] { 1, 3 },
                new double[] { 2, 4 }
            });

            AssertMatricesEqual(expectedTranspose, result.GetRealMatrix());
        }

        [Test]
        public void ScalarMultiplication_ValidMatrix_ReturnsScaledMatrix()
        {
            var matrix = new RealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });

            var imatrix = new TestMatrix(matrix);
            var result = _matrixMath.ScalarMultiplication(imatrix, 2.0);

            var expectedScaledMatrix = new RealMatrix(new double[][]
            {
                new double[] { 2, 4 },
                new double[] { 6, 8 }
            });

            AssertMatricesEqual(expectedScaledMatrix, result.GetRealMatrix());
        }

        private void AssertMatricesEqual(RealMatrix expected, RealMatrix actual)
        {
            Assert.AreEqual(expected.GetRowDimension(), actual.GetRowDimension());
            Assert.AreEqual(expected.GetColumnDimension(), actual.GetColumnDimension());

            for (int i = 0; i < expected.GetRowDimension(); i++)
            {
                for (int j = 0; j < expected.GetColumnDimension(); j++)
                {
                    Assert.AreEqual(expected.GetData()[i][j], actual.GetData()[i][j], 1e-10);
                }
            }
        }
    }

    // Dummy implementation for IMatrix
    public class TestMatrix : IMatrix
    {
        private readonly RealMatrix _realMatrix;

        public TestMatrix(RealMatrix realMatrix)
        {
            _realMatrix = realMatrix;
        }

        public RealMatrix GetRealMatrix()
        {
            return _realMatrix;
        }

        public IMatrix CreateIMatrix(RealMatrix realMatrix)
        {
            return new TestMatrix(realMatrix);
        }

        public int GetHeight() => _realMatrix.GetRowDimension();
        public int GetWidth() => _realMatrix.GetColumnDimension();
    }
}
*/