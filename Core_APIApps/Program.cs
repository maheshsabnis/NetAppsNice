// WebApplicatiobBuilder class is used to Host the app
// Manages Dependencies and Middlewares
using Core_APIApps.Middlewares;
using Core_APIApps.Models;
using Core_APIApps.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//<****************** Dependency Container Registration Starts Here ******************>

// 1. Register the DbContext in Di Container
builder.Services.AddDbContext<CompanyContext>(options => {
    // Regisater the Connection to SQL Server Database by reading connection string
    // from appSettings.json file
    options.UseSqlServer(builder.Configuration.GetConnectionString("AppConn"));
});

// Register the IdentityDbContext

builder.Services.AddDbContext<NiceAuthDbContext>(options => 
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("AppSecureConn"));
});



// Regiser the Identity classed in DI Container
// USerManager<IdentityUser>, RoleManager<IdentityRole>, SignInManager<IdentityUser>
builder.Services.AddIdentity<IdentityUser,IdentityRole>()
        .AddEntityFrameworkStores<NiceAuthDbContext>();

// 2. Register Custom Services

builder.Services.AddScoped<IService<Department,int>,DepartmentService>();

// register the Auth Infra Service
builder.Services.AddScoped<AuthenticationInfraService>();


// Lets Use the Authentication Service to Validate the Token
// REad the Secrey Key for Integrity Check
var secretKey = Convert.FromBase64String(builder.Configuration["JWTCoreSettings:SecretKey"]);

builder.Services.AddAuthentication(options => 
{
    // The HTTP Header MUST contain the {headers: {AUTHORIZATION: 'Bearer [TOKEN-VALUE]'}}
  options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    // MAke sure that the user is Logged in then only the Token base Authorization will takes place
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
    // Now Validate the Token
    .AddJwtBearer(validatationParameters => 
    {
        validatationParameters.SaveToken = true; // Will MAke sure tat token is save in Server's Memory
        validatationParameters.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
        {
            ValidateIssuerSigningKey = true, // VBalidation based on the Signeture
            IssuerSigningKey = new SymmetricSecurityKey(secretKey),
            ValidateIssuer = false,
            ValidateAudience = false
        };
    });
   


// The Request Processing for API Controllers only
// AddControllersWithViews(), for MVC and API COntrollers
builder.Services.AddControllers()
    .AddJsonOptions(options => 
    {
        // Asking the ASP.NET COre Runtime to Seralize JSON
        // based on original schema of entities
        options.JsonSerializerOptions.PropertyNamingPolicy = null;
    });


// Add the CORS Policy

builder.Services.AddCors(option => 
{
    option.AddPolicy("cors", policy =>
    {
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
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

// Apply the CORS Policy in Middleware

app.UseCors("cors");
app.UseStaticFiles();

app.UseAuthentication(); // User + Token
app.UseAuthorization(); // Token

// register the custom middleware

app.UseExceptionMiddleware();
// Map Incomming Request to the API Controller by Reading the URL and its Route Expression 
app.MapControllers();


//<**************************** Ends Here***************************>

//<**********************Start the Project running *******************************
app.Run();
