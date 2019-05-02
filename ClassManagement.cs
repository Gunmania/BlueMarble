using BlueMarble.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlueMarble
{
    class ClassManagement
    {   
        //모든 곳에서 같은 객체를 공유해야 할 경우에는 여기다가 객체를 만들어 넣고 사용하면 됩니다.
        //객체를 불러올때에는 ClassManagement.GetInstance().~~~
        private static ClassManagement s_instance;
        private List<UserVO> m_userList;
        private List<CityVO> m_cityVO;
        private PresetGameController m_preset;

        public static ClassManagement GetInstance()
        {
            if (s_instance == null) s_instance = new ClassManagement();
            return s_instance;
        }

        public PresetGameController getPresetGame() {
            if (m_preset == null) m_preset = new PresetGameController();
            return m_preset;
        }

        public List<UserVO> GetUserVO()
        {
            if (m_userList == null) m_userList = new List<UserVO>();
            return m_userList;
        }

        //게임 재시작을 했을경우 UserList 초기화
        public List<UserVO> MakeNewUserVO()
        {
            m_userList = new List<UserVO>();
            return m_userList;
        }
    }
}
