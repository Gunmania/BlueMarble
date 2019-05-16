using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlueMarble.Controller
{
    class MoveController
    {
        List<UserVO> userList;

        public MoveController()
        {
            userList = ClassManagement.GetInstance().GetUserVO();
        }

        public void MovePlayer(int playerNo, int count)
        {
            int currentLoc = userList[playerNo].Location;
            int moveCount = count;

            if(currentLoc + count > MapVO.size) // 시작점을 넘을 경우
            {
                moveCount = (currentLoc + count) - MapVO.size;
                userList[playerNo].Location = moveCount;
                userList[playerNo].Money += 5000; //월급 지급
            }
        }
    }
}
