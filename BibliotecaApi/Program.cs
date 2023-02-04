using BibliotecaApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<BibliotecaDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Server=CAMILOROCK\\SQLEXPRESS;Database=Biblioteca_DB;Trusted_Connection=True;Encrypt=False;")));


builder.Services.AddCors(options =>
{
    options.AddPolicy("permitir",
        builder =>
        {
            builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
        });
});




// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


app.UseCors("permitir");
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


