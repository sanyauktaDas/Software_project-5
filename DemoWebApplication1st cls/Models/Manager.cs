namespace DemoWebApplication1st_cls.Models
{
    public class Manager
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
