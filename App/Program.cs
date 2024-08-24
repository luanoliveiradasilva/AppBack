using Microsoft.EntityFrameworkCore;
using App.Controllers.Repository;
using App.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<LoginDbContext>(opt =>
    opt.UseMySql(builder.Configuration.GetConnectionString("Login"),
        new MySqlServerVersion(new Version(8, 0, 26))));

builder.Services.AddControllers();

builder.Services.AddScoped<ILoginRepository, LoginRepository>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
