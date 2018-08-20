using System;
using System.Collections.Generic;

namespace Services.Employee
{
    public class EmployeeService
    {
        private List<Models.Employee> list;
        public EmployeeService()
        {
            build();
        }
        public Models.Employee Get(int id)
        {
            if (id == 10)
            {
                string nullStr = null;
                nullStr.ToString();
            }
            if (id > 5)
            {
                throw new KeyNotFoundException();
            }
            var model = new Models.Employee();
            model.EmployeeName = "This is a template model";
            model.EmployeeId = id;

            return model;
        }
        public List<DateTime> GetAvailablePeriods()
        {
            List<DateTime> availablePeriods = new List<DateTime>();
            availablePeriods.Add(new DateTime(2018, 8, 1));
            availablePeriods.Add(new DateTime(2018, 7, 1));
            availablePeriods.Add(new DateTime(2018, 6, 1));
            availablePeriods.Add(new DateTime(2018, 5, 1));

            return availablePeriods;
        }
        public List<Models.Employee> Get()
        {
            return list;
        }
        private void build()
        {
            list = new List<Models.Employee> ();
            for (int i = 0; i < 5; i++)
            {
                list.Add(new Models.Employee("name " + i, i));
            }
        }
    }
}
