using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Solution
{
    public class Broker
    {
        private Stock stock;

        public string Name { get; set; }

        public Broker(string name, Stock stock)
        {
            this.Name = name;
            this.stock = stock;
            stock.Stocker += Update;
        }

        public void Update(object sender, StockEventArgs e)
        {
            if (e.Info.USD > 30)
                Console.WriteLine("Брокер {0} продает доллары;  Курс доллара: {1}", this.Name, e.Info.USD);
            else
                Console.WriteLine("Брокер {0} покупает доллары;  Курс доллара: {1}", this.Name, e.Info.USD);
        }

        public void StopTrade()
        {
            stock.Stocker-=Update;
            stock = null;
        }
    }
}
