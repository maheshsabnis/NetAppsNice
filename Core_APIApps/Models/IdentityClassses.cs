namespace Core_APIApps.Models
{
    public class RegisterUser
    {
        public string? Email { get; set;}
        public string? Password { get; set;}
        public string? ConfirmPasssword { get; set; }
    }

    public class LoginUser
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
    }

    public class IdentityResponse
    {
        public int StatusCode { get; set; }
        public string? Message { get; set; }
        public bool  IsSuccess { get; set; }
        public string? token { get; set; }
    }
}
