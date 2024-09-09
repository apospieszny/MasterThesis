using NUnit.Framework;
using Math_Graphic.core.math.modules;
using Math_Graphic.core.math.matrix;
using Math_Graphic.core.math;


/*
 * usystematyzowanie namespace
 * Poprawki w kodzie:
 * Dodana klasa pomocnicza nie implementowała całego interface
 */

namespace Math_Graphic.Tests.GPT4.alsoWithContext
{
    [TestFixture]
    public class MatrixMathTests
    {
        private MatrixMath _matrixMath;
        private IMatrix _matrix1;
        private IMatrix _matrix2;
        private IMatrix _resultMatrix;
        private double[][] _data1;
        private double[][] _data2;
        private RealMatrix _realMatrix1;
        private RealMatrix _realMatrix2;

        [SetUp]
        public void Setup()
        {
            _matrixMath = new MatrixMath();
            _data1 = new double[][] { new double[] { 1, 2 }, new double[] { 3, 4 } };
            _data2 = new double[][] { new double[] { 5, 6 }, new double[] { 7, 8 } };
            _realMatrix1 = new RealMatrix(_data1);
            _realMatrix2 = new RealMatrix(_data2);
            _matrix1 = new MatrixStub(_realMatrix1);
            _matrix2 = new MatrixStub(_realMatrix2);
        }

        [Test]
        public void TestMatrixAddition_ValidInput_CorrectOutput()
        {
            _resultMatrix = _matrixMath.MatrixAddition(_matrix1, _matrix2);
            Assert.AreEqual(_resultMatrix.GetRealMatrix().GetData()[0][0], 6);
            Assert.AreEqual(_resultMatrix.GetRealMatrix().GetData()[1][1], 12);
        }

        [Test]
        public void TestMatrixAddition_InvalidDimension_ThrowsException()
        {
            var matrix3 = new MatrixStub(new RealMatrix(new double[][] { new double[] { 1 } }));
            Assert.Throws<InvalidDimensionException>(() => _matrixMath.MatrixAddition(_matrix1, matrix3));
        }

        [Test]
        public void TestMatrixSubtracting_ValidInput_CorrectOutput()
        {
            _resultMatrix = _matrixMath.MatrixSubtracting(_matrix1, _matrix2);
            Assert.AreEqual(_resultMatrix.GetRealMatrix().GetData()[0][0], -4);
            Assert.AreEqual(_resultMatrix.GetRealMatrix().GetData()[1][1], -4);
        }

        [Test]
        public void TestMatrixSubtracting_InvalidDimension_ThrowsException()
        {
            var matrix3 = new MatrixStub(new RealMatrix(new double[][] { new double[] { 1 } }));
            Assert.Throws<InvalidDimensionException>(() => _matrixMath.MatrixSubtracting(_matrix1, matrix3));
        }
        /* Test odrzucony
        [Test]
        public void TestMatrixMultiplication_ValidInput_CorrectOutput()
        {
            _resultMatrix = _matrixMath.MatrixMultiplication(_matrix1, _matrix2);
            Assert.AreEqual(_resultMatrix.GetRealMatrix().GetData()[0][0], 19);
            Assert.AreEqual(_resultMatrix.GetRealMatrix().GetData()[1][1], 43);
        }

        [Test]
        public void TestMatrixMultiplication_InvalidDimension_ThrowsException()
        {
            var matrix3 = new MatrixStub(new RealMatrix(new double[][] { new double[] { 1, 2, 3 }, new double[] { 4, 5, 6 } }));
            Assert.Throws<InvalidDimensionException>(() => _matrixMath.MatrixMultiplication(_matrix1, matrix3));
        }*/

        [Test]
        public void TestMatrixTransposition()
        {
            _resultMatrix = _matrixMath.MatrixTransposition(_matrix1);
            Assert.AreEqual(_resultMatrix.GetRealMatrix().GetData()[0][1], 3);
            Assert.AreEqual(_resultMatrix.GetRealMatrix().GetData()[1][0], 2);
        }

        [Test]
        public void TestScalarMultiplication()
        {
            _resultMatrix = _matrixMath.ScalarMultiplication(_matrix1, 2);
            Assert.AreEqual(_resultMatrix.GetRealMatrix().GetData()[0][0], 2);
            Assert.AreEqual(_resultMatrix.GetRealMatrix().GetData()[1][1], 8);
        }
        /* Test odrzucony
        [Test]
        public void TestInverseMatrix()
        {
            _resultMatrix = _matrixMath.InverseMatrix(_matrix1);
            // Expect specific values depending on your Inverse implementation
            Assert.AreEqual(_resultMatrix.GetRealMatrix().GetData()[0][0], -2);
            Assert.AreEqual(_resultMatrix.GetRealMatrix().GetData()[1][1], 0.5);
        }*/
    }

    // Stub class to simulate IMatrix interface
    public class MatrixStub : IMatrix
    {
        private RealMatrix _realMatrix;

        public MatrixStub(RealMatrix realMatrix)
        {
            _realMatrix = realMatrix;
        }

        public IMatrix CreateIMatrix(RealMatrix realMatrix)
        {
            return new MatrixStub(realMatrix);
        }

