using BLL.Functions;
using BLL.Interfaces;
using DAL.Functions;
using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddControllers().AddJsonOptions(o => o.JsonSerializerOptions.PropertyNamingPolicy = null);
builder.Services.AddCors(opotion => opotion.AddPolicy("AllowAll",
                p => p.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()));
// Add services to the container.


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
try
{
    builder.Services.AddDbContext<RecipesContext>(option => option.UseSqlServer("Data Source=.;Initial Catalog=Recipes;Integrated Security=True"));
    builder.Services.AddScoped(typeof(IRecipeDal), typeof(RecipeDal));
    builder.Services.AddScoped(typeof(IIngDal), typeof(IngDal));
    builder.Services.AddScoped(typeof(IUserDal), typeof(UserDal));
    builder.Services.AddScoped(typeof(IIngToRecipeDal), typeof(IngToRecipeDal));
    builder.Services.AddScoped(typeof(IRecipeBll), typeof(RecipeBll));
    builder.Services.AddScoped(typeof(IIngBll), typeof(IngBll));
    builder.Services.AddScoped(typeof(IUserBll), typeof(UserBll));
    builder.Services.AddScoped(typeof(IIngToRecipeBll), typeof(IngToRecipeBll));
}
catch (Exception ex) { }
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowAll");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
