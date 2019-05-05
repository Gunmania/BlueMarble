using BlueMarble.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlueMarble.Controller
{
    class LandPhaseController
    {

        GameView gameView = ClassManagement.GetInstance().GetGameView();
        List<CityVO> presentCity = ClassManagement.GetInstance().GetCityVO();


        public void LandPhase(UserVO user)
        {
            int location = user.Location;
            int salary = 1000;

            if (presentCity[location].Cityname == "출발지")
            {
                user.Money += salary;
            }
            else if (presentCity[location].Cityname == "무인도")
            {
                if (user.Sleep == 0)
                {
                    user.Sleep += 1;
                }
            }
            else if (presentCity[location].Cityname == "여행")
            {
                if (user.Phase == 1)
                {
                    user.Phase = 2;
                }
                else if (user.Phase == 2)
                {
                    gameView.TravelUi();
                }
            }
            else if (presentCity[location].Host == null)
            {
                gameView.Popup_BuyCity();
            }
            else if (presentCity[location].Host != user.Name)
            {
                user.Money -= presentCity[location].Cost;
            }

        }
    }
}
