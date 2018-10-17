using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatifoodDataModel.Attributes
{
    [Serializable]
    [AttributeUsage(AttributeTargets.Property)]
    public class DbDefaultValue : Attribute
    {
        public string DefaultValue { get; set; }
        public DbDefaultValue(string defVal)
        {
            this.DefaultValue = defVal;
        }
    }
}
