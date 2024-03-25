using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            this.Close();
            Thread th = new Thread(OpenNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        void OpenNewForm()
        {
            Application.Run(new New_register());
        }

        private void عرضجميعالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
