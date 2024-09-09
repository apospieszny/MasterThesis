using NUnit.Framework;
using Math_Graphic.core.math.modules;
using Math_Graphic.core.math.matrix;

/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Dodanie dodatkowej przestrzeni nazw
 */

namespace Math_Graphic.Tests.GPT35.alsoFirst
{
    [TestFixture]
    public class MatrixTests
    {
        [Test]
        public void TestMatrixConstructor_Empty()
        {
            var matrix = new Matrix();
            Assert.AreEqual(3, matrix.GetHeight());
            Assert.AreEqual(3, matrix.GetWidth());
        }

        [Test]
        public void TestMatrixConstructor_WithRealMatrix()
        {
            var realMatrix = MatrixUtils.CreateRealMatrix(new double[][] { new double[] { 1, 2 }, new double[] { 3, 4 } });
            var matrix = new Matrix(realMatrix);
            Assert.AreEqual(2, matrix.GetHeight());
            Assert.AreEqual(2, matrix.GetWidth());
        }

        [Test]
        public void TestCreateIMatrix()
        {
            var realMatrix = MatrixUtils.CreateRealMatrix(new double[][] { new double[] { 1, 2 }, new double[] { 3, 4 } });
            var matrix = new Matrix();
            var newMatrix = matrix.CreateIMatrix(realMatrix);
            Assert.AreEqual(2, newMatrix.GetHeight());
            Assert.AreEqual(2, newMatrix.GetWidth());
        }

        [Test]
        public void TestCreateIdentityMatrix()
        {
            var matrix = new Matrix();
            matrix.CreateIdentityMatrix(4);
            Assert.AreEqual(4, matrix.GetHeight());
            Assert.AreEqual(4, matrix.GetWidth());
            Assert.AreEqual(1.0, matrix.GetMatrixValue(0, 0));
            Assert.AreEqual(0.0, matrix.GetMatrixValue(0, 1));
        }

        [Test]
        public void TestDeterminant()
        {
            var realMatrix = MatrixUtils.CreateRealMatrix(new double[][] { new double[] { 1, 2 }, new double[] { 3, 4 } });
            var matrix = new Matrix(realMatrix);
            Assert.AreEqual(-2.0, matrix.Determinant());
        }

        [Test]
        public void TestGetMatrixValue()
        {
            var realMatrix = MatrixUtils.CreateRealMatrix(new double[][] { new double[] { 5, 6 }, new double[] { 7, 8 } });
            var matrix = new Matrix(realMatrix);
            Assert.AreEqual(5.0, matrix.GetMatrixValue(0, 0));
            Assert.AreEqual(6.0, matrix.GetMatrixValue(0, 1));
        }

        [Test]
        public void TestSetMatrixValue()
        {
            var realMatrix = MatrixUtils.CreateRealMatrix(new double[][] { new double[] { 0, 0 }, new double[] { 0, 0 } });
            var matrix = new Matrix(realMatrix);
            matrix.SetMatrixValue(0, 0, 1.0);
            Assert.AreEqual(1.0, matrix.GetMatrixValue(0, 0));
        }

        [Test]
        public void TestSetMatrixValues()
        {
            var matrix = new Matrix();
            matrix.SetMatrixValues(new double[][] { new double[] { 9, 8 }, new double[] { 7, 6 } });
            Assert.AreEqual(9.0, matrix.GetMatrixValue(0, 0));
            Assert.AreEqual(8.0, matrix.GetMatrixValue(0, 1));
            Assert.AreEqual(7.0, matrix.GetMatrixValue(1, 0));
            Assert.AreEqual(6.0, matrix.GetMatrixValue(1, 1));
        }

        [Test]
        public void TestGetWidth()
        {
            var realMatrix = MatrixUtils.CreateRealMatrix(new double[][] { new double[] { 1, 2, 3 }, new double[] { 4, 5, 6 } });
            var matrix = new Matrix(realMatrix);
            Assert.AreEqual(3, matrix.GetWidth());
        }

        [Test]
        public void TestGetHeight()
        {
            var realMatrix = MatrixUtils.CreateRealMatrix(new double[][] { new double[] { 1, 2 }, new double[] { 3, 4 }, new double[] { 5, 6 } });
            var matrix = new Matrix(realMatrix);
            Assert.AreEqual(3, matrix.GetHeight());
        }
        /* Test odrzucony
        [Test]
        public void TestToString()
        {
            var realMatrix = MatrixUtils.CreateRealMatrix(new double[][] { new double[] { 1.0, 2.0 }, new double[] { 3.0, 4.0 } });
            var matrix = new Matrix(realMatrix);
            var result = matrix.ToString();
            Assert.IsTrue(result.Contains("<table>"));
            Assert.IsTrue(result.Contains("</table>"));
            Assert.IsTrue(result.Contains("1.0"));
            Assert.IsTrue(result.Contains("2.0"));
            Assert.IsTrue(result.Contains("3.0"));
            Assert.IsTrue(result.Contains("4.0"));
        }*/

