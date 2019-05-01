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
            }
        }

        private void vsComCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (vsComCheckBox.Checked)
            {
                vsUserCheckBox.Checked = false;
            }
        }

        private void mapBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            gameController.MakeGame(vsUserCheckBox.Checked, int.Parse(moneyBox.Text), mapBox.Text);
        }

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
