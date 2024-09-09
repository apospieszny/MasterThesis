using NUnit.Framework;
using Math_Graphic.core.math.matrix;
using Math_Graphic.core.math.modules;

/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 */

namespace Math_Graphic.Tests.GPT35.alsoFirst
{
    [TestFixture]
    public class MatrixMathTests
    {
        private MatrixMath _matrixMath;

        [SetUp]
        public void Setup()
        {
            _matrixMath = new MatrixMath();
        }
        /* Test odrzucony
        [Test]
        public void InverseMatrix_ValidMatrix_ReturnsInverseMatrix()
        {
            var matrix = MatrixUtils.CreateRealMatrix(new double[][]
            {
                new double[] { 4, 7 },
                new double[] { 2, 6 }
            });
            var imatrix = new Matrix(matrix);
            var result = _matrixMath.InverseMatrix(imatrix);

            var expected = MatrixUtils.CreateRealMatrix(new double[][]
            {
                new double[] { 0.6, -0.7 },
                new double[] { -0.2, 0.4 }
            });
            var expectedIMatrix = new Matrix(expected);

            AssertMatricesAreEqual(expectedIMatrix, result);
        }*/

        [Test]
        public void MatrixAddition_ValidMatrices_ReturnsSumMatrix()
        {
            var matrix1 = MatrixUtils.CreateRealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var matrix2 = MatrixUtils.CreateRealMatrix(new double[][]
            {
                new double[] { 5, 6 },
                new double[] { 7, 8 }
            });
            var imatrix1 = new Matrix(matrix1);
            var imatrix2 = new Matrix(matrix2);
            var result = _matrixMath.MatrixAddition(imatrix1, imatrix2);

            var expected = MatrixUtils.CreateRealMatrix(new double[][]
            {
                new double[] { 6, 8 },
                new double[] { 10, 12 }
            });
            var expectedIMatrix = new Matrix(expected);

            AssertMatricesAreEqual(expectedIMatrix, result);
        }

        [Test]
        public void MatrixMultiplication_ValidMatrices_ReturnsProductMatrix()
        {
            var matrix1 = MatrixUtils.CreateRealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var matrix2 = MatrixUtils.CreateRealMatrix(new double[][]
            {
                new double[] { 5, 6 },
                new double[] { 7, 8 }
            });
            var imatrix1 = new Matrix(matrix1);
            var imatrix2 = new Matrix(matrix2);
            var result = _matrixMath.MatrixMultiplication(imatrix1, imatrix2);

            var expected = MatrixUtils.CreateRealMatrix(new double[][]
            {
                new double[] { 19, 22 },
                new double[] { 43, 50 }
            });
            var expectedIMatrix = new Matrix(expected);

            AssertMatricesAreEqual(expectedIMatrix, result);
        }

        [Test]
        public void MatrixSubtracting_ValidMatrices_ReturnsDifferenceMatrix()
        {
            var matrix1 = MatrixUtils.CreateRealMatrix(new double[][]
            {
                new double[] { 5, 6 },
                new double[] { 7, 8 }
            });
            var matrix2 = MatrixUtils.CreateRealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var imatrix1 = new Matrix(matrix1);
            var imatrix2 = new Matrix(matrix2);
            var result = _matrixMath.MatrixSubtracting(imatrix1, imatrix2);

            var expected = MatrixUtils.CreateRealMatrix(new double[][]
            {
                new double[] { 4, 4 },
                new double[] { 4, 4 }
            });
            var expectedIMatrix = new Matrix(expected);

            AssertMatricesAreEqual(expectedIMatrix, result);
        }

        [Test]
        public void MatrixTransposition_ValidMatrix_ReturnsTransposedMatrix()
        {
            var matrix = MatrixUtils.CreateRealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var imatrix = new Matrix(matrix);
            var result = _matrixMath.MatrixTransposition(imatrix);

            var expected = MatrixUtils.CreateRealMatrix(new double[][]
            {
                new double[] { 1, 3 },
                new double[] { 2, 4 }
            });
            var expectedIMatrix = new Matrix(expected);

            AssertMatricesAreEqual(expectedIMatrix, result);
        }

