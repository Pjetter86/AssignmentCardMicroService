using CardCreator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardCreator
{
    public class CardFactory : ICardFactory
    {

        public async Task<PlayingCard> CardPicker()
        {
            var deck = DeckCreator();

            var random = new Random();

            var index = random.Next(deck.Count);

            return deck[index];

        }

        private List<PlayingCard> DeckCreator()
        {
            var deck = new List<PlayingCard>();

            for (int i = 0; i < 3; i++)
                deck.Add(new PlayingCard() { IsJoker = true });

            var suits = new List<PlayingCardSuit>()
            {
                PlayingCardSuit.hearts, PlayingCardSuit.spades, PlayingCardSuit.clubs, PlayingCardSuit.diamonds
            };

            var pictureCards = new List<string>()
            {
                "Jack", "Queen", "King", "Ace"
            };

            foreach (var suit in suits)
            {
                for (int i = 2; i < 11; i++)
                {
                    var card = new PlayingCard() { PlayingCardSuit = suit, Value = i.ToString(), IsJoker = false };

                    deck.Add(card);
                }

                foreach (var pCard in pictureCards)
                {
                    var card = new PlayingCard() { PlayingCardSuit = suit, Value = pCard, IsJoker = false };

                    deck.Add(card);
                }
            }

            return deck;
        }
    }
}
