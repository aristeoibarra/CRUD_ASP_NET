#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUD_ASP_NET.Data;
using CRUD_ASP_NET.Models;

namespace CRUD_ASP_NET.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly CRUD_ASP_NET.Data.EmployeeContext _context;

        public IndexModel(CRUD_ASP_NET.Data.EmployeeContext context)
        {
            _context = context;
        }

        public string test = "text of test";
        public IList<Employee> Employee { get;set; }

        public async Task OnGetAsync()
        {
            Employee = await _context.Employee.ToListAsync();
        }
    }
}
