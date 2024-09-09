using NUnit.Framework;
using Math_Graphic.core.math.matrix;
using Math_Graphic.core.math.modules;

/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Usunięcie Assertów, w których czat próbuje uzyskać dostęp do prywatnych pól
 * Dodanie dodatkowej przestrzeni nazw
 * Zmiana konwersji w metodach
 */

namespace Math_Graphic.Tests.GPT4.first
{
    [TestFixture]
    public class MatrixMathTests
    {
        private MatrixMath matrixMath;
        private RealMatrix matrix3x3;
        private RealMatrix matrix3x3_Identity;
        private RealMatrix matrix3x3_Zero;
        private RealMatrix matrix2x3;

        [SetUp]
        public void Setup()
        {
            matrixMath = new MatrixMath();
            matrix3x3 = new RealMatrix(new double[][]
            {
                new double[] {1, 2, 3},
                new double[] {4, 5, 6},
                new double[] {7, 8, 9}
            });

            matrix3x3_Identity = MatrixUtils.CreateRealIdentityMatrix(3);

            matrix3x3_Zero = MatrixUtils.CreateRealMatrix(3, 3);

            matrix2x3 = new RealMatrix(new double[][]
            {
                new double[] {1, 2, 3},
                new double[] {4, 5, 6}
            });
        }
        /* Test odrzucony
        [Test]
        public void InverseMatrix_ValidMatrix_ReturnsInverse()
        {
            // Assuming RealMatrix.Inverse is correctly implemented
            var inverse = matrixMath.InverseMatrix((IMatrix)matrix3x3);
            Assert.IsNotNull(inverse);
        }

        [Test]
        public void MatrixAddition_ValidMatrices_AddsCorrectly()
        {
            var result = matrixMath.MatrixAddition((IMatrix)matrix3x3, (IMatrix)matrix3x3);
            var expected = new RealMatrix(new double[][]
            {
                new double[] {2, 4, 6},
                new double[] {8, 10, 12},
                new double[] {14, 16, 18}
            });

            Assert.IsTrue(MatrixDataEqual(result.GetRealMatrix(), expected));
        }

        [Test]
        public void MatrixAddition_InvalidDimensions_ThrowsException()
        {
            Assert.Throws<InvalidDimensionException>(() =>
                matrixMath.MatrixAddition((IMatrix)matrix3x3, (IMatrix)matrix2x3));
        }

        [Test]
        public void MatrixMultiplication_ValidMatrices_MultipliesCorrectly()
        {
            var result = matrixMath.MatrixMultiplication((IMatrix)matrix3x3, (IMatrix)matrix3x3_Identity);
            Assert.IsTrue(MatrixDataEqual(result.GetRealMatrix(), matrix3x3));
        }

        [Test]
        public void MatrixMultiplication_InvalidDimensions_ThrowsException()
        {
            Assert.Throws<InvalidDimensionException>(() =>
                matrixMath.MatrixMultiplication((IMatrix)matrix3x3, (IMatrix)matrix2x3));
        }

        [Test]
        public void MatrixSubtracting_ValidMatrices_SubtractsCorrectly()
        {
            var result = matrixMath.MatrixSubtracting((IMatrix)matrix3x3, (IMatrix)matrix3x3_Zero);
            Assert.IsTrue(MatrixDataEqual(result.GetRealMatrix(), matrix3x3));
        }

        [Test]
        public void MatrixSubtracting_InvalidDimensions_ThrowsException()
        {
            Assert.Throws<InvalidDimensionException>(() =>
                matrixMath.MatrixSubtracting((IMatrix)matrix3x3, (IMatrix)matrix2x3));
        }

        [Test]
        public void MatrixTransposition_ValidMatrix_TransposesCorrectly()
        {
            var result = matrixMath.MatrixTransposition((IMatrix)matrix2x3);
            var expected = new RealMatrix(new double[][]
            {
                new double[] {1, 4},
                new double[] {2, 5},
                new double[] {3, 6}
            });

            Assert.IsTrue(MatrixDataEqual(result.GetRealMatrix(), expected));
        }

        [Test]
        public void ScalarMultiplication_ValidScalar_MultipliesCorrectly()
        {
            var result = matrixMath.ScalarMultiplication((IMatrix)matrix3x3, 2);
            var expected = new RealMatrix(new double[][]
            {
                new double[] {2, 4, 6},
                new double[] {8, 10, 12},
                new double[] {14, 16, 18}
            });

            Assert.IsTrue(MatrixDataEqual(result.GetRealMatrix(), expected));
        }

        private bool MatrixDataEqual(RealMatrix actual, RealMatrix expected)
        {
            var actualData = actual.GetData();
            var expectedData = expected.GetData();

            for (int i = 0; i < actualData.Length; i++)
            {
                for (int j = 0; j < actualData[i].Length; j++)
                {
                    if (actualData[i][j] != expectedData[i][j])
                        return false;
                }
            }

            return true;
        }*/
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
        private MatrixMath matrixMath;
        private RealMatrix matrix3x3;
        private RealMatrix matrix3x3_Identity;
        private RealMatrix matrix3x3_Zero;
        private RealMatrix matrix2x3;

