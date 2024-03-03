namespace MG_Advanced_C_.Basic_C_
{
    //Should have a parameter Constructor 
    //Shouldn't initialize the fields
    //Don't have destructor (Finalize)
    //Doesn't support inheritance
    //it's a value type (stored in stack)

    struct student
    {
        public int x { get; set; }
        public student(int x)
        {
            this.x = x;
        }



    }
}
