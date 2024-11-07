using api.presentation;
using api.infrastructure;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddPersistentServices(builder.Configuration);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactApp", policy =>
    {
        policy.WithOrigins("http://localhost:3000", "https://localhost:5001", "https://Muftawu.github.io")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();
app.UseCors("AllowReactApp");

var user_group = app.MapGroup("api"); 
user_group.MapUserEndpoints();
 
app.Run();
