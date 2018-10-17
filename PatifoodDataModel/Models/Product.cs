using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PatifoodDataModel.Models
{
    public class Product : DomainEntityBase
    {
        [Key]
        public Guid Id { get; set; }
        public int product_id { get; set; }
        
        public string model { get; set; }

        public string location { get; set; }

        public long quantity { get; set; }

        public byte stock_status_id { get; set; }

        public string video { get; set; }

        public string image { get; set; }

        public int manufacturer_id { get; set; }

        public string yazar_id { get; set; }

        public string yayinevi_id { get; set; }

        public string cevirmen_id { get; set; }

        public string tur_id { get; set; }

        public byte shipping_free { get; set; }

        public decimal shipping_price { get; set; }

        public string shipping_day { get; set; }

        public decimal price { get; set; }

        public string price_code { get; set; }

        public decimal receiving_price { get; set; }

        public byte tax_class_id { get; set; }

        public string date_available { get; set; }

        public decimal weight { get; set; }

        public decimal length { get; set; }

        public decimal width { get; set; }

        public decimal height { get; set; }

        public byte minimum { get; set; }

        public byte maximum { get; set; }

        public byte sort_order { get; set; }

        public byte show_mainpage { get; set; }

        public string show_badges { get; set; }

        public byte status { get; set; }

        public byte index_status { get; set; }

        public string date_in_stock { get; set; }

        public string date_added { get; set; }

        public string date_modified { get; set; }

        public ushort viewed { get; set; }

        public string entegrasyon_code { get; set; }

        public byte show_export { get; set; }

        public byte customer_id { get; set; }

        public byte language_id { get; set; }

        public string name { get; set; }

        public string title { get; set; }

        public string small_description { get; set; }

        public string description { get; set; }

        public string delivery_info { get; set; }

        public string meta_description { get; set; }

        public string meta_keyword { get; set; }

        public string tag { get; set; }

        public virtual Category category { get; set; }

        public virtual List<ProductCategory> Categorys { get; set; }
        
        public string category_names { get; set; }

        public string special_customer_group_id { get; set; }

        public string special_price { get; set; }



    }
}
