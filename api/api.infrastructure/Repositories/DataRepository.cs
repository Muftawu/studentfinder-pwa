using api.domain;
using api.application;
using Microsoft.EntityFrameworkCore;

namespace api.infrastructure;

public class DataRepository : IDataRepository
{
    private readonly UserDbContext _userDbContext;

    public DataRepository(UserDbContext userDbContext)
    {
        _userDbContext = userDbContext;
    }
    
    // all users 
    public async Task<List<User>> AllUsers()
    {
        return await _userDbContext.Users.ToListAsync();
    }

    // create user
    public async Task CreateUser(User user)
    {
      await _userDbContext.Users.AddAsync(user);
      await _userDbContext.SaveChangesAsync();
    }

    // get user by id
     public async Task<User?> GetUserById (string Id)
     {
        return await _userDbContext.Users.FirstOrDefaultAsync(user => user.UserId == Id);
     }

     //get user by name
     public async Task<List<User>> GetUserByName (string name)
     {
        return await _userDbContext.Users.Where(user => user.FirstName.Contains(name) || user.LastName.Contains(name)).ToListAsync();
     }

     // delete user
     public async Task DeleteUser (string Id)
     {
        var user = await  _userDbContext.Users.FirstOrDefaultAsync(user => user.UserId == Id);
        if (user is null) return;
        _userDbContext.Users.Remove(user);
        await _userDbContext.SaveChangesAsync();
     }
}
