using CardGames;
using System;
using System.Collections.Generic;

namespace YanivCardGame
{

    public class Player : IPlayer
    {
        public Player(string name)
        {
            Name = name;
            PlayerId = Guid.NewGuid();
            Hand = new List<Card>();
        }

        public string Name { get; set; }
        public List<Card> Hand { get; set; }
        public bool IsActivelyPlaying { get; set; }
        public bool IsTurn { get; set; }
        public Guid PlayerId { get; set; }

        public void Draw()
        {

        }
    }
}