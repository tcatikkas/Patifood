using System;
using System.ComponentModel.DataAnnotations;

namespace PatifoodDataModel.Models
{
    public class PacketOrderProduct : DomainEntityBase
    {
        [Key]
        public Guid Id { get; set; }

        public virtual OrderProduct OrderProduct { get; set; }
    }
}
