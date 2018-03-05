using System;
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

        public static void csvToAVLTree(ref AVLTree<Country> Countries, String filePath) {
            string[][] countries = File.ReadAllLines(filePath).Select(i => i.Split(',')).ToArray();
            for (int i = 1; i < countries.Length; i++) Countries.InsertItem(new Country(countries[i][0], float.Parse(countries[i][1]), float.Parse(countries[i][2]), float.Parse(countries[i][3]), int.Parse(countries[i][4]), countries[i][5].Split(';').Select(x => new Regex("([[]|[]])").Replace(x, "")).ToArray()));
            // string s = ""; Countries.PostOrder(ref s); Console.WriteLine(s); Console.WriteLine(Countries.Height());
        }

        public static void showCountries(string search, ListBox listBoxCountries, AVLTree<Country> Countries)
        {
            string[] CountriesText = getCountries(Countries);
            foreach (string s in CountriesText) if (s.ToLower().Contains(search.ToLower())) listBoxCountries.Items.Add(s);
        }

        public static void setAvlData(Label label, AVLTree<Country> Countries)
        {
            label.Text = "Countries: " + Countries.Count() + ", Height: "+ Countries.Height();
        }

        public static string[] getCountries(AVLTree<Country> Countries) {
            string CountriesTextStr = "";
            Countries.PostOrder(ref CountriesTextStr);
            return CountriesTextStr.Split(',').Where(p => p != "").ToArray();
        }
    }
}
