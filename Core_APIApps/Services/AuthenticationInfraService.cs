
using Core_APIApps.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

namespace Core_APIApps.Services
{
    /// <summary>
    /// class that is used to create indetity Info
    /// like Users and Roles
    /// </summary>
    public class AuthenticationInfraService
    {

        private UserManager<IdentityUser> _userManager;
        
        private SignInManager<IdentityUser> _signInManager;

        private IConfiguration _config;

        public AuthenticationInfraService(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager, IConfiguration config)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _config = config;

        }

        public async Task<IdentityResponse> RegisterUserAsync(RegisterUser user)
        {
            IdentityResponse response = new IdentityResponse();
            if (user == null) 
            {
                response.StatusCode = 500;
                response.Message = "The infromation is not valid";
                response.IsSuccess = false;
            }
            else
            {
                // Chekc if the user already exist
                if (await _userManager.FindByEmailAsync(user.Email) != null)
                {
                    response.StatusCode = 500;
                    response.Message = $"User {user.Email} already exist";
                    response.IsSuccess = false;
                }
                else 
                {
                    // Create user
                    IdentityUser newUser = new IdentityUser()
                    {
                        Email = user.Email,
                        UserName = user.Email
                    };

                    var result = await _userManager.CreateAsync(newUser, user.Password);

                    if (result.Succeeded)
                    {
                        response.StatusCode = 201;
                        response.Message = $"User {user.Email} created successfully";
                        response.IsSuccess = true;
                    }
                    else
                    {
                        response.StatusCode = 500;
                        response.Message = $"User {user.Email} creation failed";
                        response.IsSuccess = false;
                    }
                }
            }
            return response;
        }

        public async Task<IdentityResponse> AuthUserAsync(LoginUser user)
        { 
            IdentityResponse response = new IdentityResponse();

            if (user == null)
            {
                response.StatusCode = 500;
                response.Message = "Login The infromation is not valid";
                response.IsSuccess = false;
            }
            else
            {
                var result = await _signInManager.PasswordSignInAsync(user.Email, user.Password, false, true);
                if (result.Succeeded)
                {
                    response.StatusCode = 201;
                    response.Message = $"User {user.Email} logged in successfully";
                    response.IsSuccess = true;

                    #region Logic to Generate Token
                    // 1. Read the Secret Key and Expory from appSettings.json
                    var secretKey = Convert.FromBase64String(_config["JWTCoreSettings:SecretKey"]);
                    var expiry = Convert.ToInt32(_config["JWTCoreSettings:ExpiryInMinuts"]);

                    // 2. Define a Token Description using SecurtyTokenDescriptor
                    // Use SecreyKey, Expity, as well as Issuer and Audience

                    // 2.a. create an Instance of IdentityUser that will be used by the ASP.NET Core
                    // to validated the clims from the Token

                    IdentityUser identityUser = new IdentityUser()
                    { 
                         UserName = user.Email,
                         Email = user.Email
                    };

                    var tokenDescriptor = new SecurityTokenDescriptor()
                    {
                        Issuer = null,
                        Audience = null,
                        // 2.b. Lets define the Subject which is ClaimsIdentity that will be
                        // added into the 'Payload' of the Token
                        Subject = new System.Security.Claims.ClaimsIdentity(new List<Claim>()
                        {
                            new Claim("username", identityUser.UserName)
                        }),
                        Expires = DateTime.UtcNow.AddMinutes(expiry), // 2.c. Expiry
                        IssuedAt = DateTime.UtcNow, // 2.d. Issue Time
                        // 2.e. Signeture
                        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretKey), SecurityAlgorithms.HmacSha256)    
                    };

                    // 3. Generate this Token as JSOn Web Token
                    var jwtHandler = new JsonWebTokenHandler();
                    // 4. Get the JWT string
                    response.token  = jwtHandler.CreateToken(tokenDescriptor);
                    #endregion
                }
                else
                {
                    response.StatusCode = 401;
                    response.Message = $"User {user.Email} Login Failed";
                    response.IsSuccess = false;
                }
            }

            return response;
        }

    }
}
