
using UI_MVC.Entitis;

public interface IBooksRepository
{
    public List<Book> GetBooks();
    public void Create(Book book);
}

