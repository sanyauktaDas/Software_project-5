using DemoWebApplication1st_cls.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoWebApplication1st_cls.DBcontexts
{
    public class EmployeeDBcontext: DbContext
    {
      public EmployeeDBcontext(DbContextOptions<EmployeeDBcontext>options)
            :base(options)
        {



        }


      public DbSet<Employee>Employees { get; set; }
      public DbSet<Manager> Managers { get; set; }

    }
}
