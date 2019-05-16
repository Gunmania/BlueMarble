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
            this.button1 = new System.Windows.Forms.Button();
            this.dice1 = new System.Windows.Forms.Label();
            this.dice2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Roll";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dice1
            // 
            this.dice1.AutoSize = true;
            this.dice1.Font = new System.Drawing.Font("굴림", 40F);
            this.dice1.Location = new System.Drawing.Point(81, 68);
            this.dice1.Name = "dice1";
            this.dice1.Size = new System.Drawing.Size(67, 67);
            this.dice1.TabIndex = 1;
            this.dice1.Text = "1";
            // 
            // dice2
            // 
            this.dice2.AutoSize = true;
            this.dice2.Font = new System.Drawing.Font("굴림", 40F);
            this.dice2.Location = new System.Drawing.Point(212, 68);
            this.dice2.Name = "dice2";
            this.dice2.Size = new System.Drawing.Size(67, 67);
            this.dice2.TabIndex = 2;
            this.dice2.Text = "1";
            // 
            // RollDiceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 250);
            this.Controls.Add(this.dice2);
            this.Controls.Add(this.dice1);
            this.Controls.Add(this.button1);
            this.Name = "RollDiceView";
            this.Text = "RollDiceView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label dice1;
        private System.Windows.Forms.Label dice2;
    }
}