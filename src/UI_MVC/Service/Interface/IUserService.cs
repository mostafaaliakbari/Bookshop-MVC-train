
public interface IUserService
{
    public User Login(string username, string password);
    public void Create(User user);
}

