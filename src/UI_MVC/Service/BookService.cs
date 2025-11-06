
using UI_MVC.Entitis;

public class BookService : IBookService
{
    private readonly IBooksRepository _booksRepository;
    private readonly IFileService _fileService;

    public BookService()
    {
        _booksRepository = new BooksRepository();
        _fileService = new FileService();
      ;
    }
    public void Create(Book book)
    {
        book.ImgAddress = _fileService.Upload(book.File);
        _booksRepository.Create(book);
    }

    public List<Book> GetBooks()
    {
        return _booksRepository.GetBooks();
    }
}

