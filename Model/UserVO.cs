using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlueMarble
{
    class UserVO
    {
        private int money;
        private int location;
        private string name;

        public UserVO(int cash, int position, string s_name)
        {
            this.money = cash;
            this.location = position;
            this.name = s_name;
        }

        public int Money
        {
            get { return money; }
            set { this.money = value ;}
        }
        public int Location
        {
            get { return location; }
            set { this.location = value; }
        }
        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

    }
}
