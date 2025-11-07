
using Microsoft.EntityFrameworkCore;
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

    public void Delete(int id)
    {
        _context.Users.Where(u=>u.Id==id).ExecuteDelete();
    }

    public User GetById(int id)
    {
        return _context.Users.Find(id);
    }

    public User GetUser(string username, string password)
    {
        return _context.Users.FirstOrDefault(u => u.UserName == username && u.Password == password);
    }

    public List<User> GetUsers()
    {
        return _context.Users.ToList();
    }

    public void Update(User user)
    {
        _context.Update(user);
        _context.SaveChanges();
    }
}


