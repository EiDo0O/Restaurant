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
    public partial class Open : Form
    {
        public Open()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            Interface main = new Interface();
            main.Show();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
