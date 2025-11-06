
using UI_MVC.Inferastructure;

public class UserRepo : IUserRepo
{
    private readonly ApplicationDbContext _context;
    public UserRepo()
    {
        _context = new ApplicationDbContext();
    }

    public void Create(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
    }

    public User GetUser(string username, string password)
    {
        return _context.Users.FirstOrDefault(u => u.UserName == username && u.Password == password);
    }
}


