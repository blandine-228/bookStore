using System.ComponentModel.DataAnnotations;

namespace DineBookStore.Models.Domain
{
    public class Book
    {
        public int Id { get; set; }
        [Required]

        public string Title { get; set; }
        [Required]

        public string Isbn { get; set; }
        [Required]
        public int TotalPages { get; set; }
        [Required]

        public int AurhorId { get; set; }
        [Required]

        public int PublisherId { get; set; }
        [Required]

        public int GenreId { get; set; }
    }
}
