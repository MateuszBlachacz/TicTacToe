﻿
namespace TicTacToe
{
    partial class Game
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startGameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playOnceMoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSizeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.win = new System.Windows.Forms.Label();
            this.winOLabel = new System.Windows.Forms.Label();
            this.winXlabel = new System.Windows.Forms.Label();
            this.winOText = new System.Windows.Forms.Label();
            this.winXText = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(775, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startGameMenuItem,
            this.playOnceMoreToolStripMenuItem,
            this.changeSizeMenuItem,
            this.exitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // startGameMenuItem
            // 
            this.startGameMenuItem.Name = "startGameMenuItem";
            this.startGameMenuItem.Size = new System.Drawing.Size(152, 22);
            this.startGameMenuItem.Text = "Start Game";
            this.startGameMenuItem.Click += new System.EventHandler(this.startGameMenuItem_Click);
            // 
            // playOnceMoreToolStripMenuItem
            // 
            this.playOnceMoreToolStripMenuItem.Name = "playOnceMoreToolStripMenuItem";
            this.playOnceMoreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.playOnceMoreToolStripMenuItem.Text = "PlayOnceMore";
            this.playOnceMoreToolStripMenuItem.Click += new System.EventHandler(this.playOnceMoreMenuItem_Click);
            // 
            // changeSizeMenuItem
            // 
            this.changeSizeMenuItem.Name = "changeSizeMenuItem";
            this.changeSizeMenuItem.Size = new System.Drawing.Size(152, 22);
            this.changeSizeMenuItem.Text = "Change size";
            this.changeSizeMenuItem.Click += new System.EventHandler(this.changeSizeMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutMenuItem.Text = "About";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.sizeLabel.Location = new System.Drawing.Point(21, 39);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(86, 31);
            this.sizeLabel.TabIndex = 110;
            this.sizeLabel.Text = "label1";
            // 
            // win
            // 
            this.win.AutoSize = true;
            this.win.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.win.Location = new System.Drawing.Point(358, 24);
            this.win.Name = "win";
            this.win.Size = new System.Drawing.Size(60, 31);
            this.win.TabIndex = 111;
            this.win.Text = "Win";
            // 
            // winOLabel
            // 
            this.winOLabel.AutoSize = true;
            this.winOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.winOLabel.Location = new System.Drawing.Point(274, 55);
            this.winOLabel.Name = "winOLabel";
            this.winOLabel.Size = new System.Drawing.Size(43, 31);
            this.winOLabel.TabIndex = 112;
            this.winOLabel.Text = "O:";
            // 
            // winXlabel
            // 
            this.winXlabel.AutoSize = true;
            this.winXlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.winXlabel.Location = new System.Drawing.Point(389, 55);
            this.winXlabel.Name = "winXlabel";
            this.winXlabel.Size = new System.Drawing.Size(40, 31);
            this.winXlabel.TabIndex = 113;
            this.winXlabel.Text = "X:";
            // 
            // winOText
            // 
            this.winOText.AutoSize = true;
            this.winOText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.winOText.Location = new System.Drawing.Point(336, 55);
            this.winOText.Name = "winOText";
            this.winOText.Size = new System.Drawing.Size(29, 31);
            this.winOText.TabIndex = 114;
            this.winOText.Text = "0";
            // 
            // winXText
            // 
            this.winXText.AutoSize = true;
            this.winXText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.winXText.Location = new System.Drawing.Point(455, 55);
            this.winXText.Name = "winXText";
            this.winXText.Size = new System.Drawing.Size(29, 31);
            this.winXText.TabIndex = 115;
            this.winXText.Text = "0";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 712);
            this.Controls.Add(this.winXText);
            this.Controls.Add(this.winOText);
            this.Controls.Add(this.winXlabel);
            this.Controls.Add(this.winOLabel);
            this.Controls.Add(this.win);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Game";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startGameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeSizeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.ToolStripMenuItem playOnceMoreToolStripMenuItem;
        private System.Windows.Forms.Label win;
        private System.Windows.Forms.Label winOLabel;
        private System.Windows.Forms.Label winXlabel;
        private System.Windows.Forms.Label winOText;
        private System.Windows.Forms.Label winXText;
    }
}

