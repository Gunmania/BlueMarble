namespace BlueMarble.View
{
    partial class RollDiceView
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
            this.rollBtn = new System.Windows.Forms.Button();
            this.dice1 = new System.Windows.Forms.Label();
            this.dice2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rollBtn
            // 
            this.rollBtn.Location = new System.Drawing.Point(94, 128);
            this.rollBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rollBtn.Name = "rollBtn";
            this.rollBtn.Size = new System.Drawing.Size(122, 39);
            this.rollBtn.TabIndex = 0;
            this.rollBtn.Text = "Roll";
            this.rollBtn.UseVisualStyleBackColor = true;
            this.rollBtn.Click += new System.EventHandler(this.rollBtn_Click);
            // 
            // dice1
            // 
            this.dice1.AutoSize = true;
            this.dice1.Font = new System.Drawing.Font("굴림", 40F);
            this.dice1.Location = new System.Drawing.Point(71, 54);
            this.dice1.Name = "dice1";
            this.dice1.Size = new System.Drawing.Size(52, 54);
            this.dice1.TabIndex = 1;
            this.dice1.Text = "?";
            // 
            // dice2
            // 
            this.dice2.AutoSize = true;
            this.dice2.Font = new System.Drawing.Font("굴림", 40F);
            this.dice2.Location = new System.Drawing.Point(186, 54);
            this.dice2.Name = "dice2";
            this.dice2.Size = new System.Drawing.Size(52, 54);
            this.dice2.TabIndex = 2;
            this.dice2.Text = "?";
            // 
            // RollDiceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 200);
            this.Controls.Add(this.dice2);
            this.Controls.Add(this.dice1);
            this.Controls.Add(this.rollBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RollDiceView";
            this.Text = "RollDiceView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rollBtn;
        private System.Windows.Forms.Label dice1;
        private System.Windows.Forms.Label dice2;
    }
}