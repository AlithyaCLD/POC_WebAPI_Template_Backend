using System;

namespace Services.Employee.Models
{
    public class Employee
    {
        public string EmployeeName { get; set; }
        public int EmployeeId { get; set; }

        public Employee() { }
        public Employee(string modelName, int modelId)
        {
            this.EmployeeName = modelName;
            this.EmployeeId = modelId;
        }
    }
}