        [SetUp]
        public void Setup()
        {
            matrixMath = new MatrixMath();
            matrix3x3 = new RealMatrix(new double[][]
            {
                new double[] {1, 2, 3},
                new double[] {4, 5, 6},
                new double[] {7, 8, 9}
            });

            matrix3x3_Identity = MatrixUtils.CreateRealIdentityMatrix(3);

            matrix3x3_Zero = MatrixUtils.CreateRealMatrix(3, 3);

            matrix2x3 = new RealMatrix(new double[][]
            {
                new double[] {1, 2, 3},
                new double[] {4, 5, 6}
            });
        }

        [Test]
        public void InverseMatrix_ValidMatrix_ReturnsInverse()
        {
            // Assuming RealMatrix.Inverse is correctly implemented
            var inverse = matrixMath.InverseMatrix(matrix3x3);
            Assert.IsNotNull(inverse);
        }

        [Test]
        public void MatrixAddition_ValidMatrices_AddsCorrectly()
        {
            var result = matrixMath.MatrixAddition(matrix3x3, matrix3x3);
            var expected = new RealMatrix(new double[][]
            {
                new double[] {2, 4, 6},
                new double[] {8, 10, 12},
                new double[] {14, 16, 18}
            });

            Assert.IsTrue(MatrixDataEqual(result.GetRealMatrix(), expected));
        }

        [Test]
        public void MatrixAddition_InvalidDimensions_ThrowsException()
        {
            Assert.Throws<InvalidDimensionException>(() =>
                matrixMath.MatrixAddition(matrix3x3, matrix2x3));
        }

        [Test]
        public void MatrixMultiplication_ValidMatrices_MultipliesCorrectly()
        {
            var result = matrixMath.MatrixMultiplication(matrix3x3, matrix3x3_Identity);
            Assert.IsTrue(MatrixDataEqual(result.GetRealMatrix(), matrix3x3));
        }

        [Test]
        public void MatrixMultiplication_InvalidDimensions_ThrowsException()
        {
            Assert.Throws<InvalidDimensionException>(() =>
                matrixMath.MatrixMultiplication(matrix3x3, matrix2x3));
        }

        [Test]
        public void MatrixSubtracting_ValidMatrices_SubtractsCorrectly()
        {
            var result = matrixMath.MatrixSubtracting(matrix3x3, matrix3x3_Zero);
            Assert.IsTrue(MatrixDataEqual(result.GetRealMatrix(), matrix3x3));
        }

        [Test]
        public void MatrixSubtracting_InvalidDimensions_ThrowsException()
        {
            Assert.Throws<InvalidDimensionException>(() =>
                matrixMath.MatrixSubtracting(matrix3x3, matrix2x3));
        }

        [Test]
        public void MatrixTransposition_ValidMatrix_TransposesCorrectly()
        {
            var result = matrixMath.MatrixTransposition(matrix2x3);
            var expected = new RealMatrix(new double[][]
            {
                new double[] {1, 4},
                new double[] {2, 5},
                new double[] {3, 6}
            });

            Assert.IsTrue(MatrixDataEqual(result.GetRealMatrix(), expected));
        }

        [Test]
        public void ScalarMultiplication_ValidScalar_MultipliesCorrectly()
        {
            var result = matrixMath.ScalarMultiplication(matrix3x3, 2);
            var expected = new RealMatrix(new double[][]
            {
                new double[] {2, 4, 6},
                new double[] {8, 10, 12},
                new double[] {14, 16, 18}
            });

            Assert.IsTrue(MatrixDataEqual(result.GetRealMatrix(), expected));
        }

        private bool MatrixDataEqual(RealMatrix actual, RealMatrix expected)
        {
            var actualData = actual.GetData();
            var expectedData = expected.GetData();

            for (int i = 0; i < actualData.Length; i++)
            {
                for (int j = 0; j < actualData[i].Length; j++)
                {
                    if (actualData[i][j] != expectedData[i][j])
                        return false;
                }
            }

            return true;
        }
    }
}
*/