using System.ComponentModel.DataAnnotations;

namespace CRUD_ASP_NET.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
    }
}
