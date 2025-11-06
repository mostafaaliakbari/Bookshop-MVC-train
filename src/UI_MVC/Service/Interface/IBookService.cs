
using UI_MVC.Entitis;

public interface IBookService
{
    public List<Book> GetBooks();
    public void Create(Book book);
}

