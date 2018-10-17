using System;
using System.ComponentModel.DataAnnotations;

namespace PatifoodDataModel.Models
{
    public class OrderProduct : DomainEntityBase
    {
        [Key]
        public Guid Id { get; set; }
        public int order_product_id { get; set; }
        public string BirimName { get; set; }
        public int? Birim { get; set; }
        public virtual Order order { get; set; }

        public Product product { get; set; }

        public string customer_id { get; set; }

        public string name { get; set; }

        public string model { get; set; }

        public byte quantity { get; set; }

        public decimal price { get; set; }

        public string price_code { get; set; }

        public decimal total { get; set; }

        public decimal tax { get; set; }

        public byte reward { get; set; }

        public decimal receiving_price { get; set; }

        public string option_name { get; set; }

        public string option_code { get; set; }

        public string tax_class_description { get; set; }
    }
}
