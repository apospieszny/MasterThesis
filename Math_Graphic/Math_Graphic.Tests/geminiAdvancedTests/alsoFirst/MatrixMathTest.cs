using Math_Graphic.core.math.matrix;
using Math_Graphic.core.math.modules;
using NUnit.Framework;

/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 * Zmiana konwersji w metodach
 */

namespace Math_Graphic.Tests.geminiAdvanced.alsoFirst
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
            var inverse = _matrixMath.InverseMatrix((IMatrix)matrix);

            // Assert
            Assert.AreEqual(expectedInverse.GetData(), inverse.GetRealMatrix().GetData());
        }

        [Test]
        public void MatrixAddition_SameDimensions_ReturnsSum()
        {
            // Arrange
            var m1 = new RealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var m2 = new RealMatrix(new double[][]
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
            var sum = _matrixMath.MatrixAddition((IMatrix)m1, (IMatrix)m2);

            // Assert
            Assert.AreEqual(expectedSum.GetData(), sum.GetRealMatrix().GetData());
        }

        [Test]
        public void MatrixAddition_DifferentDimensions_ThrowsInvalidDimensionException()
        {
            // Arrange
            var m1 = new RealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var m2 = new RealMatrix(new double[][]
            {
                new double[] { 5, 6, 7 }
            });

            // Act & Assert
            Assert.Throws<InvalidDimensionException>(() => _matrixMath.MatrixAddition((IMatrix)m1, (IMatrix)m2));
        }

        [Test]
        public void MatrixMultiplication_CompatibleDimensions_ReturnsProduct()
        {
            // Arrange
            var m1 = new RealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var m2 = new RealMatrix(new double[][]
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
            var product = _matrixMath.MatrixMultiplication((IMatrix)m1, (IMatrix)m2);

            // Assert
            Assert.AreEqual(expectedProduct.GetData(), product.GetRealMatrix().GetData());
        }

        [Test]
        public void MatrixMultiplication_IncompatibleDimensions_ThrowsInvalidDimensionException()
        {
            // Arrange
            var m1 = new RealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var m2 = new RealMatrix(new double[][]
            {
                new double[] { 5 },
                new double[] { 6 },
                new double[] { 7 }
            });

            // Act & Assert
            Assert.Throws<InvalidDimensionException>(() => _matrixMath.MatrixMultiplication((IMatrix)m1, (IMatrix)m2));
        }

        [Test]
        public void MatrixSubtracting_SameDimensions_ReturnsDifference()
        {
            // Arrange
            var m1 = new RealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var m2 = new RealMatrix(new double[][]
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
            var difference = _matrixMath.MatrixSubtracting((IMatrix)m1, (IMatrix)m2);

            // Assert
            Assert.AreEqual(expectedDifference.GetData(), difference.GetRealMatrix().GetData());
        }

        [Test]
        public void MatrixSubtracting_DifferentDimensions_ThrowsInvalidDimensionException()
        {
            // Arrange
            var m1 = new RealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var m2 = new RealMatrix(new double[][]
            {
                new double[] { 5, 6, 7 }
            });

            // Act & Assert
            Assert.Throws<InvalidDimensionException>(() => _matrixMath.MatrixSubtracting((IMatrix)m1, (IMatrix)m2));
        }

        [Test]
        public void MatrixTransposition_ReturnsTranspose()
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
            var transpose = _matrixMath.MatrixTransposition((IMatrix)matrix);

            // Assert
            Assert.AreEqual(expectedTranspose.GetData(), transpose.GetRealMatrix().GetData());
        }

        [Test]
        public void ScalarMultiplication_ReturnsScaledMatrix()
        {
            // Arrange
            var matrix = new RealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var scalar = 2.5;
            var expectedScaledMatrix = new RealMatrix(new double[][]
            {
                new double[] { 2.5, 5 },
                new double[] { 7.5, 10 }
            });

            // Act
            var scaledMatrix = _matrixMath.ScalarMultiplication((IMatrix)matrix, scalar);

            // Assert
            Assert.AreEqual(expectedScaledMatrix.GetData(), scaledMatrix.GetRealMatrix().GetData());
        }*/
    }
}

