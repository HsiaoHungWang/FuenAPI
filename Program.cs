using FuenAPI.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

//加入這段設定，就可以在Controller的建構函式注入此物件
builder.Services.AddDbContext<NorthwindContext>(
    //NorthwindConnectoin 是記錄在 appsettings.json 中的連線字串名稱
    option => option.UseSqlServer(builder.Configuration.GetConnectionString("NorthwindConnection"))
    );


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
