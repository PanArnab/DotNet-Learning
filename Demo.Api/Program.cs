using Microsoft.EntityFrameworkCore; 
using Demo.Business;
using Demo.Repository;
using Demo.Repository.Data;

var builder = WebApplication.CreateBuilder(args);

// Connection string for SQL Server
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// EF Core DbContext
builder.Services.AddDbContext<DemoDbContext>(options =>
    options.UseSqlServer(connectionString, sqlOptions =>
    {
        sqlOptions.EnableRetryOnFailure(
            maxRetryCount: 5,
            maxRetryDelay: TimeSpan.FromSeconds(10),
            errorNumbersToAdd: null);
    }));

// Helpers
//builder.Services.AddScoped<SqlHelper>();

// Register your business and repository services here
builder.Services.AddScoped<IDemoManager, DemoManager>();
builder.Services.AddScoped<IDemoRepository, DemoRepository>();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.Run();






var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.Run();
