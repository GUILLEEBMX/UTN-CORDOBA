using APIPeopleCodeFirst.Business.People;
using APIPeopleCodeFirst.Data;
using Microsoft.EntityFrameworkCore;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<Context>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("ConnectionDatabase"));
   
});

builder.Services.AddMediatR(typeof(PeopleBusiness.Manejador).Assembly);
builder.Services.AddMediatR(typeof(PeopleBusinessGetId.Manejador).Assembly);
builder.Services.AddMediatR(typeof(PeopleBusinessPost.Handler).Assembly);
builder.Services.AddMediatR(typeof(PeopleBusinessPut.HandlerPeoplePut).Assembly);


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


 //Microsoft.EntityFrameworkCore.Design.
