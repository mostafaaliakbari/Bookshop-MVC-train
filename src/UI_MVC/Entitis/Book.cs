using System.ComponentModel.DataAnnotations.Schema;

namespace UI_MVC.Entitis
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
        public int Price { get; set; }
        public string ImgAddress { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [NotMapped]
        public IFormFile? File { get; set; }
    }
}
