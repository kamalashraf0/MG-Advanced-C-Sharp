namespace MG_Advanced_C_.Basic_C_
{



    class Stock
    {
        private string name;
        private decimal price;


        //delegate to Handle The Event 
        public delegate void StockPriceChangeHandler(Stock stock, decimal oldPrice);

        public event StockPriceChangeHandler OnPriceChanged;    // Declaration of Event

        public string Name => this.name;

        public decimal Price { get => this.price; set => this.price = value; }


        public Stock(string stockname)
        {

            this.name = stockname;
        }


        public void ChangeStockPriceBy(decimal percent)
        {
            decimal oldPrice = this.Price;
            this.price += Math.Round(this.price * percent, 2);
            //if (OnPriceChanged != null)
            //{
            //    OnPriceChanged(this, oldPrice);     //firing the event 
            //}


            OnPriceChanged?.Invoke(this, oldPrice);  //trigger the event 
        }




    }
}
