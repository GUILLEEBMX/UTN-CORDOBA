using FirstProjectProgramacionIII.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddControllers().FluentValidation(x => x.RegisterValidatorsFromAssemblyCotaining<GetByIdBusiness>());


builder.Services.AddDbContext<Context>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("ConnectionDatabase"));
    //
});


//builder.services.AddMediatR(typeof(GetByIDBusiness.Manejador).Assembly);



//builder.Services.AddCors(options => {
//
//policy =>
//{
//policy.AllowHeader()
//      .AllowAnyMethod()        
//      .AllowAnyOrigin()  
//});
//
//
//
//});
var app = builder.Build();

AppContext.SetSwitch("Npgsql.EnableLegacyTimeStampBehavior", true);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(); //poner a mano

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
