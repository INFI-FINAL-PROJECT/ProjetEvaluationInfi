using FetchApiSirene.BusinessLogic.Services;
using FetchApiSirene.DataAccess.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<EstablishmentsDbContext>(
    builder.Configuration.GetSection("EstablishmentsDbContext"));


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IEstablishmentInterface, EstablishmentsServices>();
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
