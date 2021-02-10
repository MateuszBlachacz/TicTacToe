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
        bool turn = true;// true = O turn; false = X turn 
        int size = 10;
        Button clickedButton;
        public Form1()
        {
            InitializeComponent();
            setSizeLabel();
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

        private void button_click(object sender, EventArgs e)
        {
            clickedButton = (Button)sender;
            markTheGameField();
            clickedButton.Enabled = false;
        }

        private void markTheGameField()
        {
            if (turn)
            {
                clickedButton.Text = "O";
            } 
            else
            {
                clickedButton.Text = "X";
            }
            turn = !turn;
        }

        private void setSizeLabel()
        {
            sizeLabel.Text = $"{size}x{size}";
        }
    }
}
