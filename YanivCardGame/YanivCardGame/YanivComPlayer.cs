using System;
using System.Collections.Generic;
using CardGames;

namespace YanivCardGame
{
    public class YanivComPlayer
    {
        public YanivComPlayer()
        {
            Hand = new List<Card>();
        }
        public List<Card> Hand { get; set; }
    }
}