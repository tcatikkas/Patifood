using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatifoodDataModel.Attributes
{
    [Serializable]
    [AttributeUsage(AttributeTargets.Class)]
    public class TableWithDefaultValue : Attribute
    {
        public string TableName { get; set; }
        public TableWithDefaultValue(string tableName)
        {
            this.TableName = tableName;
        }
    }
}
