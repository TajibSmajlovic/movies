using Movies.Client.Helpers;
using Movies.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Timers;

namespace Movies.Client.Pages
{
    public partial class Game : IDisposable
    {
        private List<Hand> hands = new List<Hand>()
{
        new Hand{Selection = OptionsRPS.Paper, LosesAgainst = OptionsRPS.Scissors,
            WinsAgainst = OptionsRPS.Rock, Image = "paper.jpg"},

        new Hand{Selection = OptionsRPS.Rock, LosesAgainst = OptionsRPS.Paper,
            WinsAgainst = OptionsRPS.Scissors, Image = "rock.jpg"},

        new Hand{Selection = OptionsRPS.Scissors, LosesAgainst = OptionsRPS.Rock,
            WinsAgainst = OptionsRPS.Paper, Image = "scissors.jpg"},
    };

        private Timer timer;
        private Hand opponentHand;
        private int indexOpponentHand = 0;
        private string resultMessage;

        protected override void OnInitialized()
        {
            opponentHand = hands[0];
            timer = new Timer();
            timer.Interval = 100;
            timer.Elapsed += TimerOnElapsed;
            timer.Start();
        }

        private void TimerOnElapsed(object sender, ElapsedEventArgs e)
        {
            indexOpponentHand = (indexOpponentHand + 1) % hands.Count;
            opponentHand = hands[indexOpponentHand];

            StateHasChanged();
        }

        public void SelectHand(Hand hand)
        {
            timer.Stop();

            var result = hand.PlayAgainst(opponentHand);

            if (result == GameEnums.Victory)
            {
                resultMessage = "WIN!!!";
            }
            else if (result == GameEnums.Draw)
            {
                resultMessage = "DRAW!!!";
            }
            else
            {
                resultMessage = "You lose!";
            }
        }

        private void PlayAgain()
        {
            timer.Start();
            resultMessage = string.Empty;
        }

        public void Dispose()
        {
            if (timer != null)
                timer.Dispose();
        }
    }
}