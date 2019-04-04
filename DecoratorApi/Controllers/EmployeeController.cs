using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DecoratorApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DecoratorApi.Controllers
{
    [Route("api/Employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IRequestHandler<EmployeeRequest, EmployeeReponse> requestHandler;
        public EmployeeController(IRequestHandler<EmployeeRequest, EmployeeReponse> requestHandler)
        {
            this.requestHandler = requestHandler;
        }

        public IActionResult GetEmployee(EmployeeRequest request)
        {
           return Ok(this.requestHandler.Handle(request));
        }
  
    }
}