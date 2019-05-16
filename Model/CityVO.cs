using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlueMarble
{
    class CityVO
    {
        private int price;
        private string name, imgFIleLocation;
        private UserVO player;

        public int getCityPrice()
        {
            return price;
        }

        public string getCityName()
        {
            return name;
        }

        public void setCityOwner(UserVO argPlayer)
        {
            player = argPlayer;
        }
    }
}
