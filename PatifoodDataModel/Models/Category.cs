using System;
using System.ComponentModel.DataAnnotations;

namespace PatifoodDataModel.Models
{
    public class Category : DomainEntityBase
    {
        [Key]
        public Guid Id { get; set; }

        public string category_id { get; set; }

        public string image { get; set; }

        public string icon { get; set; }

        public int parent_id { get; set; }

        public byte top { get; set; }

        public byte bottom { get; set; }

        public byte column { get; set; }

        public byte left { get; set; }

        public byte sort_order { get; set; }

        public byte status { get; set; }

        public string date_close { get; set; }

        public string date_added { get; set; }

        public string date_modified { get; set; }

        public string entegrasyon_code { get; set; }

        public string taksit_ayarlari { get; set; }

        public byte language_id { get; set; }

        public string name { get; set; }

        public string title { get; set; }

        public string description { get; set; }

        public string footer_description { get; set; }

        public string meta_description { get; set; }

        public string meta_keyword { get; set; }
    }
}
