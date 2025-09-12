using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Orders.Backend.Data;
using Orders.Share.Entities;
using System.Threading.Tasks;

namespace Orders.Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeesController : ControllerBase
{
    private readonly DataContext _context;

    public EmployeesController(DataContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync(Employee employee)
    {
        _context.Employees.Add(employee);
        _context.SaveChanges();
        await _context.SaveChangesAsync();
        return Ok(employee);
    }

    [HttpGet]
    public async Task<IActionResult> GetAsync()
    {
        return Ok(await _context.Employees.ToListAsync());
    }
}