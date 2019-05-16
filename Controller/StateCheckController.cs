using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlueMarble.Controller
{
    class StateCheckController
    {
        private List<UserVO> userList;
        const int IDX_ISLAND = 0; // 무인도 인덱스

        public StateCheckController()
        {
            userList = ClassManagement.GetInstance().GetUserVO();
        }

        public Boolean CheckUserState(int playerNo) // 이동 가능한 상태인지 체크 (무인도)
        {
            if(userList[playerNo].Location == IDX_ISLAND)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
