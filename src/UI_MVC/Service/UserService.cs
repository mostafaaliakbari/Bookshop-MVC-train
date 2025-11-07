

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

    public void Delete(int id)
    {
        userRepo.Delete(id);
    }

    public User GetById(int id)
    {
        return userRepo.GetById(id);
    }

    public List<User> GetUsers()
    {
        return userRepo.GetUsers();
    }

    public User Login(string username, string password)
    {
       
        return userRepo.GetUser(username, password);
    }

    public void Update(User user)
    {
        var Orginal = userRepo.GetById(user.Id);
        if (Orginal == null) {
            return;
        }

        Orginal.Name = user.Name;
        Orginal.UserName = user.UserName;
        Orginal.Role = user.Role;

        if (user.Password != null)
        {
         
            Orginal.Password = user.Password;
       
        }
        userRepo.Update(Orginal);
    }

    
}

