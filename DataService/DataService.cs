using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataService.Models;

namespace DataService
{
    public class DataService
    {
        private List<TemplateModel> list;
        public DataService()
        {
            build();
        }
        public TemplateModel Get(int id)
        {
            if (id>5)
            {
                throw new KeyNotFoundException();
            }
            var model = new TemplateModel();
            model.ModelName = "This is a template model";
            model.ModelId = id;

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
        public List<TemplateModel> Get()
        {
            return list;
        }
        private void build()
        {
            list = new List<TemplateModel>();
            for (int i = 0; i < 5; i++)
            {
                list.Add(new TemplateModel("name " + i, i));
            }
        }
    }
}
