using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShoppingCartMvcUI.Models
{
    [Table("Book")]
    public class Book
    {
        public int Id { get; set; }

        
       
        public string? BookName { get; set; }

        
        public string? AuthorName { get; set; }
        public double Price { get; set; }
        public string? Image { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public string ImageUrl { get; set; }
        public List<OrderDetail> OrderDetail { get; set; }
        public List<CartDetail> CartDetail { get; set; }

        [NotMapped]
        public string GenreName { get; set; }
        

    }
}
