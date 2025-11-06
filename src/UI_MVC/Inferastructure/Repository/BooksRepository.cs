
using Microsoft.EntityFrameworkCore;
using UI_MVC.Entitis;
using UI_MVC.Inferastructure;

public class BooksRepository : IBooksRepository
{
    private readonly ApplicationDbContext context;
    public BooksRepository()
    {
        context = new ApplicationDbContext();
    }
    public void Create(Book book)
    {
        context.Books.Add(book);
        context.SaveChanges();
    }
    public List<Book> GetBooks()
    {
        return context.Books.Include(b=>b.Category).ToList();
    }
}

