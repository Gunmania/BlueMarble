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
        //무인도에 들어갔을 때 사용할 변수
        //기본값은 0이며 무인도에 들어가면 1추가.
        //1일때 -1 해주며 턴을 종료
        private int sleep;

        //Phase 나눌 때 사용.
        //여행 시 phase가 나눠질 지, 더 크게 나눌지 고민.
        private int phase;

        public UserVO(int cash, int position, string s_name, int s_sleep, int s_phase)
        {
            this.money = cash;
            this.location = position;
            this.name = s_name;
            this.sleep = s_sleep;
            this.phase = s_phase;
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

        public int Sleep
        {
            get { return sleep; }
            set { this.sleep = value; }
        }

        public int Phase
        {
            get { return phase; }
            set { this.phase = value; }
        }



    }
}
