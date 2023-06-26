using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace Core_APIApps.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileUploadController : ControllerBase
    {
        [HttpPost("file/upload")]
        public async Task<IActionResult> Upload([FromForm]IFormFile file)
        {
            try
            {
                // 1. Read the Folder Path where the file will be stored
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "Files");

                // 2. Check for the file Length if it is less than 0 throw exception

                if (file.Length <= 0)
                    throw new Exception("File is Empty");

                // 3. From the ContentDisposition get the FileName only

                var receivedFile = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');

                // 4. Set this received file for Copy to the folder path

                var copyPath = Path.Combine(folder, receivedFile);

                // 5. Create a new File and Copye the received file to this newly created file

                using (FileStream fs = new FileStream(copyPath, FileMode.Create))
                {
                    await file.CopyToAsync(fs);
                }

                return Ok("File is Uploaded Successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
