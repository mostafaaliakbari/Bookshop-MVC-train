
public class UserService : IUserService
{
    private readonly IUserRepo userRepo;

    public UserService()
    {
        userRepo = new UserRepo();
    }

    public void Create(User user)
    {
       userRepo.Create(user);
    }

    public User Login(string username, string password)
    {
       
        return userRepo.GetUser(username, password);
    }


}

