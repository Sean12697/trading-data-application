using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradingDataApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        // Part 1
        public static void csvToAVLTree(ref AVLTree<Country> Countries, String filePath) {
            Countries = new AVLTree<Country>(); // Reset to clear if another file is loaded
            string[][] countries = File.ReadAllLines(filePath).Select(i => i.Split(',')).ToArray(); // Lamdba/arrow function within a Map type function
            for (int i = 1; i < countries.Length; i++) Countries.InsertItem(new Country(countries[i][0], float.Parse(countries[i][1]), float.Parse(countries[i][2]), float.Parse(countries[i][3]), int.Parse(countries[i][4]), countries[i][5].Split(';').Select(x => new Regex("([[]|[]])").Replace(x, "")).ToArray()));
            // string s = ""; Countries.InOrder(ref s); Console.WriteLine(s);
        }

        public static void updateCountryTextBoxes(ref AVLTree<Country> Countries, ListBox listBoxCountries, TextBox txtName, TextBox txtGpdGrowth, TextBox txtInflation, TextBox txtTradeBalance, TextBox txtHdiRanking, ListBox listBoxTradingPartners, ComboBox addTradePartner)
        {
            Country c = Countries.GetItem(new Country((String)listBoxCountries.SelectedItem));
            txtName.Text = c.CountryName;
            txtGpdGrowth.Text = c.GpdGrowth.ToString();
            txtInflation.Text = c.Inflation.ToString();
            txtTradeBalance.Text = c.TradeBalance.ToString();
            txtHdiRanking.Text = c.HdiRanking.ToString();
            listBoxTradingPartners.Items.Clear();
            foreach (string s in c.MainTradePartners) listBoxTradingPartners.Items.Add(s);
            updateAddTradePartners(Countries, addTradePartner, listBoxCountries);
        }

        public static void showCountries(string search, ListBox listBoxCountries, AVLTree<Country> Countries, CheckBox checkBox) // checkBoxTradingPartner
        {
            string[] CountriesText = getCountries(Countries);
            listBoxCountries.Items.Clear();
            if (checkBox.Checked) { //Part 6 & 7
                foreach (string s in CountriesText) if (Contains(Countries.GetItem(new Country(s)).MainTradePartners, search)) listBoxCountries.Items.Add(s);
            } else {
                foreach (string s in CountriesText) if (s.ToLower().Contains(search.ToLower())) listBoxCountries.Items.Add(s);
            }
        }

        private static Boolean Contains(string[] MainTradePartners, string term)
        {
            foreach (string mtd in MainTradePartners) if (mtd.ToLower().Contains(term.ToString().ToLower())) return true; return false;
        }

        public static void clearTextBoxes(TextBox txtName, TextBox txtGpdGrowth, TextBox txtInflation, TextBox txtTradeBalance, TextBox txtHdiRanking, ListBox listBoxTradingPartners)
        {
            txtName.Text = "";
            txtGpdGrowth.Text = "";
            txtInflation.Text = "";
            txtTradeBalance.Text = "";
            txtHdiRanking.Text = "";
            listBoxTradingPartners.Items.Clear();
        }

        // Part 3
        public static void setAvlData(Label label, AVLTree<Country> Countries)
        {
            label.Text = "Countries: " + Countries.Count() + ", Height: " + Countries.Height();
        }

        public static string[] getCountries(AVLTree<Country> Countries) {
            string CountriesTextStr = "";
            Countries.InOrder(ref CountriesTextStr); // Part 5
            return CountriesTextStr.Split(',').Where(p => p != "").ToArray();
        }

        public static string[] removedCountryPartner(string[] tradePartners, string name)
        {
            ArrayList removed = new ArrayList();
            for (int i = 0; i < tradePartners.Length; i++) if (!tradePartners[i].Equals(name)) removed.Add(tradePartners[i]);
            return (string[])removed.ToArray(typeof(string));
        }

        // Part 8
        public static void setBiggestTradingPartner(ref AVLTree<Country> Countries, TextBox txtNameTrade, TextBox txtGpdTrade, TextBox txtGpdTradeSum, TextBox txtInflationTrade, TextBox txtTradeBalanceTrade, TextBox txtHdiTrade, ListBox listBoxTrade)
        {
            string[] CountriesText = getCountries(Countries);

            string countryWithBiggestTradePotential = "";
            float countryWithBiggestTradePotentialGPD = 0;

            foreach (string s in CountriesText)
            {
                Country x = Countries.GetItem(new Country(s));
                float total = 0;
                foreach (string countr in x.MainTradePartners) if (Countries.GetItem(new Country(countr)) != null) total += Countries.GetItem(new Country(countr)).GpdGrowth;
                if (total > countryWithBiggestTradePotentialGPD) {
                    countryWithBiggestTradePotentialGPD = total;
                    countryWithBiggestTradePotential = x.CountryName;
                }
            }

            Country c = Countries.GetItem(new Country(countryWithBiggestTradePotential));
            txtNameTrade.Text = c.CountryName;
            txtGpdTrade.Text = c.GpdGrowth.ToString();
            float gpdTemp = 0;
            foreach (string countr in c.MainTradePartners) if (Countries.GetItem(new Country(countr)) != null) gpdTemp += Countries.GetItem(new Country(countr)).GpdGrowth;
            txtGpdTradeSum.Text = gpdTemp.ToString();
            txtInflationTrade.Text = c.Inflation.ToString();
            txtTradeBalanceTrade.Text = c.TradeBalance.ToString();
            txtHdiTrade.Text = c.HdiRanking.ToString();
            listBoxTrade.Items.Clear();
            foreach (string s in c.MainTradePartners) listBoxTrade.Items.Add(s);
        }

        public static void updateTradePartnersList(Country Country, ListBox listBoxTradingPartners)
        {
            listBoxTradingPartners.Items.Clear();
            foreach (string country in Country.MainTradePartners) listBoxTradingPartners.Items.Add(country);
        }

        // Part 4
        public static void deleteCountry(ref AVLTree<Country> Countries, ListBox listBoxCountries, Label lblInfo, TextBox txtSearch, CheckBox checkBoxTradingPartner)
        { if (listBoxCountries.SelectedIndex != -1) {
                String country = (String)listBoxCountries.SelectedItem;
                // simply removing the country from the AVL Tree
                Countries.RemoveItem(country);
                // removing all instances from other countries that traded with the removed country
                string[] countryNames = getCountries(Countries);
                foreach (string c in countryNames) Countries.updateItem(c, removedCountryPartner(Countries.GetItem(new Country(c)), country));
                // updates fields
                setAvlData(lblInfo, Countries);
                txtSearch.Text = "";
                showCountries(txtSearch.Text, listBoxCountries, Countries, checkBoxTradingPartner);
            }
        }

        private static Country removedCountryPartner(Country country, String partner)
        {
            country.MainTradePartners = removedCountryPartner(country.MainTradePartners, partner);
            return country;
        }

        // Part 2
        public static void updateCountry(ref AVLTree<Country> Countries, string updating, ListBox listBoxCountries, TextBox txtName, TextBox txtGpdGrowth, TextBox txtInflation, TextBox txtTradeBalance, TextBox txtHdiRanking)
        {
            Country county = Countries.GetItem(new Country((String)listBoxCountries.SelectedItem));
            string oldName = county.CountryName;
            switch (updating) {
                case "Name": county.CountryName = txtName.Text; break;
                case "GPD": county.GpdGrowth = float.Parse(txtGpdGrowth.Text); break;
                case "Inflation": county.Inflation = float.Parse(txtInflation.Text); break;
                case "TradeBalance": county.TradeBalance = float.Parse(txtTradeBalance.Text); break;
                case "HdiRanking": county.HdiRanking = int.Parse(txtHdiRanking.Text); break;
            } Countries.updateItem(oldName, county);

            // Updates countries that previously traded with the changed countries old name, to its new name
            if ("Name".Equals(updating))
            {
                string[] countryText = Program.getCountries(Countries);
                foreach (string s in countryText)
                {
                    Boolean changed = false;
                    Country temp = Countries.GetItem(new Country(s));
                    for (int i = 0; i < temp.MainTradePartners.Length; i++)
                    {
                        if (oldName.Equals(temp.MainTradePartners[i]))
                        {
                            temp.MainTradePartners[i] = txtName.Text;
                            changed = true;
                        }
                    }
                    if (changed) Countries.updateItem(temp.CountryName, temp);
                }
            }

        }

        public static void updateAddTradePartners(AVLTree<Country> Countries, ComboBox addTradePartner, ListBox listBoxCountries)
        { 
            if ((String)listBoxCountries.SelectedItem != "") {
            Country county = Countries.GetItem(new Country((String)listBoxCountries.SelectedItem));
            String[] countryTexts = getCountries(Countries);
            addTradePartner.Items.Clear();
            addTradePartner.SelectedItem = "";
            addTradePartner.SelectedIndex = -1;
            addTradePartner.SelectedText = "";
            addTradePartner.SelectedValue = "";
            foreach (string c in countryTexts) if (!county.MainTradePartners.Contains(c) && !c.Equals(county.CountryName)) addTradePartner.Items.Add(c);
            }        
        }

        public static void addTradePartner(AVLTree<Country> Countries, ComboBox cbAddTradePartner, ListBox listBoxCountries)
        {
            Country country = Countries.GetItem(new Country((String)listBoxCountries.SelectedItem));
            String countryAdding = (string)cbAddTradePartner.SelectedItem;
            Countries.updateItem(country.CountryName, addTradePartner(country, countryAdding));
            Countries.updateItem(countryAdding, addTradePartner(Countries.GetItem(new Country(countryAdding)), country.CountryName));
        }

        public static Country addTradePartner(Country country, string tradePartner)
        {
            string[] tp = new string[country.MainTradePartners.Length + 1];
            for (int i = 0; i < country.MainTradePartners.Length; i++) tp[i] = country.MainTradePartners[i];
            tp[country.MainTradePartners.Length] = tradePartner;
            country.MainTradePartners = tp;
            return country;
        }
    }
}
