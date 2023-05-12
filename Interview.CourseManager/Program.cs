using Interview.CourseManager.efCoreCode;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Interview.CourseManager.Services.Interfaces;
using Interview.CourseManager.Controllers;
using Interview.CourseManager.Services.Implementations;

var builder = WebApplication.CreateBuilder(args);
var _corsPolicy = "CORSPOLICY";
#region AddConnectionString
var _connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
#endregion
#region AddContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
         options.UseSqlServer(_connectionString));
#endregion


// Add services to the container.



builder.Services.AddControllers();
builder.Services.AddTransient<ICourseService, CourseService>();
builder.Services.AddTransient<IStuduimService, StuduimService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy(_corsPolicy, op => op.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(_corsPolicy);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
