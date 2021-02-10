using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void startGameMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void changeSizeMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Game was made Mateusz Błachacz", "About");
        }
    }
}
