using api.domain;

namespace api.application;

public interface IDataRepository
{
   Task<List<User>> AllUsers();

   Task CreateUser(User user);

   Task<User?> GetUserById(string Id);

   Task<List<User>> GetUserByName(string name);

   Task DeleteUser(string Id);
}
