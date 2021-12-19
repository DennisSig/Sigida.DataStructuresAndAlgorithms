using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Collections.Matrices
{
    internal class UnitMatrix
    {
        private int _rowCount { get; set; }
        private int _columnCount { get; set; }
        public UnitMatrix(int rowCount, int columnCount)
        {
            _rowCount = rowCount;
            _columnCount = columnCount;
            Values = new Matrix(rowCount, columnCount);
            Create();
        }

        public Matrix Values { get; set; }

        private void Create()
        {
            if (Values.IsSymetric)
            {
                Values.ArrayRound((i, j) => Values[i, i] = 1);
                return;
            }
        }
    }
}
