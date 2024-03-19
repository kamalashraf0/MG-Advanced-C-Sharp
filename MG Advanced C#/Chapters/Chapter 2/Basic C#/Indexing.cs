namespace MG_Advanced_C_.Basic_C_
{
    public class IP
    {


        private int[] Segments = new int[4];

        public int this[int index]                          //property for Indexing   
                                                            //this => take an object from the class to Get The Index of array 
        {
            get
            {

                return Segments[index];
            }

            set
            {
                Segments[index] = value;
            }
        }

        public IP(int segment1, int segment2, int segment3, int segment4)
        {

            Segments[0] = segment1;
            Segments[1] = segment2;
            Segments[2] = segment3;
            Segments[3] = segment4;
        }

        public string IPAdress => string.Join(".", Segments);      //(Char separator , array)


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
