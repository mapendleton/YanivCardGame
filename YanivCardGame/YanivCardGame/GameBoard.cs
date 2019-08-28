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
            //creates an array of lists(for com cards, so it can add and remove cards)
            comCards = new List<PictureBox>[Game.comPlayers.Count];
            for (int i = 0; i < Game.comPlayers.Count; i++)
            {
                switch (i+1)
                {
                    case 1:
                        com1.Visible = true;
                        comCards[i] = new List<PictureBox>()
                        {
                            com1card1,
                            com1card2,
                            com1card3,
                            com1card4,
                            com1card5
                        };
                        break;
                    case 2:
                        com2.Visible = true;
                        comCards[i] = new List<PictureBox>()
                        {
                            com2card1,
                            com2card2,
                            com2card3,
                            com2card4,
                            com2card5
                        };
                        break;
                    case 3:
                        com3.Visible = true;
                        comCards[i] = new List<PictureBox>()
                        {
                            com3card1,
                            com3card2,
                            com3card3,
                            com3card4,
                            com3card5
                        };
                        break;
                    case 4:
                        com4.Visible = true;
                        comCards[i] = new List<PictureBox>()
                        {
                            com4card1,
                            com4card2,
                            com4card3,
                            com4card4,
                            com4card5
                        };
                        break;
                    default:
                        //pick better exception
                        throw new InvalidOperationException("none of the switch cases were hit with i: "+i);
                }
            }
        }

        public YanivGame Game { get; set; }
        public List<PictureBox> PlayersCards { get; set; }
        public List<PictureBox>[] comCards { get; set; }

        private void startButton_Click(object sender, EventArgs e)
        {
            //get a deck shuffled and ready to play
            Game.ResetDeck();
            Game.Deck.Shuffle();
            mainMessageLabel.Text = "Hello " + Game.Player.Name;
            pictureDeck.Image = Game.Deck.DeckBack.CardImage;

            //each com player and player is dealt 5 cards
            for (int i = 0; i < 5; i++)
            {
                //deal player a card and display player card on form
                Game.Deal(Game.Player.Hand);
                PlayersCards[i].Image = Game.Player.Hand[i].CardImage;

                //deal each com player a card
                int t = 0;
                foreach (var comPlayer in Game.comPlayers)
                {
                    //each card for each com player in game is given the deckBack image
                    //and the comPlayer is dealt a card with a Value
                    comCards[t].ElementAt(i).Image = Game.Deck.DeckBack.CardImage;
                    Game.Deal(comPlayer.Hand);
                    t++;
                }
            }
        }

        private void pictureDeck_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureDiscard_Click(object sender, EventArgs e)
        {

        }

        private void playerCard1_MouseHover(object sender, EventArgs e)
        {
            playerCard1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void playerCard1_MouseLeave(object sender, EventArgs e)
        {
            playerCard1.BorderStyle = BorderStyle.None;
        }
    }
}
