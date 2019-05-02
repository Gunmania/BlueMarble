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

        public PresetGameController()
        {
            userList = ClassManagement.GetInstance().MakeNewUserVO();
        }

        public void MakeGame(bool isVsUser,int money,string map,string name_1p, string name_2p)
        {
            UserVO player1, player2;
            if (isVsUser)
            {
                player1 = new UserVO(money, 0, name_1p);
                userList.Add(player1);
                player2 = new UserVO(money, 0, name_2p);
                userList.Add(player2);
            }
        }
    }
}