        public RealMatrix GetRealMatrix()
        {
            return _realMatrix;
        }

        public int GetHeight()
        {
            return _realMatrix.GetRowDimension();
        }

        public int GetWidth()
        {
            return _realMatrix.GetColumnDimension();
        }

        
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

namespace MathGraphicTests
{
    [TestFixture]
    public class MatrixMathTests
    {
        private MatrixMath _matrixMath;
        private IMatrix _matrix1;
        private IMatrix _matrix2;
        private IMatrix _resultMatrix;
        private double[][] _data1;
        private double[][] _data2;
        private RealMatrix _realMatrix1;
        private RealMatrix _realMatrix2;

        [SetUp]
        public void Setup()
        {
            _matrixMath = new MatrixMath();
            _data1 = new double[][] { new double[] { 1, 2 }, new double[] { 3, 4 } };
            _data2 = new double[][] { new double[] { 5, 6 }, new double[] { 7, 8 } };
            _realMatrix1 = new RealMatrix(_data1);
            _realMatrix2 = new RealMatrix(_data2);
            _matrix1 = new MatrixStub(_realMatrix1);
            _matrix2 = new MatrixStub(_realMatrix2);
        }

        [Test]
        public void TestMatrixAddition_ValidInput_CorrectOutput()
        {
            _resultMatrix = _matrixMath.MatrixAddition(_matrix1, _matrix2);
            Assert.AreEqual(_resultMatrix.GetRealMatrix().GetData()[0][0], 6);
            Assert.AreEqual(_resultMatrix.GetRealMatrix().GetData()[1][1], 12);
        }

        [Test]
        public void TestMatrixAddition_InvalidDimension_ThrowsException()
        {
            var matrix3 = new MatrixStub(new RealMatrix(new double[][] { new double[] { 1 } }));
            Assert.Throws<InvalidDimensionException>(() => _matrixMath.MatrixAddition(_matrix1, matrix3));
        }

        [Test]
        public void TestMatrixSubtracting_ValidInput_CorrectOutput()
        {
            _resultMatrix = _matrixMath.MatrixSubtracting(_matrix1, _matrix2);
            Assert.AreEqual(_resultMatrix.GetRealMatrix().GetData()[0][0], -4);
            Assert.AreEqual(_resultMatrix.GetRealMatrix().GetData()[1][1], -4);
        }

        [Test]
        public void TestMatrixSubtracting_InvalidDimension_ThrowsException()
        {
            var matrix3 = new MatrixStub(new RealMatrix(new double[][] { new double[] { 1 } }));
            Assert.Throws<InvalidDimensionException>(() => _matrixMath.MatrixSubtracting(_matrix1, matrix3));
        }

        [Test]
        public void TestMatrixMultiplication_ValidInput_CorrectOutput()
        {
            _resultMatrix = _matrixMath.MatrixMultiplication(_matrix1, _matrix2);
            Assert.AreEqual(_resultMatrix.GetRealMatrix().GetData()[0][0], 19);
            Assert.AreEqual(_resultMatrix.GetRealMatrix().GetData()[1][1], 43);
        }

        [Test]
        public void TestMatrixMultiplication_InvalidDimension_ThrowsException()
        {
            var matrix3 = new MatrixStub(new RealMatrix(new double[][] { new double[] { 1, 2, 3 }, new double[] { 4, 5, 6 } }));
            Assert.Throws<InvalidDimensionException>(() => _matrixMath.MatrixMultiplication(_matrix1, matrix3));
        }

        [Test]
        public void TestMatrixTransposition()
        {
            _resultMatrix = _matrixMath.MatrixTransposition(_matrix1);
            Assert.AreEqual(_resultMatrix.GetRealMatrix().GetData()[0][1], 3);
            Assert.AreEqual(_resultMatrix.GetRealMatrix().GetData()[1][0], 2);
        }

        [Test]
        public void TestScalarMultiplication()
        {
            _resultMatrix = _matrixMath.ScalarMultiplication(_matrix1, 2);
            Assert.AreEqual(_resultMatrix.GetRealMatrix().GetData()[0][0], 2);
            Assert.AreEqual(_resultMatrix.GetRealMatrix().GetData()[1][1], 8);
        }

        [Test]
        public void TestInverseMatrix()
        {
            _resultMatrix = _matrixMath.InverseMatrix(_matrix1);
            // Expect specific values depending on your Inverse implementation
            Assert.AreEqual(_resultMatrix.GetRealMatrix().GetData()[0][0], -2);
            Assert.AreEqual(_resultMatrix.GetRealMatrix().GetData()[1][1], 0.5);
        }
    }

    // Stub class to simulate IMatrix interface
    public class MatrixStub : IMatrix
    {
        private RealMatrix _realMatrix;

        public MatrixStub(RealMatrix realMatrix)
        {
            _realMatrix = realMatrix;
        }

        public IMatrix CreateIMatrix(RealMatrix realMatrix)
        {
            return new MatrixStub(realMatrix);
        }

        public RealMatrix GetRealMatrix()
        {
            return _realMatrix;
        }

        public int GetHeight()
        {
            return _realMatrix.GetRowDimension();
        }

        public int GetWidth()
        {
            return _realMatrix.GetColumnDimension();
        }
    }
}
*/