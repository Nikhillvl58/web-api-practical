namespace Services;

public interface IUserService
{
    List<User> GetAdultUsers();
}

public class UserService : IUserService
{
    List<User> users = [new User { Id = 1, Name = "Alice", Age = 22 }, new User { Id = 2, Name = "Bob", Age = 17 }, new User { Id = 3, Name = "Charlie", Age = 30 }];
    public List<User> GetAdultUsers()
    {
        var filteredSortedUsers = users.Where(u => u.Age > 18).OrderBy(u => u.Name).ToList();
        return filteredSortedUsers;
    }
}

