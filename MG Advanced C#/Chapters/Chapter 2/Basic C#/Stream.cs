namespace MG_Advanced_C_
{
    class Stream
    {

        private readonly HttpClient hc;
        public Stream()
        {
            hc = new HttpClient();
        }
        public string getCurrencies()
        {
            string url = "https://coinbase.com/api/v2/currencies";
            var res = hc.GetStringAsync(url).Result;
            return res;
        }
    }
}
