using CardCreator.Models;

namespace CardCreator
{
    public interface ICardFactory
    {
        Task<PlayingCard> CardPicker();
    }
}