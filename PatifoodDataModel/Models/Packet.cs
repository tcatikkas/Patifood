using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PatifoodDataModel.Models
{
    public class Packet : DomainEntityBase
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string CargoName { get; set; }

        public DateTime? CargoShippingDate { get; set; }

        public DateTime? CargoDeliverygDate { get; set; }

        public int CargoStatus { get; set; }

        public virtual List<PacketOrderProduct> PacketOrderProducts { get; set; }

        public virtual List<PacketOrderProduct> UnPacketOrderProducts { get; set; }

        public bool IsTemp { get; set; }
    }
}
