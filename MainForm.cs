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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registeration reg = new Registeration();
            reg.Show();
        }

        private void إغلاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void إضافةمستخدمجديدToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            New_register sign = new New_register();
            sign.Show();
        }

        private void عرضجميعالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
