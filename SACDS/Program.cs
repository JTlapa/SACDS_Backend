using Microsoft.EntityFrameworkCore;
using SACDS.Modelo.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Configuraci�n de Kestrel para especificar puertos en producci�n
builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(5002); // Puerto �nico para esta aplicaci�n
});



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext <SADCDSDbContext> (option =>
    option.UseSqlServer(builder.Configuration.GetConnectionString("SADC")));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


var app = builder.Build();

// Configure the HTTP request pipeline.
    app.UseSwagger();
    app.UseSwaggerUI();




app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
