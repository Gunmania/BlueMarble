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

        public RollDiceController()
        {
            rollDiceView = new RollDiceView();
        }

        public void ShowRollDiceView()
        {
            rollDiceView.Show();
        }

    }
}
