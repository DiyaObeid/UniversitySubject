using Microsoft.EntityFrameworkCore;
using UniversitySubject.Core.IRepositories;
using UniversitySubject.Infrastructure.DBConection;
using UniversitySubject.Services.Contract;
using UniversitySubject.Services.Implemintation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


builder.Services.AddDbContext<ApplicationDBContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("LocalDb")));
builder.Services.AddScoped<ISubjectsServices, SubjectsServices>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(GenericRepo<>));



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
