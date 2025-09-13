using Orders.Share.Entities;

namespace Orders.Backend.Data;

public class SeedDb
{
    private readonly DataContext _context;

    public SeedDb(DataContext context)
    {
        _context = context;
    }

    public async Task SeedAsync()
    {
        await _context.Database.EnsureCreatedAsync();
        await CheckEmployeesAsync();
    }

    private async Task CheckEmployeesAsync()
    {
        if (!_context.Employees.Any())
        {
            _context.Employees.Add(new Employee
            {
                FirstName = "Jorge",
                LastName = "Pérez",
                IsActive = true,
                HireDate = DateTime.UtcNow.AddYears(-2),
                Salary = 1500000
            });

            _context.Employees.Add(new Employee
            {
                FirstName = "Ana Julia",
                LastName = "Ramírez",
                IsActive = true,
                HireDate = DateTime.UtcNow.AddYears(-1),
                Salary = 2000000
            });

            _context.Employees.Add(new Employee
            {
                FirstName = "Julian",
                LastName = "Juarez",
                IsActive = false,
                HireDate = DateTime.UtcNow.AddMonths(-6),
                Salary = 1800000
            });

            _context.Employees.Add(new Employee
            {
                FirstName = "Mateo",
                LastName = "Ortega",
                IsActive = true,
                HireDate = DateTime.UtcNow.AddYears(-2),
                Salary = 1950000
            });

            _context.Employees.Add(new Employee
            {
                FirstName = "Valentina",
                LastName = "Moreno",
                IsActive = true,
                HireDate = DateTime.UtcNow.AddMonths(-14),
                Salary = 2200000
            });

            _context.Employees.Add(new Employee
            {
                FirstName = "Sebastián",
                LastName = "Córdoba",
                IsActive = false,
                HireDate = DateTime.UtcNow.AddYears(-3),
                Salary = 1750000
            });

            _context.Employees.Add(new Employee
            {
                FirstName = "Paula",
                LastName = "Fernández",
                IsActive = true,
                HireDate = DateTime.UtcNow.AddMonths(-9),
                Salary = 2400000
            });

            _context.Employees.Add(new Employee
            {
                FirstName = "Ricardo",
                LastName = "Salazar",
                IsActive = true,
                HireDate = DateTime.UtcNow.AddYears(-4),
                Salary = 2100000
            });

            _context.Employees.Add(new Employee
            {
                FirstName = "Isabella",
                LastName = "Martínez",
                IsActive = true,
                HireDate = DateTime.UtcNow.AddMonths(-7),
                Salary = 2300000
            });

            _context.Employees.Add(new Employee
            {
                FirstName = "Tomás",
                LastName = "Rojas",
                IsActive = false,
                HireDate = DateTime.UtcNow.AddYears(-1),
                Salary = 1850000
            });

            _context.Employees.Add(new Employee
            {
                FirstName = "Gabriela",
                LastName = "Vargas",
                IsActive = true,
                HireDate = DateTime.UtcNow.AddMonths(-3),
                Salary = 2500000
            });

            await _context.SaveChangesAsync();
        }
    }
}