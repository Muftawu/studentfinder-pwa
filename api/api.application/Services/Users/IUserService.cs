using api.domain;

namespace api.application;

public interface IUserService
{
    Task<List<User>> AllUsers();
    Task CreateUser(User user);
    Task<User?> GetUserById(int Id);
    Task<List<User>> GetUserByName(string name);
    Task DeleteUser(int Id);
}
