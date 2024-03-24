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
    public partial class New_register : Form
    {
        public New_register()
        {
            InitializeComponent();
        }

        private void log_in_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("User Name: "+UserName.Text + "\n"+ "Password: " + UserPW.Text + "\n" + "Phone: " + UserPhoneNum.Text + "\n" + "Email: " + UserEmail.Text  , "Are you sure you want to save ?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Signed Successfully");
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
            
        }
    }
}
