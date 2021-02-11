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
    public partial class sizeForm : Form
    {
        Game gameForm;
        public sizeForm(Game gameForm)
        {
            InitializeComponent();
            this.gameForm = gameForm;
        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.gameForm.ResetPlayGround();
            this.gameForm.size = (int)sizeChange.Value;
            this.gameForm.setSizeLabel();
            this.gameForm.UpdateButtonSizeAndFont();
            this.gameForm.drawPlayGround();
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
