using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlueMarble
{

    class CityVO
    {
        private string cityname;
        private int cost;
        //땅 주인으로 구매 시 UserVO의 name값을 넣는다.
        private string host;

        public CityVO(string cityname, int cost, string host)
        {
            this.cityname = cityname;
            this.cost = cost;
            this.host = host;

        }

        public string Cityname
        {
            get { return cityname; }
            set { this.cityname = value; }
        }

        public int Cost
        {
            get { return cost; }
            set { this.cost = value; }
        }

        public string Host
        {
            get { return host; }
            set { this.host = value; }
        }

    }
}


