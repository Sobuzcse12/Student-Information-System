using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class HomeWindows : Form
    {
        public HomeWindows()
        {
            InitializeComponent();
        }
        private void addInfoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Windows add = new Add_Windows();
            add.Show();
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteWindows delete = new DeleteWindows();
            delete.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditWindows edit = new EditWindows();
            edit.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchWindows search = new SearchWindows();
            search.Show();
        }

        private void Show_all_Click(object sender, EventArgs e)
        {
            this.Hide();
            Show_allWindows show = new Show_allWindows();
            show.Show();
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Student Information System is developed by \nMd.Mostafizur Rahman\nId Number: 120234\nSecond Year First Term\nCSE Discipline\nKhulna University,Khulna");
        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Windows add = new Add_Windows();
            add.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteWindows delete = new DeleteWindows();
            delete.Show();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditWindows edit = new EditWindows();
            edit.Show();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchWindows search = new SearchWindows();
            search.Show();
        }

        private void Showall_Click(object sender, EventArgs e)
        {
            this.Hide();
            Show_allWindows Showall = new Show_allWindows();
            Showall.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to exit the programme?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            Exit_button.Enabled = true;
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to exit the programme?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            this.Close();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeWindows Back = new HomeWindows();
            Back.Show();
        }

    }
}
