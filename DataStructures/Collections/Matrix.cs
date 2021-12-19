using DataStructures.Collections.Matrices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataStructures.Collections
{
    public enum SpecialMatrix 
    {
        Diagonal,
        Unit,
        RandomUnit
    }

    public class Matrix : ICloneable, IEnumerable<double>
    {
        private double[,] _matrix;
        private int _rowCount;
        private int _columnCount;

        /// <summary>
        /// Создает матрицу 
        /// </summary>
        /// <param name="rowCount">Количество строк матрицы</param>
        /// <param name="columnCount">Количество столбцов матрицы</param>
        /// <exception cref="ArgumentException">В случае если строк или столбцов меньше или рано 0, выдает ошибку</exception>
        public Matrix(int rowCount, int columnCount)
        {
            if (rowCount <= 0 || columnCount <= 0)
                throw new ArgumentException($"Матрица с размером {rowCount}:{columnCount} не может существовать");
            _matrix = new double[rowCount, columnCount];
            _rowCount = rowCount;
            _columnCount = columnCount;
        }

        /// <summary>
        /// Количество строк матрицы 
        /// </summary>
        public int RowCount { get => _rowCount; }

        /// <summary>
        /// Количество столбцов матрицы
        /// </summary>
        public int ColumnCount { get => _columnCount; }
        public bool IsSymetric 
        { 
            get
            {
                if (RowCount == ColumnCount)
                    return true;
                return false;
            }
        }


        /// <summary>
        /// Индексатор. Позволяет получить элемент матрицы по строке и столбцу 
        /// </summary>
        /// <param name="x">строка</param>
        /// <param name="y">столбец</param>
        /// <returns>Число лежащее в выбранной области</returns>
        public double this[int x, int y] { get => _matrix[x, y]; set => _matrix[x, y] = value; }

        /// <summary>
        /// Сравнивает текущий объект с матрицой на равенство значений
        /// </summary>
        /// <param name="matrix">Матрица для сравнения</param>
        /// <returns>Вохвращает true в случае если матрицы равны, в противном случае false</returns>
        public bool IsEqual(Matrix matrix)
        {
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColumnCount; j++)
                {
                    if (_matrix[i, j] == matrix[i, j])
                        continue;
                    else
                        return false;
                }
            }

            return true;
        }
        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            CheckingInputMatrix(matrix1, matrix2);

            var result = (Matrix)matrix1.Clone();

            result.ArrayRound((i, j) => result[i, j] += matrix2[i, j]);

            return result;
        }
        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            CheckingInputMatrix(matrix1, matrix2);

            var result = (Matrix)matrix1.Clone();

            result.ArrayRound((i, j) => result[i, j] -= matrix2[i, j]);

            return result;
        }
        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            CheckingInputMatrix(matrix1, matrix2);

            var result = (Matrix)matrix1.Clone();

            result.ArrayRound((i, j) => result[i, j] *= matrix2[i, j]);

            return result;
        }
        public static Matrix operator /(Matrix matrix1, Matrix matrix2)
        {
            CheckingInputMatrix(matrix1, matrix2);

            var result = (Matrix)matrix1.Clone();

            result.ArrayRound((i, j) => result[i, j] /= matrix2[i, j]);

            return result;
        }
        public static Matrix operator +(Matrix matrix1, double value)
        {
            var result = (Matrix)matrix1.Clone();

            result.ArrayRound((i, j) => result[i, j] += value);

            return result;
        }
        public static Matrix operator -(Matrix matrix1, double value)
        {
            var result = (Matrix)matrix1.Clone();

            result.ArrayRound((i, j) => result[i, j] -= value);

            return result;
        }
        public static Matrix operator *(Matrix matrix1, double value)
        {
            var result = (Matrix)matrix1.Clone();

            result.ArrayRound((i, j) => result[i, j] *= value);

            return result;
        }
        public static Matrix operator /(Matrix matrix1, double value)
        {
            var result = (Matrix)matrix1.Clone();

            result.ArrayRound((i, j) => result[i, j] /= value);

            return result;
        }
        public static Matrix Create(int x, int y, SpecialMatrix type)
        {
            switch (type)
            {
                case SpecialMatrix.Diagonal:
                    return null;
                case SpecialMatrix.Unit:
                    return new UnitMatrix(x,y).Values;
                case SpecialMatrix.RandomUnit:
                    var newMatrix = new Matrix(x, y);
                    var random = new Random();
                    newMatrix.ArrayRound((i, j) => newMatrix[i, j] = random.Next(0, 40));
                    return newMatrix;
                default:
                    break;
            }
            return null;
        }
        public object Clone()
        {
            var oldData = new Matrix(RowCount, ColumnCount);
            oldData.ArrayRound((i, j) => oldData._matrix[i, j] = this._matrix[i, j]);
            return oldData;
        }
        internal void ArrayRound(Action<int, int> operation)
        {
            for (int i = 0; i < this.RowCount; i++)
            {
                for (int j = 0; j < this.ColumnCount; j++)
                {
                    operation(i, j);
                }
            }
        }
        private static void CheckingInputMatrix(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1 == null || matrix2 == null)
                throw new ArgumentNullException("Значение матрицы не может быть NULL");
            if (matrix1.RowCount != matrix2.RowCount || matrix1.ColumnCount != matrix2.ColumnCount)
                throw new ArgumentException("Недопустима операция над матрицами с разной мерностью");
        }

        public IEnumerator<double> GetEnumerator()
        {
            for (int i = 0; i < RowCount; i++)
            {
                for (int j = 0; j < ColumnCount; j++)
                {
                    yield return _matrix[i, j];
                }
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
