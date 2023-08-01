using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

/*
Note: when adding services it does not matter where we put it as long as it comes before "var app = builder.Build().

We are getting the thing from the DataContext class and passing it through as "opt".
*/
builder.Services.AddDbContext<DataContext>(opt => 
{
    /*
        We are passing a connection string.
        Then we are giving it a name "DefaultConnection 
    */
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipline

app.MapControllers();

app.Run();
