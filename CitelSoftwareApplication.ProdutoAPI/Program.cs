using CitelSoftwareApplication.ProdutoAPI.Model.Domain;
using CitelSoftwareApplication.ProdutoAPI.Repository;
using CitelSoftwareApplication.ProdutoAPI.Repository.Context;
using CitelSoftwareApplication.ProdutoAPI.Repository.Interface;
using CitelSoftwareApplication.ProdutoAPI.Service;
using CitelSoftwareApplication.ProdutoAPI.Service.Interface;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connection = builder.Configuration["MySQlConnection:MySQlConnectionString"];
// Add services to the container.
builder.Services.AddDbContext<MySQLContext>(options => options.
                UseMySql(connection,
                        new MySqlServerVersion(
                            new Version(8, 0, 5))));

builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped<IProdutoService, ProdutoService>();

builder.Services.AddControllers();
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

using (var scope = app.Services.CreateScope())
{
    var mySqlContext = scope.ServiceProvider.GetService<MySQLContext>();

    mySqlContext.Database.Migrate();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
