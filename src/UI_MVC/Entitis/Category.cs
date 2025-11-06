
using UI_MVC.Entitis;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    //public string? ImgAddress { get; set; }
    public List<Book> Books { get; set; } = new List<Book>();
}

