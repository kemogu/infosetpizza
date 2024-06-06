using Microsoft.EntityFrameworkCore;
using infoset.data.Abstract;
using infoset.data.Concrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("SQLiteConnection");

// dbContext
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite(connectionString));

// repositories
builder.Services.AddScoped<IRestaurantBranchesRepository, RestaurantBranchesRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();