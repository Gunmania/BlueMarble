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
    public partial class GameView : Form
    {
        public GameView()
        {
            InitializeComponent();
        }

        public void ChangeName(string onePName, string twoPName)
        {
            oneName.Text = onePName;
            twoName.Text = twoPName;
        }

        /// 강제로 X눌러서 종료했을시 MenuView 다시 출력
        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            ClassManagement.GetInstance().GetMenuView().Opacity = 100;
            ClassManagement.GetInstance().DeleteGameView();
        }
    }
}
