using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invaders
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btInstructions_Click(object sender, EventArgs e)
        {
            Instructions f2 = new Instructions();
            //this.Hide();
            f2.ShowDialog();
            //this.Close();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            Game f2 = new Game();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
