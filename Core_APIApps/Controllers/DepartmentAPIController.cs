using Core_APIApps.Models;
using Core_APIApps.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core_APIApps.Controllers
{
    // Route: Used to Map the URL with the Controller base on the Template Expression
    // [controller]: The PlaceHolder that represents the Controller class name
    // in our case it is DepartmentAPI, the word 'Controller' will be skipped
    // by ASP.NET Core Request processing
    //https://localhost:[PORT]/api/DepartmentAPI
    //action: Name of the action to be included in URL
    [Route("api/[controller]/[action]")]
    /// ApiController: Class that reads JSON data from HTTP Request Body for HTTP POST and PUT request and Map that data to CLR Object (aka Entity classs object) 
    [ApiController]
    public class DepartmentAPIController : ControllerBase
    {
        private IService<Department, int> deptServ;

        // The Construct Injection
        public DepartmentAPIController(IService<Department, int> deptServ)
        {
            this.deptServ = deptServ; 
        }
        /// <summary>
        /// The Attribute that represents the Http Method
        /// Map the request to the correspomding Http Action Method
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get() 
        {
            var response = await deptServ.GetAsync();
            return Ok(response);
        }

        /// <summary>
        /// HTTP Get request with URL Containg value for 'id'
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var response = await deptServ.GetAsync(id);
            return Ok(response);
        }
        /// <summary>
        /// https://localhost:7299/api/DepartmentAPI/Mahesh/Sabnis
        /// </summary>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <returns></returns>
        [HttpGet("{fname}/{lname}")]
        [ActionName("search")]
        public IActionResult Get(string fname, string lname)
        {
            return Ok($"{fname} {lname}");
        }

        [HttpPost]
        public async Task<IActionResult> Post(Department dept)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (dept.Capacity < 0) throw new Exception("Invalid value for Capacity");
                    var response = await deptServ.CreateAsync(dept);
                    return Ok(response);
                }
                return BadRequest(ModelState);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Department dept)
        {
            var response = await deptServ.UpdateAsync(id,dept);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await deptServ.DeleteAsync(id);
            return Ok(response);
        }
    }
}
