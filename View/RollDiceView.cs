using BlueMarble.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BlueMarble.View
{
    public partial class RollDiceView : Form
    {
        private RollDiceController rollDiceController;
        private MoveController moveController;
        private StateCheckController stateCheckController;
        List<UserVO> userList;
        int ternPlayer;
        const int IDX_ISLAND = 0;

        public bool stopDice = false;

        public RollDiceView()
        {
            InitializeComponent();
            userList = ClassManagement.GetInstance().GetUserVO();

            rollDiceController = new RollDiceController();
            moveController = new MoveController();
            stateCheckController = new StateCheckController();
        }

        private void rollBtn_Click(object sender, EventArgs e)
        {
            if(stateCheckController.CheckUserState(ternPlayer) == true) //무인도에 있지 않을 경우에만 -> StateCheckController로 함수 뺄지 판단 필요.
            {
                int nDice1 = rollDiceController.RollDice();
                dice1.Text = nDice1.ToString();

                int nDice2 = rollDiceController.RollDice();
                dice2.Text = nDice2.ToString();

                //더블 처리

                moveController.MovePlayer(ternPlayer, nDice1 +nDice2);
            }
            else
            {
                MessageBox.Show("플레이어가 무인도에 있습니다.", "Alert");
            }
            
        }
    }
}
