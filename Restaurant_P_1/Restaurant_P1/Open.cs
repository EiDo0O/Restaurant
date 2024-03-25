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
    public partial class Open : Form
    {
        public Open()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(OpenNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        void OpenNewForm()
        {
            Application.Run(new Interface());
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
