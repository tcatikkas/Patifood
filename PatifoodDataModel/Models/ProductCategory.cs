using System;
using System.ComponentModel.DataAnnotations;

namespace PatifoodDataModel.Models
{
    public class ProductCategory : DomainEntityBase
    {
        [Key]
        public Guid Id { get; set; }

        public virtual Category Category { get; set; }
        public virtual Product Product { get; set; }
    }
}
