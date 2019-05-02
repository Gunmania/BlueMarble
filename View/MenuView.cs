using BlueMarble.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BlueMarble.View
{
    public partial class MenuView : Form
    {
        private PresetGameController gameController;

        public MenuView()
        {
            InitializeComponent();
            gameController = ClassManagement.GetInstance().getPresetGame();
        }

        private void vsUserCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (vsUserCheckBox.Checked)
            {
                vsComCheckBox.Checked = false;
                playerName2.Enabled = true;
            }
        }

        private void vsComCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (vsComCheckBox.Checked)
            {
                vsUserCheckBox.Checked = false;
                playerName2.Enabled = false;
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            List<UserVO> list ;
            if (checkTextBox())
                gameController.MakeGame(vsUserCheckBox.Checked, int.Parse(moneyBox.Text), mapBox.Text, playerName1.Text, playerName2.Text);
            list = ClassManagement.GetInstance().GetUserVO();
            MessageBox.Show("굿", list[0].Name+"  "+list[1].Name);

        }

        //각 위치에 정확한 값이 들어갔나 확인한다.
        public bool checkTextBox()
        {
            if (moneyBox.TextLength < 1)
                return false;
            else if (playerName1.TextLength < 1)
                return false;
            else if (!vsUserCheckBox.Checked && playerName2.TextLength < 1)
                return false;
            else
                return true;
        }

        //숫자만 입력가능하게 함.
        private void moneyBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
