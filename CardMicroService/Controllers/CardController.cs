using CardCreator;
using CardCreator.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CardMicroService.Controllers
{
    public class CardController : Controller
    {
        private readonly ICardFactory _cardFactory;

        public CardController(ICardFactory cardFactory)
        {
            _cardFactory = cardFactory;
        }

        [HttpGet]
        [Route("/")]
        [ProducesResponseType(typeof(PlayingCard), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult<PlayingCard>> GetCard()
        {
            var card = await _cardFactory.CardPicker();

            if (card is not null)
                return Ok(card);
            
            return BadRequest();
        }
    }
}
