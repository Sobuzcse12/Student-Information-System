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

    public partial class EditWindows : Form
    {
        private Edit edit;
        private Search search;
        public EditWindows()
        {
            InitializeComponent();
            edit = new Edit();
            search = new Search();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            searchBox.Text = "";
            nameBox.Text = "";
            idBox.Text = "";
            yearBox.Text = "";
            cgpaBox.Text = "";
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            
            edit.setSearch(searchBox.Text);
            edit.setNewName(nameBox.Text);
            edit.setNewID(idBox.Text);
            edit.setNewYear(yearBox.Text);
            edit.setNewCGPA(cgpaBox.Text);
            edit.editInfoFromFile();
            DialogResult result = MessageBox.Show("You sure you want to edit this information?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    edit.editInfoFromFile();
                    MessageBox.Show("The Student Id has been edited successfully", "Edit Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void editSearchButton_Click(object sender, EventArgs e)
        {
            search.setSearch(searchBox.Text);
            if (search.searchFile())
            {
                nameBox.Text = search.getName();
                idBox.Text = search.getID();
                yearBox.Text = search.getYear();
                cgpaBox.Text = search.getCGPA();
            }
            else
            {
                
            }
            edit.setSearch(searchBox.Text);
            if (edit.findID())
            {
                MessageBox.Show("Student_Id is valid. Now You can edit the Information?", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                editButton.Enabled = true;
            }
            else 
            {
                MessageBox.Show("Student_Id is not valid", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeWindows hw = new HomeWindows();
            hw.Show();
        }

      
    }
}