/*
using Math_Graphic.core.math.matrix;
using Math_Graphic.core.math.modules;
using NUnit.Framework;

namespace Math_Graphic.Tests.geminiAdvanced.alsoFirst
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
            var inverse = _matrixMath.InverseMatrix(matrix);

            // Assert
            Assert.AreEqual(expectedInverse.GetData(), inverse.GetRealMatrix().GetData());
        }

        [Test]
        public void MatrixAddition_SameDimensions_ReturnsSum()
        {
            // Arrange
            var m1 = new RealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var m2 = new RealMatrix(new double[][]
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
            var sum = _matrixMath.MatrixAddition(m1, m2);

            // Assert
            Assert.AreEqual(expectedSum.GetData(), sum.GetRealMatrix().GetData());
        }

        [Test]
        public void MatrixAddition_DifferentDimensions_ThrowsInvalidDimensionException()
        {
            // Arrange
            var m1 = new RealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var m2 = new RealMatrix(new double[][]
            {
                new double[] { 5, 6, 7 }
            });

            // Act & Assert
            Assert.Throws<InvalidDimensionException>(() => _matrixMath.MatrixAddition(m1, m2));
        }

        [Test]
        public void MatrixMultiplication_CompatibleDimensions_ReturnsProduct()
        {
            // Arrange
            var m1 = new RealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var m2 = new RealMatrix(new double[][]
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
            var product = _matrixMath.MatrixMultiplication(m1, m2);

            // Assert
            Assert.AreEqual(expectedProduct.GetData(), product.GetRealMatrix().GetData());
        }

        [Test]
        public void MatrixMultiplication_IncompatibleDimensions_ThrowsInvalidDimensionException()
        {
            // Arrange
            var m1 = new RealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var m2 = new RealMatrix(new double[][]
            {
                new double[] { 5 },
                new double[] { 6 },
                new double[] { 7 }
            });

            // Act & Assert
            Assert.Throws<InvalidDimensionException>(() => _matrixMath.MatrixMultiplication(m1, m2));
        }

        [Test]
        public void MatrixSubtracting_SameDimensions_ReturnsDifference()
        {
            // Arrange
            var m1 = new RealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var m2 = new RealMatrix(new double[][]
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
            var difference = _matrixMath.MatrixSubtracting(m1, m2);

            // Assert
            Assert.AreEqual(expectedDifference.GetData(), difference.GetRealMatrix().GetData());
        }

        [Test]
        public void MatrixSubtracting_DifferentDimensions_ThrowsInvalidDimensionException()
        {
            // Arrange
            var m1 = new RealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var m2 = new RealMatrix(new double[][]
            {
                new double[] { 5, 6, 7 }
            });

            // Act & Assert
            Assert.Throws<InvalidDimensionException>(() => _matrixMath.MatrixSubtracting(m1, m2));
        }

        [Test]
        public void MatrixTransposition_ReturnsTranspose()
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
            var transpose = _matrixMath.MatrixTransposition(matrix);

            // Assert
            Assert.AreEqual(expectedTranspose.GetData(), transpose.GetRealMatrix().GetData());
        }

        [Test]
        public void ScalarMultiplication_ReturnsScaledMatrix()
        {
            // Arrange
            var matrix = new RealMatrix(new double[][]
            {
                new double[] { 1, 2 },
                new double[] { 3, 4 }
            });
            var scalar = 2.5;
            var expectedScaledMatrix = new RealMatrix(new double[][]
            {
                new double[] { 2.5, 5 },
                new double[] { 7.5, 10 }
            });

            // Act
            var scaledMatrix = _matrixMath.ScalarMultiplication(matrix, scalar);

            // Assert
            Assert.AreEqual(expectedScaledMatrix.GetData(), scaledMatrix.GetRealMatrix().GetData());
        }
    }
}
*/