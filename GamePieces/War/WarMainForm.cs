using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GamePieces;

namespace War
{
    public partial class WarMainForm : Form
    {
        private enum GameState
        {
            NewGame,
            BeforePlay

        }

        GameState state;
        PokerDeck deck;
        CardDeck player1Hand;
        CardDeck player2Hand;
        CardDeck player1Winnings;
        CardDeck player2Winnings;
        CardDeck player1Plays;
        CardDeck player2Plays;

        public WarMainForm()
        {
            InitializeComponent();
            state = GameState.NewGame;
        }

        private void ActionClick(object sender, EventArgs e)
        {
            switch (state)
            {
                case GameState.NewGame:
                    state = StartGame();
                    break;
                default:
                    break;
            }
        }

        private GameState StartGame()
        {
            deck = new PokerDeck("Red Back");
            player1Hand = deck.SpawnDeck();
            player2Hand = deck.SpawnDeck();
            player1Winnings = deck.SpawnDeck();
            player2Winnings = deck.SpawnDeck();
            player1Plays = deck.SpawnDeck();
            player2Plays = deck.SpawnDeck();

            return GameState.BeforePlay;
        }
    }
}
