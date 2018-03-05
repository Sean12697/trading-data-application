using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingDataApplication
{
    class Country : IComparable
    {
        private string countryName;
        private float gpdGrowth;
        private float inflation;
        private float tradeBalance;
        private int hdiRanking;
        private string[] mainTradePartners;

        public Country(string countryName, float gpdGrowth, float inflation, float tradeBalance, int hdiRanking, string[] mainTradePartners)  {
            this.CountryName = countryName;
            this.GpdGrowth = gpdGrowth;
            this.Inflation = inflation;
            this.TradeBalance = tradeBalance;
            this.HdiRanking = hdiRanking;
            this.MainTradePartners = mainTradePartners;
        }

        public string CountryName { get => countryName; set => countryName = value; }
        public float GpdGrowth { get => gpdGrowth; set => gpdGrowth = value; }
        public float Inflation { get => inflation; set => inflation = value; }
        public float TradeBalance { get => tradeBalance; set => tradeBalance = value; }
        public int HdiRanking { get => hdiRanking; set => hdiRanking = value; }
        public string[] MainTradePartners { get => mainTradePartners; set => mainTradePartners = value; }

        public override string ToString() {
            return this.countryName;
        }

        public int CompareTo(object obj) {
            return this.ToString().CompareTo(((Country)obj).ToString());
        }
    }
}
