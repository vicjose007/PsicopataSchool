using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using NotasWorkshop.API.IoC;
using NotasWorkshop.Bl.IoC;
using NotasWorkshop.Core.IoC;
using NotasWorkshop.Model.Contexts.NotasWorkshop;
using NotasWorkshop.Model.IoC;
using NotasWorkshop.Services.IoC;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(options =>
{
	options.EnableEndpointRouting = false;
}).AddFluentValidation();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
string myAppDbContextConnection = app.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<NotasWorkshopDbContext>(op => op.UseSqlServer("Data Source=(localdb)\\ProjectsV13;Initial Catalog=Notes;Integrated Security=True"),
    ServiceLifetime.Transient);

/// injections
builder.Services.AddApiRegistry(app.Configuration);
builder.Services.AddServicesRegistry();
builder.Services.AddBlRegistry(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddModelRegistry();
builder.Services.AddCoreRegistry();
/// 

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
