namespace MG_Advanced_C_.Basic_C_
{
    public class IP
    {


        private int[] _segments = new int[4];

        public int this[int index]                          //property for Indexing   
                                                            //this => take an object from the class to Get The Index of array 
        {
            get
            {

                return _segments[index];
            }

            set
            {
                _segments[index] = value;
            }
        }

        public IP(int segment1, int segment2, int segment3, int segment4)
        {

            _segments[0] = segment1;
            _segments[1] = segment2;
            _segments[2] = segment3;
            _segments[3] = segment4;
        }

        public string IPAdress => string.Join(".", _segments);      //(Char separator , array)


    }


    public class MArray
    {

        private int[,] _marr;

        public int this[int row, int col]
        {
            get
            {
                return _marr[row, col];
            }
            set
            {
                _marr[row, col] = value;

            }

        }


        public MArray(int[,] matrix)
        {
            _marr = matrix;
        }

    }


}
