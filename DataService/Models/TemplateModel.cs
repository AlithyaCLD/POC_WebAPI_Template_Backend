using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Models
{
    public class TemplateModel
    {
        public string ModelName { get; set; }
        public int ModelId { get; set; }

        public TemplateModel() { }
        public TemplateModel(string modelName, int modelId)
        {
            this.ModelName = modelName;
            this.ModelId = modelId;
        }
    }
}
