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
    public partial class Game : Form
    {
        Font fButoon = new Font("Microsoft Sans Serif", 18);
        Size sButton = new Size(50, 50);


        bool turn = true;// true = O turn; false = X turn 
        public int size = 10;
        Button[,] playGround; 
        Button clickedButton;

        public Game()
        {
            InitializeComponent();
            setSizeLabel();
            drawPlayGround();
        }

       
        private void startGameMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void changeSizeMenuItem_Click(object sender, EventArgs e)
        {
            sizeForm ChangeSizeForm = new sizeForm(this);
             
            ChangeSizeForm.Show();
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
            checkIfWin(clickedButton);
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

        public void setSizeLabel()
        {
            sizeLabel.Text = $"{size}x{size}";
        }

        public void drawPlayGround()
        {
        
            int positionX = 60;
            int positionY = 90;
            playGround = new Button[size, size];
            int name = 0;
            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size; ++j)
                {
                    int sum = i + j;
                    playGround[i, j] = creatButton(positionX, positionY, name++);
                    this.Controls.Add(playGround[i,j]);
                    positionX += sButton.Width;
                }
                positionX = 60;
                positionY += sButton.Height;
            }
            
        }

        private Button creatButton(int postionX, int positonY, int i)
        {
            Button newButton = new Button();
            newButton.Name = i.ToString();
            newButton.Location = new Point(postionX, positonY);
            newButton.Size = sButton;
            newButton.Font = fButoon;
            newButton.Click += button_click;

            return newButton;
        }

        public void UpdateButtonSizeAndFont()
        {
            if (size > 18)
            {
                sButton.Width = 20;
                sButton.Height = 20;
                fButoon = new Font("Microsoft Sans Serif", 8);
            } 
            else if (size > 12) 
            {
                sButton.Width = 35;
                sButton.Height = 35;
                fButoon = new Font("Microsoft Sans Serif", 12);
            }
            else
            {
                sButton.Width = 50;
                sButton.Height = 50;
                fButoon = new Font("Microsoft Sans Serif", 18);
            }
            
        }

        public void ResetPlayGround()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                { 
                    this.Controls.Remove(playGround[i, j]);  
                }
            }
        }

        private void checkIfWin(Button btn)
        {   
            int position = Int32.Parse(btn.Name);
            int positionX = position / size;
            int positionY = position % size;

          //  checkHorizontal(positionX, positionY) ||
            bool win =  checkVertical(positionX,positionY);

           // test.Text = win.ToString();
        }

        private bool checkHorizontal(int x, int y)
        {
            string player = playGround[x, y].Text;
            int count = 0;
            for (int i = 0; i<5; i++)
            {   
                if(y + i >= size)
                {
                    break;
                }
                else if (player == playGround[x, y + i].Text)
                {
                    count++;
                   
                }
                else 
                {
                    break;
                }
            }
            for (int i = 1; i < 5; i++)
            {
                if (y - i < 0)
                {
                    break;
                }
                else if (player == playGround[x, y - i].Text)
                {
                    count++;
                   
                }
                else
                {
                    break;
                }
            }
           
            if (5 <= count) return true;
            
            return false;
        }

        private bool checkVertical(int x, int y)
        {
            string player = playGround[x, y].Text;
            int count = 0;
            for (int i = 0; i < 5; i++)
            {
                if (count >= 5) break;
                if (x + i >= size)
                {
                    break;
                }
                else if (player == playGround[x + i, y].Text)
                {
                    count++;

                }
                else
                {
                    break;
                }
            }
            for (int i = count; i < 5 ; i++)
            { if (count >= 5) break;
                if (x - i < 0)
                {
                    break;
                }
                else if (player == playGround[x - 1, y].Text)
                {
                    count++;

                }
                else
                {
                    break;
                }
            }
            test.Text = count.ToString();
            if (5 <= count) return true;

            return false;
        }
    }
}
