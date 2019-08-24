using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardGames;

namespace YanivCardGame
{
    public partial class GameBoard : Form
    {
        public GameBoard(YanivGame game)
        {
            InitializeComponent();
            Game = game;
            PlayersCards = new List<PictureBox>()
            {
                playerCard1,
                playerCard2,
                playerCard3,
                playerCard4,
                playerCard5
            };
        }

        public YanivGame Game { get; set; }
        public List<PictureBox> PlayersCards { get; set; }

        private void startButton_Click(object sender, EventArgs e)
        {
            Game.ResetDeck();
            Game.Deck.Shuffle();
            //each com player and player is dealt 5 cards
            for (int i = 0; i < 5; i++)
            {
                //deal player a card and display player card on form
                Game.Deal(Game.Player.Hand);
                PlayersCards[i].Image = Game.Player.Hand[i].CardImage;
                //deal each com player a card
                foreach (var comPlayer in Game.comPlayers)
                {
                    Game.Deal(comPlayer.Hand);
                }
            }
        }

        private void pictureDeck_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureDiscard_Click(object sender, EventArgs e)
        {

        }


    }
}
