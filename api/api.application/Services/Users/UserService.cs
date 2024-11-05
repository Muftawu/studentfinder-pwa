using api.domain;

namespace api.application;

public class UserService : IUserService
{  
    private readonly IDataRepository _dataRepository;

    public UserService(IDataRepository dataRepository)
    {
        _dataRepository = dataRepository;
    }
    
    // AllUsers
    public Task<List<User>> AllUsers()
    {
        return _dataRepository.AllUsers();
    }

    // CreateUser
    public Task CreateUser(User user)
    {
       return _dataRepository.CreateUser(user); 
    }

    // GetUserById
    public Task<User> GetUserById(int Id)
    {
        return _dataRepository.GetUserById(Id);
    }

    // GetUserByName
    public Task<List<User>> GetUserByName(string name)
    {
       return _dataRepository.GetUserByName(name); 
    }

    // delete user
     public Task DeleteUser(int Id)
    {
        return _dataRepository.DeleteUser(Id);
    }
}
