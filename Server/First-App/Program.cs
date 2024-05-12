using First_App.Common.Profiles;
using Fisrt_App.BLL.Services;
using Fisrt_App.BLL.Services.Interfaces;
using Fisrt_App.DAL;
using Fisrt_App.DAL.Repository;
using Fisrt_App.DAL.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddAutoMapper(typeof(CardProfile));

//Repositories
builder.Services.AddScoped<ICardRepository,CardRepository>();
builder.Services.AddScoped<IListBoardRepository, ListBoardRepository>();
builder.Services.AddScoped<IBoardRepository, BoardRepository>();


//Services
builder.Services.AddScoped<ICardService, CardService>();
builder.Services.AddScoped<IListBoardService, ListBoardService>();
builder.Services.AddScoped<IBoardService, BoardService>();


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy => policy.AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod());
});

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
