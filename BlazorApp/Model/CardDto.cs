using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Model
{
    public class CardDto
    {
        public int CardId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public CardDto Clone()
        {
            return (CardDto)this.MemberwiseClone();
        }
    }
}
