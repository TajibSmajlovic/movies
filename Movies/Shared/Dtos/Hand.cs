using Movies.Client.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Shared.Dtos
{
    public class Hand
    {
        public OptionsRPS Selection { get; set; }
        public OptionsRPS WinsAgainst { get; set; }
        public OptionsRPS LosesAgainst { get; set; }
        public string Image { get; set; }

        public GameEnums PlayAgainst(Hand opponentHand)
        {
            if (Selection == opponentHand.Selection)
            {
                return GameEnums.Draw;
            }

            if (LosesAgainst == opponentHand.Selection)
            {
                return GameEnums.Loss;
            }

            return GameEnums.Victory;
        }
    }
}