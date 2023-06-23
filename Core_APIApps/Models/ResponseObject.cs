
namespace Core_APIApps.Models
{
    public class ResponseObject<TEntity> where TEntity : class
    {
        // Porperty to Respond Collection of Data
        public IEnumerable<TEntity>? Records { get; set; }
        // Property to have a Single Record 
        public TEntity? Record { get; set; }
        // Status Message
        public string? StatusMessage { get; set; }
        // Status Code
        public int StatusCode { get; set; }
    }
}
