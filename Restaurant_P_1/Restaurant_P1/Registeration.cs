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
    public partial class Registeration : Form
    {
        public Registeration()
        {
            InitializeComponent();
        }
        
        private void log_in_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome " + UserName.Text);
            this.Close();
            Thread th = new Thread(OpenNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            
        }

        void OpenNewForm()
        {
            Application.Run(new MainForm());
        }
    }
}
