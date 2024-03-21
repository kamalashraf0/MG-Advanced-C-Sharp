namespace MG_Advanced_C_.Revision
{
    class matrix
    {
        private int[,] _mat;

        public int this[int col, int row]
        {
            get
            {
                return _mat[col, row];
            }

            set
            {
                _mat[col, row] = value;
            }
        }
        public matrix(int[,] matrix)
        {
            _mat = matrix;
        }


    }



}
