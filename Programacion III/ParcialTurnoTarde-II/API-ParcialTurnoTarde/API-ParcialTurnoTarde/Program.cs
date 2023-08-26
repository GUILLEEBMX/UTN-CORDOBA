using API_ParcialTurnoTarde.Business;
using API_ParcialTurnoTarde.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(typeof(BusinessDocenteGetAll.HandlerDocenteGetAll).Assembly);
builder.Services.AddMediatR(typeof(BusinessGetDocenteId.HandlerDocenteGetId).Assembly);
builder.Services.AddControllers().AddFluentValidation(cfg => cfg.RegisterValidatorsFromAssemblyContaining<BusinessDocentePut>());

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.AllowAnyHeader()
            .AllowAnyOrigin()
            .AllowAnyOrigin()
            .AllowAnyMethod();

        });
});


builder.Services.AddDbContext<prog3_docentesContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("ConnectionDatabase"));
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
