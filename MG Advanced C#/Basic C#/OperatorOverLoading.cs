namespace MG_Advanced_C_.Basic_C_
{
    class Money
    {
        private decimal _amount;

        public decimal Amount => _amount;


        public Money(decimal value)
        {
            this._amount = value;
        }


        // The Operator Overloading  (now we can do some calculations on Objects)
        public static Money operator +(Money money1, Money money2)
        {
            var value = money1.Amount + money2.Amount;
            return new Money(value);
        }

        public static Money operator -(Money money1, Money money2)
        {
            var value = money1.Amount - money2.Amount;
            return new Money(value);
        }





        public static bool operator >(Money money1, Money money2)
        {

            return money1.Amount > money2.Amount;
        }
        public static bool operator <(Money money1, Money money2)
        {

            return money1.Amount < money2.Amount;
        }






        public static bool operator ==(Money money1, Money money2)
        {

            return money1.Amount == money2.Amount;
        }


        public static bool operator !=(Money money1, Money money2)
        {

            return money1.Amount != money2.Amount;

        }




        public static Money operator ++(Money money1)
        {
            var value = money1._amount;

            return new Money(++value);
        }
    }
}
