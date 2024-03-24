using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restraurant_P_1
{
    public partial class Registeration : Form
    {
        public Registeration()
        {
            InitializeComponent();
        }

        private void log_in_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            MessageBox.Show("Welcome " + UserName.Text);
        }
    }
}
