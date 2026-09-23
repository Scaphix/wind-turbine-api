using Microsoft.EntityFrameworkCore;
using WindTurbineAPI.Data;
var builder = WebApplication.CreateBuilder(args);

//Add Database Context with SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=windturbines.db"));

var app = builder.Build();



app.Run();