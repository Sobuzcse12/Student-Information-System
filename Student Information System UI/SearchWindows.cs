using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BO;
namespace UserInterface
{
    public partial class SearchWindows : Form
    {
        Search search;
        public SearchWindows()
        {
            InitializeComponent();
            search = new Search();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            search.setSearch(searchBox.Text);
            if (search.searchFile())
            {
                nameBox.Text = search.getName();
                idBox.Text = search.getID();
                yearBox.Text = search.getYear();
                cgpaBox.Text = search.getCGPA();
            }
            else {
                MessageBox.Show("Nothing Found", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void reEnterButton_Click(object sender, EventArgs e)
        {
            searchBox.Text = "";
            nameBox.Text = "";
            idBox.Text = "";
            yearBox.Text = "";
            cgpaBox.Text = "";
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeWindows hw = new HomeWindows();
            hw.Show();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
