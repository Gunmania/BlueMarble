using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BlueMarble
{
    class MapVO
    {
        private int size { get { return size; } }
        private string name { get { return name;  } }
        private List<CityVO> cityList { get { return cityList; } }

        MapVO()
        {

        }

        public void MapInit(string mapName)
        {
            StreamReader reader = new StreamReader("./data/map/"+mapName+"/map.csv"); // 스트림 리더 생성 & 맵 불러오기

            foreach () {
                //각 줄의 내용을 쉼표로 분리 (도시명, 가격, 이미지 파일명)

                CityVO tmpCity = new CityVO(); // 임시변수 생성

                //임시변수에 쉼표로 분리한값 삽입
                cityList.Add(tmpCity); //도시 리스트에 삽입
            }
        }
    }
}
