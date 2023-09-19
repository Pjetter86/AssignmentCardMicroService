using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardCreator.Models
{
    public class PlayingCard
    {
        public PlayingCardSuit? PlayingCardSuit { get; set; }
        public string Value { get; set; }
        public bool IsJoker { get; set; }

    }

    public enum PlayingCardSuit 
    {
        hearts,
        clubs,
        spades,
        diamonds
    }
}
