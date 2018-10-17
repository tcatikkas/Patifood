using System;
using System.ComponentModel.DataAnnotations;

namespace PatifoodDataModel.Models
{
    public class ProductConfig : DomainEntityBase
    {
        [Key]
        public Guid Id { get; set; }

        public string OptionCode { get; set; }

        public string OptionName { get; set; }

        public int Quantity { get; set; }
    }
}
