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
    public class DetailsModel : PageModel
    {
        private readonly CRUD_ASP_NET.Data.EmployeeContext _context;

        public DetailsModel(CRUD_ASP_NET.Data.EmployeeContext context)
        {
            _context = context;
        }

        public Employee Employee { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employee = await _context.Employee.FirstOrDefaultAsync(m => m.Id == id);

            if (Employee == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
