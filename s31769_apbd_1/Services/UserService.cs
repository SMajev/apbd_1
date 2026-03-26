namespace DefaultNamespace;

public class UserService
{
    private static UserService _instance = new UserService();
    private static List<User> users;

    private UserService()
    {
        
    }

    public static UserService getInstance()
    {
        if (_instance == null)
        {
            _instance = new UserService();
        }
        return _instance;
    }


    public void addUser(User user)
    {
        users.Add(user);
    }
    
    
    
}