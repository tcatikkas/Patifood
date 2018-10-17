using PatifoodDataModel.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatifoodDataModel.Models
{
    public class DomainEntityBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DbDefaultValue("getDate()")]
        public DateTime? DateCreated { get; set; }

        public DateTime? LastUpdated { get; set; }
        
    }
}
