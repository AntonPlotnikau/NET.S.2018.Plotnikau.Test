using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Solution
{
    public class StockEventArgs : EventArgs
    {
        public StockEventArgs(StockInfo info)
        {
            Info = info;
        }

        public StockInfo Info { get; set; }
    }

    public class Stock
    {
        public event EventHandler<StockEventArgs> Stocker = delegate { };

        private StockInfo stockInfo;

        public Stock(StockInfo info)
        {
            stockInfo = info;
        }

        protected virtual void OnStocker(StockEventArgs e)
        {
            var temp = this.Stocker;
            temp?.Invoke(this, e);
        }

        public void Notify()
        {
            this.OnStocker(new StockEventArgs(stockInfo));
        }

        public void Market()
        {
            Random rnd = new Random();
            stockInfo.USD = rnd.Next(20, 40);
            stockInfo.Euro = rnd.Next(30, 50);
            Notify();
        }
    }
}
