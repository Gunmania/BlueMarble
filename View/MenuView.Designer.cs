namespace BlueMarble.View
{
    partial class MenuView
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
            this.startBtn = new System.Windows.Forms.Button();
            this.moneyBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vsComCheckBox = new System.Windows.Forms.CheckBox();
            this.vsUserCheckBox = new System.Windows.Forms.CheckBox();
            this.mapBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(482, 233);
            this.startBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(110, 58);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "게임시작";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // moneyBox
            // 
            this.moneyBox.Location = new System.Drawing.Point(266, 233);
            this.moneyBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moneyBox.Name = "moneyBox";
            this.moneyBox.Size = new System.Drawing.Size(190, 21);
            this.moneyBox.TabIndex = 2;
            this.moneyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.moneyBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.moneyBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 11F);
            this.label1.Location = new System.Drawing.Point(150, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "시작 금액";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 11F);
            this.label2.Location = new System.Drawing.Point(170, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "지도";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 30F);
            this.label3.Location = new System.Drawing.Point(235, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 40);
            this.label3.TabIndex = 5;
            this.label3.Text = "Blue Marble";
            // 
            // vsComCheckBox
            // 
            this.vsComCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.vsComCheckBox.AutoSize = true;
            this.vsComCheckBox.Location = new System.Drawing.Point(379, 198);
            this.vsComCheckBox.Name = "vsComCheckBox";
            this.vsComCheckBox.Size = new System.Drawing.Size(64, 22);
            this.vsComCheckBox.TabIndex = 6;
            this.vsComCheckBox.Text = "VS COM";
            this.vsComCheckBox.UseVisualStyleBackColor = true;
            this.vsComCheckBox.CheckedChanged += new System.EventHandler(this.vsComCheckBox_CheckedChanged);
            // 
            // vsUserCheckBox
            // 
            this.vsUserCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.vsUserCheckBox.AutoSize = true;
            this.vsUserCheckBox.Checked = true;
            this.vsUserCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.vsUserCheckBox.Location = new System.Drawing.Point(284, 198);
            this.vsUserCheckBox.Name = "vsUserCheckBox";
            this.vsUserCheckBox.Size = new System.Drawing.Size(61, 22);
            this.vsUserCheckBox.TabIndex = 7;
            this.vsUserCheckBox.Text = "VS User";
            this.vsUserCheckBox.UseVisualStyleBackColor = true;
            this.vsUserCheckBox.CheckedChanged += new System.EventHandler(this.vsUserCheckBox_CheckedChanged);
            // 
            // mapBox
            // 
            this.mapBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mapBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mapBox.FormattingEnabled = true;
            this.mapBox.Items.AddRange(new object[] {
            "한국",
            "미국",
            "일본"});
            this.mapBox.Location = new System.Drawing.Point(266, 271);
            this.mapBox.Name = "mapBox";
            this.mapBox.Size = new System.Drawing.Size(190, 20);
            this.mapBox.TabIndex = 8;
            this.mapBox.SelectedIndexChanged += new System.EventHandler(this.mapBox_SelectedIndexChanged);
            // 
            // MenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 390);
            this.Controls.Add(this.mapBox);
            this.Controls.Add(this.vsUserCheckBox);
            this.Controls.Add(this.vsComCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.moneyBox);
            this.Controls.Add(this.startBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuView";
            this.Text = "MenuView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.TextBox moneyBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox vsComCheckBox;
        private System.Windows.Forms.CheckBox vsUserCheckBox;
        private System.Windows.Forms.ComboBox mapBox;
    }
}