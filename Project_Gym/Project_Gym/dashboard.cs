using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Gym
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void eQUITMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void new_member_Click(object sender, EventArgs e)
        {
            newmember nm = new newmember();
            nm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lOGOUTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Sucessful !");
            login lg = new login();
            lg.Show();
            this.Hide();
        }

        private void rEMOVEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
