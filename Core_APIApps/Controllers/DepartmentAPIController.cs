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
    [Route("api/[controller]")]
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

        [HttpPost]
        public async Task<IActionResult> Post(Department dept)
        {
            var response = await deptServ.CreateAsync(dept);
            return Ok(response);
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
