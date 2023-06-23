// WebApplicatiobBuilder class is used to Host the app
// Manages Dependencies and Middlewares
using Core_APIApps.Models;
using Core_APIApps.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//<****************** Dependency Container Registration Starts Here ******************>

// 1. Register the DbContext in Di Container
builder.Services.AddDbContext<CompanyContext>(options => {
    // Regisater the Connection to SQL Server Database by reading connection string
    // from appSettings.json file
    options.UseSqlServer(builder.Configuration.GetConnectionString("AppConn"));
});

// 2. Register Custom Services

builder.Services.AddScoped<IService<Department,int>,DepartmentService>();


// The Request Processing for API Controllers only
// AddControllersWithViews(), for MVC and API COntrollers
builder.Services.AddControllers()
    .AddJsonOptions(options => 
    {
        // Asking the ASP.NET COre Runtime to Seralize JSON
        // based on original schema of entities
        options.JsonSerializerOptions.PropertyNamingPolicy = null;
    });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//<****************** Dependency Container Registration Ends Here ******************>


//<************************* Middlewares starts here for HTTP Pipeline aka request Processing*********>
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
// Map Incomming Request to the API Controller by Reading the URL and its Route Expression 
app.MapControllers();

//<**************************** Ends Here***************************>

//<**********************Start the Project running *******************************
app.Run();
