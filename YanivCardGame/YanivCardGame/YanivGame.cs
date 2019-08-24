using System.Collections.Generic;
using System;
using CardGames;
using System.Windows.Forms;
using System.Linq;

namespace YanivCardGame
{
    public class YanivGame
    {
         public YanivGame(Player player,int numComs,string gameDifficulty)
        {
            Player = player;
            Deck = new Deck();
            //makes sure yaniv game object is valid on construction
            if (gameDifficulty == "Easy" || gameDifficulty == "Medium" || gameDifficulty == "Difficult")
            {
                GameDifficulty = gameDifficulty;
            }
            else
            {
                throw new ArgumentException("Invalid difficulty");
            }
            comPlayers = new List<YanivComPlayer>();
            switch (numComs)
            {
                case 1:
                    comPlayers.Add(new YanivComPlayer());
                    break;
                case 2:
                    comPlayers.Add(new YanivComPlayer());
                    comPlayers.Add(new YanivComPlayer());
                    break;
                case 3:
                    comPlayers.Add(new YanivComPlayer());
                    comPlayers.Add(new YanivComPlayer());
                    comPlayers.Add(new YanivComPlayer());
                    break;
                case 4:
                    comPlayers.Add(new YanivComPlayer());
                    comPlayers.Add(new YanivComPlayer());
                    comPlayers.Add(new YanivComPlayer());
                    comPlayers.Add(new YanivComPlayer());
                    break;
                default:
                    comPlayers.Add(new YanivComPlayer());
                    //to know if default case was used
                    MessageBox.Show("used default switch case");
                    break;
            }

        }
        public Player Player { get; set; }
        public List<YanivComPlayer> comPlayers { get; set; }
        public string GameDifficulty { get; set; }
        public Deck Deck { get; set; }

        public void Deal(List<Card> hand)
        {
            //gives the hand passed to it a card from the deck (the first card) then removes that card from the deck
            hand.Add(Deck.Cards.First());
            Deck.Cards.RemoveAt(0);
        }

        public void ResetDeck()
        {
            Deck.Cards.Clear();
            Deck = new Deck();
        }
    }
}