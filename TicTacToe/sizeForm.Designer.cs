
namespace TicTacToe
{
    partial class sizeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cancel = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.sizeChange = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.sizeChange)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(23, 55);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 0;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(127, 55);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 1;
            this.ok.Text = "Ok!";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sizeLabel.Location = new System.Drawing.Point(14, 19);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(44, 20);
            this.sizeLabel.TabIndex = 3;
            this.sizeLabel.Text = "Size:";
            // 
            // sizeChange
            // 
            this.sizeChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.sizeChange.Location = new System.Drawing.Point(64, 11);
            this.sizeChange.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.sizeChange.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sizeChange.Name = "sizeChange";
            this.sizeChange.Size = new System.Drawing.Size(62, 38);
            this.sizeChange.TabIndex = 4;
            this.sizeChange.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // sizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 90);
            this.Controls.Add(this.sizeChange);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.Cancel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "sizeForm";
            this.ShowIcon = false;
            this.Text = "Change Size";
            ((System.ComponentModel.ISupportInitialize)(this.sizeChange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.NumericUpDown sizeChange;
    }
}