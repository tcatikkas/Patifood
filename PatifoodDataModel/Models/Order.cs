using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PatifoodDataModel.Models
{
    public class Order : DomainEntityBase
    {
        [Key]
        public Guid Id { get; set; }
        public int order_id { get; set; }

        public virtual List<OrderProduct> OrderProducts { get; set; }
        public short customer_id { get; set; }

        public byte customer_group_id { get; set; }
       
        public string firstname { get; set; }

        public string lastname { get; set; }

        public string email { get; set; }

        public string telephone { get; set; }

        public string gsm { get; set; }

        public string fax { get; set; }

        public string payment_firstname { get; set; }

        public string payment_lastname { get; set; }

        public string payment_company { get; set; }

        public string payment_company_id { get; set; }

        public string payment_tax_id { get; set; }

        public string payment_address_1 { get; set; }

        public string payment_address_2 { get; set; }

        public string payment_city { get; set; }

        public string payment_gsm { get; set; }

        public string payment_postcode { get; set; }

        public string payment_country { get; set; }

        public byte payment_country_id { get; set; }

        public string payment_zone { get; set; }

        public short payment_zone_id { get; set; }

        public string payment_address_format { get; set; }

        public string payment_method { get; set; }

        public string payment_bank { get; set; }

        public byte payment_installment { get; set; }

        public string payment_code { get; set; }

        public byte bank_transfer_discount { get; set; }

        public string shipping_firstname { get; set; }

        public string shipping_lastname { get; set; }

        public string shipping_company { get; set; }

        public string shipping_address_1 { get; set; }

        public string shipping_address_2 { get; set; }

        public string shipping_city { get; set; }

        public string shipping_gsm { get; set; }

        public string shipping_postcode { get; set; }

        public string shipping_country { get; set; }

        public byte shipping_country_id { get; set; }

        public string shipping_zone { get; set; }

        public short shipping_zone_id { get; set; }

        public string shipping_address_format { get; set; }

        public string shipping_method { get; set; }

        public string comment { get; set; }

        public decimal total { get; set; }

        public byte order_status_id { get; set; }

        public byte currency_id { get; set; }

        public string currency_code { get; set; }

        public decimal currency_value { get; set; }

        public string forwarded_ip { get; set; }

        public string date_added { get; set; }

        public string date_modified { get; set; }

        public byte is_viewed { get; set; }

        public string customer { get; set; }

        public decimal shipping_price { get; set; }

        public decimal payment_fee { get; set; }

        public bool payment_feeFieldSpecified;

        public decimal genel_toplam { get; set; }
    }
}