        [Test]
        public void ScalarMultiplication_ValidMatrix_ReturnsScaledMatrix()
        {
            var matrix = MatrixUtils.CreateRealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var imatrix = new Matrix(matrix);
            var result = _matrixMath.ScalarMultiplication(imatrix, 2);

            var expected = MatrixUtils.CreateRealMatrix(new double[][]
            {
                new double[] { 2, 4 },
                new double[] { 6, 8 }
            });
            var expectedIMatrix = new Matrix(expected);

            AssertMatricesAreEqual(expectedIMatrix, result);
        }

        [Test]
        public void MatrixAddition_InvalidDimensions_ThrowsInvalidDimensionException()
        {
            var matrix1 = MatrixUtils.CreateRealMatrix(new double[][]
            {
                new double[] { 1, 2 }
            });
            var matrix2 = MatrixUtils.CreateRealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var imatrix1 = new Matrix(matrix1);
            var imatrix2 = new Matrix(matrix2);

            Assert.Throws<InvalidDimensionException>(() => _matrixMath.MatrixAddition(imatrix1, imatrix2));
        }
        /* Test odrzucony
        [Test]
        public void MatrixMultiplication_InvalidDimensions_ThrowsInvalidDimensionException()
        {
            var matrix1 = MatrixUtils.CreateRealMatrix(new double[][]
            {
                new double[] { 1, 2 }
            });
            var matrix2 = MatrixUtils.CreateRealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var imatrix1 = new Matrix(matrix1);
            var imatrix2 = new Matrix(matrix2);

            Assert.Throws<InvalidDimensionException>(() => _matrixMath.MatrixMultiplication(imatrix1, imatrix2));
        }*/

        private void AssertMatricesAreEqual(IMatrix expected, IMatrix actual)
        {
            var expectedData = expected.GetRealMatrix().GetData();
            var actualData = actual.GetRealMatrix().GetData();

            Assert.AreEqual(expectedData.Length, actualData.Length, "Row dimensions are different");

            for (var i = 0; i < expectedData.Length; i++)
            {
                Assert.AreEqual(expectedData[i].Length, actualData[i].Length, $"Column dimensions are different for row {i}");

                for (var j = 0; j < expectedData[i].Length; j++)
                {
                    Assert.AreEqual(expectedData[i][j], actualData[i][j], $"Values at position ({i},{j}) are different");
                }
            }
        }
    }
}

