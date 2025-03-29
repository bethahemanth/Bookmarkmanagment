using Microsoft.AspNetCore.DataProtection.Repositories;
using Repository;
using Services;
using DataBase;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUser_Service,User_Service>();
builder.Services.AddScoped<IUser_Repository, User_Repository>();
builder.Services.AddScoped<IDatabaseContext, DatabaseContext>();
builder.Services.AddScoped<IBookmark_Service, Bookmark_Service>();
builder.Services.AddScoped<IBookmark_Repository,Bookmark_Repository>();
var app = builder.Build();

//Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
