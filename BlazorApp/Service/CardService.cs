using BlazorApp.Model;

namespace BlazorApp.Service
{
    public class CardService
    {
        private List<CardDto> _cards = new List<CardDto>
            {
                new CardDto { CardId = 1, Title = "Card 1", Description = "Description 1" },
                new CardDto { CardId = 2, Title = "Card 2", Description = "Description 2" },
                new CardDto { CardId = 3, Title = "Card 3", Description = "Description 3" },
            };

        public IEnumerable<CardDto> GetCards()
        {
            return _cards;
        }

        public CardDto GetCard(int id)
        {
            var card = _cards.FirstOrDefault(c => c.CardId == id) ?? new CardDto();
            return card.Clone();
        }

        public void AddCard(CardDto card)
        {
            card.CardId = _cards.Max(c => c.CardId) + 1;
            _cards.Add(card);
        }

        public void UpdateCard(CardDto card)
        {
            var existingCard = _cards.FirstOrDefault(c => c.CardId == card.CardId);
            if (existingCard != null)
            {
                existingCard.Title = card.Title;
                existingCard.Description = card.Description;
            }
        }
    }
}
