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
    public partial class Show_allWindows : Form
    {
        List<Student> student;
        Show show;
        public Show_allWindows()
        {
            InitializeComponent();
            show = new Show();
            student = show.getList();
        }

        private void showAll_Button_Click(object sender, EventArgs e)
        {
            show.showAll();
            DataGridView.AutoSize = true;
            DataGridView.DataSource = student;          
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeWindows hw = new HomeWindows();
            hw.Show();          
        }
    }
}
