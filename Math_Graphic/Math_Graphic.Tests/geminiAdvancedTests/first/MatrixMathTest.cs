using Math_Graphic.core.math.matrix;
using Math_Graphic.core.math.modules;
using NUnit.Framework;

/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 * Zmiana konwersji w metodach
 */

namespace Math_Graphic.Tests.geminiAdvanced.first
{
    [TestFixture]
    public class MatrixMathTests
    {
        private IMatrixMath _matrixMath;

        [SetUp]
        public void Setup()
        {
            _matrixMath = new MatrixMath();
        }
        /* Test odrzucony
        [Test]
        public void InverseMatrix_ValidMatrix_ReturnsInverse()
        {
            // Arrange
            var matrix = new RealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var expectedInverse = new RealMatrix(new double[][]
            {
                new double[] { -2, 1 },
                new double[] { 1.5, -0.5 }
            });

            // Act
            var actualInverse = _matrixMath.InverseMatrix((IMatrix) matrix);

            // Assert
            Assert.AreEqual(expectedInverse.GetData(), actualInverse.GetRealMatrix().GetData());
        }

        [Test]
        public void MatrixAddition_ValidMatrices_ReturnsSum()
        {
            // Arrange
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
            var expectedSum = new RealMatrix(new double[][]
            {
                new double[] { 6, 8 },
                new double[] { 10, 12 }
            });

            // Act
            var actualSum = _matrixMath.MatrixAddition((IMatrix)matrix1, (IMatrix)matrix2);

            // Assert
            Assert.AreEqual(expectedSum.GetData(), actualSum.GetRealMatrix().GetData());
        }

        [Test]
        public void MatrixAddition_InvalidDimensions_ThrowsInvalidDimensionException()
        {
            // Arrange
            var matrix1 = new RealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var matrix2 = new RealMatrix(new double[][]
            {
                new double[] { 5, 6, 7 }
            });

            // Act & Assert
            Assert.Throws<InvalidDimensionException>(() => _matrixMath.MatrixAddition((IMatrix)matrix1, (IMatrix)matrix2));
        }

        [Test]
        public void MatrixMultiplication_ValidMatrices_ReturnsProduct()
        {
            // Arrange
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
            var expectedProduct = new RealMatrix(new double[][]
            {
                new double[] { 19, 22 },
                new double[] { 43, 50 }
            });

            // Act
            var actualProduct = _matrixMath.MatrixMultiplication((IMatrix)matrix1, (IMatrix) matrix2);

            // Assert
            Assert.AreEqual(expectedProduct.GetData(), actualProduct.GetRealMatrix().GetData());
        }

        [Test]
        public void MatrixMultiplication_InvalidDimensions_ThrowsInvalidDimensionException()
        {
            // Arrange
            var matrix1 = new RealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var matrix2 = new RealMatrix(new double[][]
            {
                new double[] { 5 },
                new double[] { 6 },
                new double[] { 7 }
            });

            // Act & Assert
            Assert.Throws<InvalidDimensionException>(() => _matrixMath.MatrixMultiplication((IMatrix)matrix1, (IMatrix)matrix2));
        }

        [Test]
        public void MatrixSubtracting_ValidMatrices_ReturnsDifference()
        {
            // Arrange
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
            var expectedDifference = new RealMatrix(new double[][]
            {
                new double[] { -4, -4 },
                new double[] { -4, -4 }
            });

            // Act
            var actualDifference = _matrixMath.MatrixSubtracting((IMatrix)matrix1, (IMatrix)matrix2);

            // Assert
            Assert.AreEqual(expectedDifference.GetData(), actualDifference.GetRealMatrix().GetData());
        }

        [Test]
        public void MatrixSubtracting_InvalidDimensions_ThrowsInvalidDimensionException()
        {
            // Arrange
            var matrix1 = new RealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var matrix2 = new RealMatrix(new double[][]
            {
                new double[] { 5, 6, 7 }
            });

            // Act & Assert
            Assert.Throws<InvalidDimensionException>(() => _matrixMath.MatrixSubtracting((IMatrix)matrix1, (IMatrix)matrix2));
        }

        [Test]
        public void MatrixTransposition_ValidMatrix_ReturnsTranspose()
        {
            // Arrange
            var matrix = new RealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var expectedTranspose = new RealMatrix(new double[][]
            {
                new double[] { 1, 3 },
                new double[] { 2, 4 }
            });

            // Act
            var actualTranspose = _matrixMath.MatrixTransposition((IMatrix)matrix);

            // Assert
            Assert.AreEqual(expectedTranspose.GetData(), actualTranspose.GetRealMatrix().GetData());
        }

        [Test]
        public void ScalarMultiplication_ValidMatrixAndScalar_ReturnsProduct()
        {
            // Arrange
            var matrix = new RealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var scalar = 2.0;
            var expectedProduct = new RealMatrix(new double[][]
            {
                new double[] { 2, 4 },
                new double[] { 6, 8 }
            });

            // Act
            var actualProduct = _matrixMath.ScalarMultiplication((IMatrix)matrix, scalar);

            // Assert
            Assert.AreEqual(expectedProduct.GetData(), actualProduct.GetRealMatrix().GetData());
        }*/
    }
}