        [Test]
        public void TestGetRealMatrix()
        {
            var realMatrix = MatrixUtils.CreateRealMatrix(new double[][] { new double[] { 2, 2 }, new double[] { 2, 2 } });
            var matrix = new Matrix(realMatrix);
            var result = matrix.GetRealMatrix();
            Assert.AreEqual(realMatrix, result);
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
    public class MatrixTests
    {
        [Test]
        public void TestMatrixConstructor_Empty()
        {
            var matrix = new Matrix();
            Assert.AreEqual(3, matrix.GetHeight());
            Assert.AreEqual(3, matrix.GetWidth());
        }

        [Test]
        public void TestMatrixConstructor_WithRealMatrix()
        {
            var realMatrix = MatrixUtils.CreateRealMatrix(new double[][] { new double[] { 1, 2 }, new double[] { 3, 4 } });
            var matrix = new Matrix(realMatrix);
            Assert.AreEqual(2, matrix.GetHeight());
            Assert.AreEqual(2, matrix.GetWidth());
        }

        [Test]
        public void TestCreateIMatrix()
        {
            var realMatrix = MatrixUtils.CreateRealMatrix(new double[][] { new double[] { 1, 2 }, new double[] { 3, 4 } });
            var matrix = new Matrix();
            var newMatrix = matrix.CreateIMatrix(realMatrix);
            Assert.AreEqual(2, newMatrix.GetHeight());
            Assert.AreEqual(2, newMatrix.GetWidth());
        }

        [Test]
        public void TestCreateIdentityMatrix()
        {
            var matrix = new Matrix();
            matrix.CreateIdentityMatrix(4);
            Assert.AreEqual(4, matrix.GetHeight());
            Assert.AreEqual(4, matrix.GetWidth());
            Assert.AreEqual(1.0, matrix.GetMatrixValue(0, 0));
            Assert.AreEqual(0.0, matrix.GetMatrixValue(0, 1));
        }

        [Test]
        public void TestDeterminant()
        {
            var realMatrix = MatrixUtils.CreateRealMatrix(new double[][] { new double[] { 1, 2 }, new double[] { 3, 4 } });
            var matrix = new Matrix(realMatrix);
            Assert.AreEqual(-2.0, matrix.Determinant());
        }

        [Test]
        public void TestGetMatrixValue()
        {
            var realMatrix = MatrixUtils.CreateRealMatrix(new double[][] { new double[] { 5, 6 }, new double[] { 7, 8 } });
            var matrix = new Matrix(realMatrix);
            Assert.AreEqual(5.0, matrix.GetMatrixValue(0, 0));
            Assert.AreEqual(6.0, matrix.GetMatrixValue(0, 1));
        }

        [Test]
        public void TestSetMatrixValue()
        {
            var realMatrix = MatrixUtils.CreateRealMatrix(new double[][] { new double[] { 0, 0 }, new double[] { 0, 0 } });
            var matrix = new Matrix(realMatrix);
            matrix.SetMatrixValue(0, 0, 1.0);
            Assert.AreEqual(1.0, matrix.GetMatrixValue(0, 0));
        }

        [Test]
        public void TestSetMatrixValues()
        {
            var matrix = new Matrix();
            matrix.SetMatrixValues(new double[][] { new double[] { 9, 8 }, new double[] { 7, 6 } });
            Assert.AreEqual(9.0, matrix.GetMatrixValue(0, 0));
            Assert.AreEqual(8.0, matrix.GetMatrixValue(0, 1));
            Assert.AreEqual(7.0, matrix.GetMatrixValue(1, 0));
            Assert.AreEqual(6.0, matrix.GetMatrixValue(1, 1));
        }

        [Test]
        public void TestGetWidth()
        {
            var realMatrix = MatrixUtils.CreateRealMatrix(new double[][] { new double[] { 1, 2, 3 }, new double[] { 4, 5, 6 } });
            var matrix = new Matrix(realMatrix);
            Assert.AreEqual(3, matrix.GetWidth());
        }

        [Test]
        public void TestGetHeight()
        {
            var realMatrix = MatrixUtils.CreateRealMatrix(new double[][] { new double[] { 1, 2 }, new double[] { 3, 4 }, new double[] { 5, 6 } });
            var matrix = new Matrix(realMatrix);
            Assert.AreEqual(3, matrix.GetHeight());
        }

        [Test]
        public void TestToString()
        {
            var realMatrix = MatrixUtils.CreateRealMatrix(new double[][] { new double[] { 1.0, 2.0 }, new double[] { 3.0, 4.0 } });
            var matrix = new Matrix(realMatrix);
            var result = matrix.ToString();
            Assert.IsTrue(result.Contains("<table>"));
            Assert.IsTrue(result.Contains("</table>"));
            Assert.IsTrue(result.Contains("1.0"));
            Assert.IsTrue(result.Contains("2.0"));
            Assert.IsTrue(result.Contains("3.0"));
            Assert.IsTrue(result.Contains("4.0"));
        }

        [Test]
        public void TestGetRealMatrix()
        {
            var realMatrix = MatrixUtils.CreateRealMatrix(new double[][] { new double[] { 2, 2 }, new double[] { 2, 2 } });
            var matrix = new Matrix(realMatrix);
            var result = matrix.GetRealMatrix();
            Assert.AreEqual(realMatrix, result);
        }
    }
}
*/