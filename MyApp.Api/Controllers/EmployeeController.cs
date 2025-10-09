using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApp.Application.Commands;
using MyApp.Application.Queries;
using MyApp.Core.Entities;

namespace MyApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController(ISender sender) : ControllerBase
    {
        [HttpPost("")]
        public async Task<IActionResult> AddEmpoyeeAsync([FromBody] EmployeeEntity employee)
        {
            var result = await sender.Send(new AddEmployeeCommand(employee));
            return Ok(result);
        }

        [HttpGet("employees")]
        public async Task<IActionResult> GetAllEmpoyeesAsync()
        {
            var result = await sender.Send(new GetAllEmployeeQuery());
            return Ok(result);
        }

        [HttpGet("employees/{empoyeeId}")]
        public async Task<IActionResult> GetEmpoyeeByIdAsync([FromRoute] Guid employeeId)
        {
            var result = await sender.Send(new GetEmployeeByIdQuery(employeeId));
            return Ok(result);
        }
    }
}
