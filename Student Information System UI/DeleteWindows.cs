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
    public partial class DeleteWindows : Form
    {
        private DeleteFromFile delete;

        public DeleteWindows()
        {
            delete = new DeleteFromFile();
            InitializeComponent();
        }

        private void Again_delete_Button_Click(object sender, EventArgs e)
        {
            deleteBox.Text = "";
        }

        private void search_Button_Click(object sender, EventArgs e)
        {
            delete.setSearch(deleteBox.Text);
            if (delete.FindStudent_Info())
            {
                MessageBox.Show("The Sutdent_ID is Valid.So You can delete this Information", "Found Result", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                deleteButton2.Enabled = true;
            }
            else 
            {
                MessageBox.Show("The Sutdent_ID is not Valid.So You cann't delete this Information", "Found Not Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void delete_Button_Click(object sender, EventArgs e)
        {
            delete.setSearch(deleteBox.Text);
            DialogResult result = MessageBox.Show("Do you want to delete this Information?", "Option", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            switch(result)
            {
                case DialogResult.Yes :
                    delete.deleteItemFromFile();
                    MessageBox.Show("This Student Information has been deleted from the information list successfully", "Delete Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeWindows hw = new HomeWindows();
            hw.Show();
        }
    }
}
