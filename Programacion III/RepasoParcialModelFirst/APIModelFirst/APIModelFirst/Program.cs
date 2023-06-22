using APIModelFirst.Business;
using APIModelFirst.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(typeof(PeopleBusinessGetAll.HandlerPeopleGetAll).Assembly);
builder.Services.AddMediatR(typeof(PeopleBusinessGetId.HandlerPeopleGetId).Assembly);
builder.Services.AddMediatR(typeof(PeopleBusinessPost.PeoplePostHandler).Assembly);
builder.Services.AddMediatR(typeof(PeopleBusinessPut.HandlerPeoplePut).Assembly);


builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.AllowAnyHeader()
            .AllowAnyOrigin()
            .AllowAnyOrigin();

        });
});

builder.Services.AddDbContext<Clase6Context>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();



