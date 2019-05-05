using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//PhaseController
//말이 이동 후 PhaseController를 통해 Event를 진행합니다.
//말 이동 후 View에서 PhaseController에 params를 이용해 UserVO, Phase를 전달합니다.
//PhaseController에서 params를 검사 후 Phase별로 Controller를 handle합니다.
//이동 후 PhaseController.CheckPhase(UserVO,1);을 해주세요.
//--------------------------------------------------------
//phase
//  1 : 이동 후 땅을 체크, 해당 결과에 따른 이벤트 진행
//  2 : 여행도착 후 다음턴에 이동할 곳을 고르는 이벤트 진행
//--------------------------------------------------------

namespace BlueMarble.Controller
{
    class PhaseController
    {
        LandPhaseController landPhaseController;
        //phase에는 UserVO.phase값을 넣어주세요.
        public void CheckPhase(UserVO user, int phase)
        {
            switch (phase)
            {
                case 1:
                    landPhaseController.LandPhase(user);
                    break;
                case 2:
                    //다음작업
                    break;
            }
        }

    }
}
