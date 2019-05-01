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
        private UserVO m_userVO; //여기다가 넣고 불러오면됨
        private CityVO m_cityVO;
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
    }
}
