using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradingDataApplication
{
    public partial class Form1 : Form
    {

        AVLTree<Country> Countries = new AVLTree<Country>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Program.csvToAVLTree(ref Countries, "countries.csv");
            Program.setAvlData(lblInfo, Countries);
            Program.showCountries("", listBoxCountries, Countries);
            setBiggestTradingPartner();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Program.showCountries(txtSearch.Text, listBoxCountries, Countries);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Program.showCountries(txtSearch.Text, listBoxCountries, Countries);
        }

        private void listBoxCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            Country c = Countries.GetItem((String)listBoxCountries.SelectedItem);
            txtName.Text = c.CountryName;
            txtGpdGrowth.Text = c.GpdGrowth.ToString();
            txtInflation.Text = c.Inflation.ToString();
            txtTradeBalance.Text = c.TradeBalance.ToString();
            txtHdiRanking.Text = c.HdiRanking.ToString();
            listBoxTradingPartners.Items.Clear();
            foreach (string s in c.MainTradePartners) listBoxTradingPartners.Items.Add(s);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Country c = Countries.GetItem((String)listBoxCountries.SelectedItem);
            Countries.RemoveItem((String)listBoxCountries.SelectedItem);
            Program.setAvlData(lblInfo, Countries);
            txtSearch.Text = "";
            Program.showCountries(txtSearch.Text, listBoxCountries, Countries);
            setBiggestTradingPartner();
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            //Country c = Countries.GetItem((String)listBoxCountries.SelectedItem);
            //string oldName = c.CountryName;
            //c.CountryName = txtName.Text;
            //Countries.RemoveItem(oldName);
            //Countries.InsertItem(c);
            //Program.showCountries(txtSearch.Text, listBoxCountries, Countries);
        }

        private void setBiggestTradingPartner()
        {
            string[] CountriesText = Program.getCountries(Countries);

            string countryWithBiggestTradePotential = "";
            float countryWithBiggestTradePotentialGPD = 0;

            foreach (string s in CountriesText)
            {
                Country x = Countries.GetItem(s);
                float total = 0;
                // create to function
                foreach (string countr in x.MainTradePartners) if (Countries.GetItem(countr) != null) total += Countries.GetItem(countr).GpdGrowth;
                if (total > countryWithBiggestTradePotentialGPD)
                {
                    countryWithBiggestTradePotentialGPD = total;
                    countryWithBiggestTradePotential = x.CountryName;
                }
            }

            Country c = Countries.GetItem(countryWithBiggestTradePotential);
            txtNameTrade.Text = c.CountryName;
            txtGpdTrade.Text = c.GpdGrowth.ToString();
            float gpdTemp = 0;
            foreach (string countr in c.MainTradePartners) if (Countries.GetItem(countr) != null) gpdTemp += Countries.GetItem(countr).GpdGrowth;
            txtGpdTradeSum.Text = gpdTemp.ToString();
            txtInflationTrade.Text = c.Inflation.ToString();
            txtTradeBalanceTrade.Text = c.TradeBalance.ToString();
            txtHdiTrade.Text = c.HdiRanking.ToString();
            listBoxTrade.Items.Clear();
            foreach (string s in c.MainTradePartners) listBoxTrade.Items.Add(s);
        }
    }
}