/*
using Math_Graphic.core.math.matrix;
using Math_Graphic.core.math.modules;
using NUnit.Framework;

namespace Math_Graphic.Tests.Core.Math.Matrix
{
    [TestFixture]
    public class MatrixMathTests
    {
        private IMatrixMath _matrixMath;

        [SetUp]
        public void Setup()
        {
            _matrixMath = new MatrixMath();
        }

        [Test]
        public void InverseMatrix_ValidMatrix_ReturnsInverse()
        {
            // Arrange
            var matrix = new RealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var expectedInverse = new RealMatrix(new double[][]
            {
                new double[] { -2, 1 },
                new double[] { 1.5, -0.5 }
            });

            // Act
            var actualInverse = _matrixMath.InverseMatrix(matrix);

            // Assert
            Assert.AreEqual(expectedInverse.GetData(), actualInverse.GetRealMatrix().GetData());
        }

        [Test]
        public void MatrixAddition_ValidMatrices_ReturnsSum()
        {
            // Arrange
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
            var expectedSum = new RealMatrix(new double[][]
            {
                new double[] { 6, 8 },
                new double[] { 10, 12 }
            });

            // Act
            var actualSum = _matrixMath.MatrixAddition(matrix1, matrix2);

            // Assert
            Assert.AreEqual(expectedSum.GetData(), actualSum.GetRealMatrix().GetData());
        }

        [Test]
        public void MatrixAddition_InvalidDimensions_ThrowsInvalidDimensionException()
        {
            // Arrange
            var matrix1 = new RealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var matrix2 = new RealMatrix(new double[][]
            {
                new double[] { 5, 6, 7 }
            });

            // Act & Assert
            Assert.Throws<InvalidDimensionException>(() => _matrixMath.MatrixAddition(matrix1, matrix2));
        }

        [Test]
        public void MatrixMultiplication_ValidMatrices_ReturnsProduct()
        {
            // Arrange
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
            var expectedProduct = new RealMatrix(new double[][]
            {
                new double[] { 19, 22 },
                new double[] { 43, 50 }
            });

            // Act
            var actualProduct = _matrixMath.MatrixMultiplication(matrix1, matrix2);

            // Assert
            Assert.AreEqual(expectedProduct.GetData(), actualProduct.GetRealMatrix().GetData());
        }

        [Test]
        public void MatrixMultiplication_InvalidDimensions_ThrowsInvalidDimensionException()
        {
            // Arrange
            var matrix1 = new RealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var matrix2 = new RealMatrix(new double[][]
            {
                new double[] { 5 },
                new double[] { 6 },
                new double[] { 7 }
            });

            // Act & Assert
            Assert.Throws<InvalidDimensionException>(() => _matrixMath.MatrixMultiplication(matrix1, matrix2));
        }

        [Test]
        public void MatrixSubtracting_ValidMatrices_ReturnsDifference()
        {
            // Arrange
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
            var expectedDifference = new RealMatrix(new double[][]
            {
                new double[] { -4, -4 },
                new double[] { -4, -4 }
            });

            // Act
            var actualDifference = _matrixMath.MatrixSubtracting(matrix1, matrix2);

            // Assert
            Assert.AreEqual(expectedDifference.GetData(), actualDifference.GetRealMatrix().GetData());
        }

        [Test]
        public void MatrixSubtracting_InvalidDimensions_ThrowsInvalidDimensionException()
        {
            // Arrange
            var matrix1 = new RealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var matrix2 = new RealMatrix(new double[][]
            {
                new double[] { 5, 6, 7 }
            });

            // Act & Assert
            Assert.Throws<InvalidDimensionException>(() => _matrixMath.MatrixSubtracting(matrix1, matrix2));
        }

        [Test]
        public void MatrixTransposition_ValidMatrix_ReturnsTranspose()
        {
            // Arrange
            var matrix = new RealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var expectedTranspose = new RealMatrix(new double[][]
            {
                new double[] { 1, 3 },
                new double[] { 2, 4 }
            });

            // Act
            var actualTranspose = _matrixMath.MatrixTransposition(matrix);

            // Assert
            Assert.AreEqual(expectedTranspose.GetData(), actualTranspose.GetRealMatrix().GetData());
        }

        [Test]
        public void ScalarMultiplication_ValidMatrixAndScalar_ReturnsProduct()
        {
            // Arrange
            var matrix = new RealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var scalar = 2.0;
            var expectedProduct = new RealMatrix(new double[][]
            {
                new double[] { 2, 4 },
                new double[] { 6, 8 }
            });

            // Act
            var actualProduct = _matrixMath.ScalarMultiplication(matrix, scalar);

            // Assert
            Assert.AreEqual(expectedProduct.GetData(), actualProduct.GetRealMatrix().GetData());
        }
    }
}
*/