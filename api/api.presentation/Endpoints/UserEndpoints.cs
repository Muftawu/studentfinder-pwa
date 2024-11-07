using api.application;
using api.domain;

namespace api.presentation;

public static class UserEndpoints
{
    const string GetUserById = "GetUserById";
    const string GetUserByName = "GetUserByName";

    public static RouteGroupBuilder MapUserEndpoints(this RouteGroupBuilder group)
    {
        group.MapGet("/users/by-id/{Id}", async (IUserService _userService, string Id) =>
        {
            var user = await _userService.GetUserById(Id);
            if (user is null) return Results.NotFound($"User with {Id} not found");
            return Results.Ok(user);
        }).WithName(GetUserById);

        group.MapGet("/users/by-name/{name}", async (IUserService _userService, string name) =>
        {
            if (string.IsNullOrEmpty(name)) return Results.BadRequest("Invalid input name");
            var user = await _userService.GetUserByName(name);
            if (user is null) return Results.NotFound($"No user with name {name} found");
            return Results.Ok(user);
        }).WithName(GetUserByName);

        group.MapGet("/users", async (IUserService _userService) =>
        {
            var users = await _userService.AllUsers();
            if (!users.Any()) return Results.NotFound("No results found");
            return Results.Ok(users);
        });

        group.MapPost("/users", async (IUserService _userService, User user) =>
        {
            user.Email = Utilities.GenerateEmail(user.FirstName, user.LastName);            
            await _userService.CreateUser(user);
            return Results.CreatedAtRoute(GetUserById, new { Id = user.Id }, user);
        });

        group.MapDelete("/users/{Id}", async (IUserService _userService, string Id) =>
        {
            await _userService.DeleteUser(Id);
            return Results.NoContent();
        });

        return group;
    }
}
