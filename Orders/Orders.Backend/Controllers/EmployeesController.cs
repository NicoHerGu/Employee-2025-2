using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Orders.Backend.Data;
using Orders.Backend.UnitsOfWork.Interface;
using Orders.Share.Entities;

namespace Orders.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeesController : GenericController<Employee>
{
    private readonly DataContext _context;

    public EmployeesController(IGenericUnitOfWork<Employee> unitOfWork, DataContext context)
        : base(unitOfWork)
    {
        _context = context;
    }

    [HttpGet("search")]
    public async Task<ActionResult<IEnumerable<Employee>>> SearchEmployees([FromQuery] string query)
    {
        if (string.IsNullOrWhiteSpace(query))
        {
            return BadRequest("Debe enviar un parámetro de búsqueda.");
        }

        var employees = await _context.Employees
            .Where(e => e.FirstName.Contains(query) || e.LastName.Contains(query))
            .ToListAsync();

        return Ok(employees);
    }
}