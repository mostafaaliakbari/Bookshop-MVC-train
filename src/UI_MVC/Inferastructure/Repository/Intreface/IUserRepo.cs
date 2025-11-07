
public interface IUserRepo
{
    public User GetUser(string username, string password);
    public void Create(User user);
    public void Delete(int id);
    public void Update(User user );
    public List<User> GetUsers();
    public User GetById(int id);
}

