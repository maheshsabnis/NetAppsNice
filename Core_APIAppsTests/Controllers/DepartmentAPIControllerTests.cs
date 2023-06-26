using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core_APIApps.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Microsoft.AspNetCore.Hosting.Server;
using Core_APIApps.Services;
using Core_APIApps.Models;
using Microsoft.AspNetCore.Mvc;

namespace Core_APIApps.Controllers.Tests
{
    [TestClass()]
    public class DepartmentAPIControllerTests
    {
        [TestMethod()]
        public void GetTest()
        {
            // 1. Arrange: Organize all pre-requisites for running the test
            // 1.a. Mock for the Service class that implements IService<Department, int>
            var mock = new Mock<IService<Department, int>>();
            // 1.b. Create an instance of the DepartmentAPIController
            // the mock object is a Fake that will be created in-memory and it will have map to all
            // internal dependencies
            var controller = new DepartmentAPIController(mock.Object);
            int id = 10;

            // 2. Act: Actually call the code that is to be tested
            var result = controller.Get(id).Result;
            // 3. Assert: Verify result 
            // The result MUST be an instance of Department
            Assert.IsInstanceOfType(result, typeof(IActionResult));
        }
    }
}