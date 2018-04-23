using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Solution
{
    public class Bank
    {
        private Stock stock;

        public string Name { get; set; }

        public Bank(string name, Stock stock)
        {
            this.Name = name;
            this.stock = stock;
        }

        public void Register()
        {
            stock.Stocker += Update;
        }

        public void Unregister()
        {
            stock.Stocker -= Update;
        }

        public void Update(object sender, StockEventArgs info)
        {
            if (info.Info.Euro > 40)
                Console.WriteLine("Банк {0} продает евро;  Курс евро: {1}", this.Name, info.Info.Euro);
            else
                Console.WriteLine("Банк {0} покупает евро;  Курс евро: {1}", this.Name, info.Info.Euro);
        }
    }
}
