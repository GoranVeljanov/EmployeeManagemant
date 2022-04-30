using Microsoft.EntityFrameworkCore;

namespace EmployeeManagemant.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                  new Employee
                  {
                      Id = 1,
                      Name = "Mary",
                      Email = "Mary@mail.com",
                      Department = Dept.IT
                  },
                  new Employee
                  {
                      Id = 2,
                      Name = "John",
                      Email = "John@mail.com",
                      Department = Dept.HR
                  }

        );
        }
    }
}
