using BlueMarble.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlueMarble.Controller
{
    class RollDiceController
    {
        RollDiceView rollDiceView;
        private int diceNumber;

        public RollDiceController()
        {
            rollDiceView = new RollDiceView();
        }

        public void ShowRollDiceView()
        {
            rollDiceView.Show();
        }

        public int RollDice()
        {
            Random random = new Random();

            diceNumber = random.Next(6) + 1;

            return diceNumber;        
        }
    }
}