/*
using NUnit.Framework;
using Math_Graphic.core.math.matrix;
using Math_Graphic.core.math.modules;

namespace Math_Graphic.Tests
{
    [TestFixture]
    public class MatrixMathTests
    {
        private MatrixMath _matrixMath;

        [SetUp]
        public void Setup()
        {
            _matrixMath = new MatrixMath();
        }

        [Test]
        public void InverseMatrix_ValidMatrix_ReturnsInverseMatrix()
        {
            var matrix = MatrixUtils.CreateRealMatrix(new double[][]
            {
                new double[] { 4, 7 },
                new double[] { 2, 6 }
            });
            var imatrix = new Matrix(matrix);
            var result = _matrixMath.InverseMatrix(imatrix);

            var expected = MatrixUtils.CreateRealMatrix(new double[][]
            {
                new double[] { 0.6, -0.7 },
                new double[] { -0.2, 0.4 }
            });
            var expectedIMatrix = new Matrix(expected);

            AssertMatricesAreEqual(expectedIMatrix, result);
        }

        [Test]
        public void MatrixAddition_ValidMatrices_ReturnsSumMatrix()
        {
            var matrix1 = MatrixUtils.CreateRealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var matrix2 = MatrixUtils.CreateRealMatrix(new double[][]
            {
                new double[] { 5, 6 },
                new double[] { 7, 8 }
            });
            var imatrix1 = new Matrix(matrix1);
            var imatrix2 = new Matrix(matrix2);
            var result = _matrixMath.MatrixAddition(imatrix1, imatrix2);

            var expected = MatrixUtils.CreateRealMatrix(new double[][]
            {
                new double[] { 6, 8 },
                new double[] { 10, 12 }
            });
            var expectedIMatrix = new Matrix(expected);

            AssertMatricesAreEqual(expectedIMatrix, result);
        }

        [Test]
        public void MatrixMultiplication_ValidMatrices_ReturnsProductMatrix()
        {
            var matrix1 = MatrixUtils.CreateRealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var matrix2 = MatrixUtils.CreateRealMatrix(new double[][]
            {
                new double[] { 5, 6 },
                new double[] { 7, 8 }
            });
            var imatrix1 = new Matrix(matrix1);
            var imatrix2 = new Matrix(matrix2);
            var result = _matrixMath.MatrixMultiplication(imatrix1, imatrix2);

            var expected = MatrixUtils.CreateRealMatrix(new double[][]
            {
                new double[] { 19, 22 },
                new double[] { 43, 50 }
            });
            var expectedIMatrix = new Matrix(expected);

            AssertMatricesAreEqual(expectedIMatrix, result);
        }

        [Test]
        public void MatrixSubtracting_ValidMatrices_ReturnsDifferenceMatrix()
        {
            var matrix1 = MatrixUtils.CreateRealMatrix(new double[][]
            {
                new double[] { 5, 6 },
                new double[] { 7, 8 }
            });
            var matrix2 = MatrixUtils.CreateRealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var imatrix1 = new Matrix(matrix1);
            var imatrix2 = new Matrix(matrix2);
            var result = _matrixMath.MatrixSubtracting(imatrix1, imatrix2);

            var expected = MatrixUtils.CreateRealMatrix(new double[][]
            {
                new double[] { 4, 4 },
                new double[] { 4, 4 }
            });
            var expectedIMatrix = new Matrix(expected);

            AssertMatricesAreEqual(expectedIMatrix, result);
        }

        [Test]
        public void MatrixTransposition_ValidMatrix_ReturnsTransposedMatrix()
        {
            var matrix = MatrixUtils.CreateRealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var imatrix = new Matrix(matrix);
            var result = _matrixMath.MatrixTransposition(imatrix);

            var expected = MatrixUtils.CreateRealMatrix(new double[][]
            {
                new double[] { 1, 3 },
                new double[] { 2, 4 }
            });
            var expectedIMatrix = new Matrix(expected);

            AssertMatricesAreEqual(expectedIMatrix, result);
        }

        [Test]
        public void ScalarMultiplication_ValidMatrix_ReturnsScaledMatrix()
        {
            var matrix = MatrixUtils.CreateRealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var imatrix = new Matrix(matrix);
            var result = _matrixMath.ScalarMultiplication(imatrix, 2);

            var expected = MatrixUtils.CreateRealMatrix(new double[][]
            {
                new double[] { 2, 4 },
                new double[] { 6, 8 }
            });
            var expectedIMatrix = new Matrix(expected);

            AssertMatricesAreEqual(expectedIMatrix, result);
        }

        [Test]
        public void MatrixAddition_InvalidDimensions_ThrowsInvalidDimensionException()
        {
            var matrix1 = MatrixUtils.CreateRealMatrix(new double[][]
            {
                new double[] { 1, 2 }
            });
            var matrix2 = MatrixUtils.CreateRealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var imatrix1 = new Matrix(matrix1);
            var imatrix2 = new Matrix(matrix2);

            Assert.Throws<InvalidDimensionException>(() => _matrixMath.MatrixAddition(imatrix1, imatrix2));
        }

        [Test]
        public void MatrixMultiplication_InvalidDimensions_ThrowsInvalidDimensionException()
        {
            var matrix1 = MatrixUtils.CreateRealMatrix(new double[][]
            {
                new double[] { 1, 2 }
            });
            var matrix2 = MatrixUtils.CreateRealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var imatrix1 = new Matrix(matrix1);
            var imatrix2 = new Matrix(matrix2);

            Assert.Throws<InvalidDimensionException>(() => _matrixMath.MatrixMultiplication(imatrix1, imatrix2));
        }

        private void AssertMatricesAreEqual(IMatrix expected, IMatrix actual)
        {
            var expectedData = expected.GetRealMatrix().GetData();
            var actualData = actual.GetRealMatrix().GetData();

            Assert.AreEqual(expectedData.Length, actualData.Length, "Row dimensions are different");

            for (var i = 0; i < expectedData.Length; i++)
            {
                Assert.AreEqual(expectedData[i].Length, actualData[i].Length, $"Column dimensions are different for row {i}");

                for (var j = 0; j < expectedData[i].Length; j++)
                {
                    Assert.AreEqual(expectedData[i][j], actualData[i][j], $"Values at position ({i},{j}) are different");
                }
            }
        }
    }
}
*/