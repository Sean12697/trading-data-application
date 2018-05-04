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
            setup("countries.csv"); // Used to intially load the form, but to also load for a new csv file
        }

        private void setup(string file)
        {
            Program.csvToAVLTree(ref Countries, file);
            Program.setAvlData(lblInfo, Countries);
            Program.showCountries("", listBoxCountries, Countries, checkBoxTradingPartner);
            Program.setBiggestTradingPartner(ref Countries, txtNameTrade, txtGpdTrade, txtGpdTradeSum, txtInflationTrade, txtTradeBalanceTrade, txtHdiTrade, listBoxTrade);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Program.showCountries(txtSearch.Text, listBoxCountries, Countries, checkBoxTradingPartner);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Program.showCountries(txtSearch.Text, listBoxCountries, Countries, checkBoxTradingPartner);
        }

        private void listBoxCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.updateCountryTextBoxes(ref Countries, listBoxCountries, txtName, txtGpdGrowth, txtInflation, txtTradeBalance, txtHdiRanking, listBoxTradingPartners, addTradePartner);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Program.deleteCountry(ref Countries, listBoxCountries, lblInfo, txtSearch, checkBoxTradingPartner);
            Program.clearTextBoxes(txtName, txtGpdGrowth, txtInflation, txtTradeBalance, txtHdiRanking, listBoxTradingPartners);
            Program.setBiggestTradingPartner(ref Countries, txtNameTrade, txtGpdTrade, txtGpdTradeSum, txtInflationTrade, txtTradeBalanceTrade, txtHdiTrade, listBoxTrade);
        }

        private void checkBoxTradingPartner_CheckedChanged(object sender, EventArgs e)
        {
            Program.showCountries(txtSearch.Text, listBoxCountries, Countries, checkBoxTradingPartner);
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            updateCountry("Name", ref e);
        }

        private void txtGpdGrowth_KeyUp(object sender, KeyEventArgs e)
        {
            updateCountry("GPD", ref e);
        }

        private void txtInflation_KeyUp(object sender, KeyEventArgs e)
        {
            updateCountry("Inflation", ref e);
        }

        private void txtTradeBalance_KeyUp(object sender, KeyEventArgs e)
        {
            updateCountry("TradeBalance", ref e);
        }

        private void txtHdiRanking_KeyUp(object sender, KeyEventArgs e)
        {
            updateCountry("HdiRanking", ref e);
        }

        private void updateCountry(string updating, ref KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // if the enter key was pressed in a country data field
            {
                // updating to be used in a switch case
                Program.updateCountry(ref Countries, updating, listBoxCountries, txtName, txtGpdGrowth, txtInflation, txtTradeBalance, txtHdiRanking);
                Program.showCountries(txtSearch.Text, listBoxCountries, Countries, checkBoxTradingPartner); // display results
                // update biggest trading partner if changed 
                Program.setBiggestTradingPartner(ref Countries, txtNameTrade, txtGpdTrade, txtGpdTradeSum, txtInflationTrade, txtTradeBalanceTrade, txtHdiTrade, listBoxTrade);
                e.Handled = true;
            }
        }

        private void listBoxTradingPartners_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                // Storing needed country values
                Country mainCountry = Countries.GetItem(new Country((String)listBoxCountries.SelectedItem));
                String tradingCountryName = (String)listBoxTradingPartners.SelectedItem;
                Country tradingCountry = Countries.GetItem(new Country(tradingCountryName));
                // Removing trading for both countries
                mainCountry.MainTradePartners = Program.removedCountryPartner(mainCountry.MainTradePartners, tradingCountryName);
                tradingCountry.MainTradePartners = Program.removedCountryPartner(tradingCountry.MainTradePartners, mainCountry.CountryName);
                // Update Trading Partner Listview
                Program.updateTradePartnersList(mainCountry, listBoxTradingPartners);
                e.Handled = true;
            }
        }

        private void btnAddTradePartner_Click(object sender, EventArgs e)
        {
            Program.addTradePartner(Countries, addTradePartner, listBoxCountries); // Blackbox function to add
            Program.updateAddTradePartners(Countries, addTradePartner, listBoxCountries); // remove it as an option to add again  
            Program.updateCountryTextBoxes(ref Countries, listBoxCountries, txtName, txtGpdGrowth, txtInflation, txtTradeBalance, txtHdiRanking, listBoxTradingPartners, addTradePartner); // shows new trade partner
            Program.setBiggestTradingPartner(ref Countries, txtNameTrade, txtGpdTrade, txtGpdTradeSum, txtInflationTrade, txtTradeBalanceTrade, txtHdiTrade, listBoxTrade); // could make the country the biggest potental of trade
        }

        private void addTradePartner_TextChanged(object sender, EventArgs e)
        {
            btnAddTradePartner.Enabled = (Program.getCountries(Countries).Contains((string)addTradePartner.SelectedItem));
        }

        private void loadCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setup("countries.csv");
        }
    }
}
