using BlueMarble.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BlueMarble.Controller
{
    class PresetGameController
    {
        List<UserVO> userList;
        GameView gameView;

        public PresetGameController()
        {
            userList = ClassManagement.GetInstance().MakeNewUserVO();
        }

        /// <summary>
        /// 게임을 만드는 메소드입니다.
        /// </summary>
        /// <param 사람vs사람이 면 true입니다.="isVsUser"></param>
        /// <param 게임시작시 소지할 돈="money"></param>
        /// <param 지도="map"></param>
        /// <param 1p의 이름="name_1p"></param>
        /// <param 2p의 이름(컴퓨터랑 하면 NULL)="name_2p"></param>
        public void MakeGame(bool isVsUser, int money, string map, string name_1p, string name_2p)
        {
            UserVO player1, player2;
            gameView = ClassManagement.GetInstance().GetGameView();
            if (isVsUser)
            {
                player1 = new UserVO(money, 0, name_1p);
                userList.Add(player1);
                player2 = new UserVO(money, 0, name_2p);
                userList.Add(player2);
                gameView.ChangeName(name_1p, name_2p);
                MessageBox.Show("게임을 시작합니다. " + name_1p + " VS " + name_2p, "완료");
            }
            else
            {
                player1 = new UserVO(money, 0, name_1p);
                userList.Add(player1);
                player2 = new UserVO(money, 0, "Computer");
                userList.Add(player2);
                gameView.ChangeName(name_1p, "Computer");
                MessageBox.Show("게임을 시작합니다. " + name_1p + " VS Computer", "완료");
            }
            gameView.Show();
        }
    }
}
