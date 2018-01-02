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
    public partial class Add_Windows : Form
    {
        private  Save write;
        public Add_Windows()
        {
            InitializeComponent();
            write = new Save();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            write.setName(NameBox.Text);
            write.setID(IdBox.Text);
            write.setYear(YearComboBox.Text);
            write.setCGPA(CGPABox.Text);
            write.writeIntoFile();
            MessageBox.Show("Your information saved successfully.","Save Result",MessageBoxButtons.OK,MessageBoxIcon.None);
        }

        private void AgainAdd_Button_Click(object sender, EventArgs e)
        {
            NameBox.Text = "";
            IdBox.Text = "";
            YearComboBox.Text = "";
            CGPABox.Text = "";
        }
        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeWindows hw = new HomeWindows();
            hw.Show();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
