using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PatifoodApp.XmlModel
{
    public class Product
    {


        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class items
        {

            private itemsItem itemField;

            /// <remarks/>
            public itemsItem item
            {
                get
                {
                    return this.itemField;
                }
                set
                {
                    this.itemField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class itemsItem
        {

            private uint product_idField;

            private string modelField;

            private string locationField;

            private long quantityField;

            private byte stock_status_idField;

            private string videoField;

            private string imageField;

            private uint manufacturer_idField;

            private string yazar_idField;

            private string yayinevi_idField;

            private string cevirmen_idField;

            private string tur_idField;

            private byte shipping_freeField;

            private decimal shipping_priceField;

            private string shipping_dayField;

            private decimal priceField;

            private string price_codeField;

            private decimal receiving_priceField;

            private byte tax_class_idField;

            private string date_availableField;

            private decimal weightField;

            private decimal lengthField;

            private decimal widthField;

            private decimal heightField;

            private byte minimumField;

            private byte maximumField;

            private byte sort_orderField;

            private byte show_mainpageField;

            private string show_badgesField;

            private byte statusField;

            private byte index_statusField;

            private string date_in_stockField;

            private string date_addedField;

            private string date_modifiedField;

            private ushort viewedField;

            private string entegrasyon_codeField;

            private byte show_exportField;

            private byte customer_idField;

            private byte language_idField;

            private string nameField;

            private string titleField;

            private string small_descriptionField;

            private string descriptionField;

            private string delivery_infoField;

            private string meta_descriptionField;

            private string meta_keywordField;

            private string tagField;

            private string category_idField;

            private string category_idsField;

            private string category_namesField;

            private string special_customer_group_idField;

            private string special_priceField;

            /// <remarks/>
            public uint product_id
            {
                get
                {
                    return this.product_idField;
                }
                set
                {
                    this.product_idField = value;
                }
            }

            /// <remarks/>
            public string model
            {
                get
                {
                    return this.modelField;
                }
                set
                {
                    this.modelField = value;
                }
            }

            /// <remarks/>
            
            public string location
            {
                get
                {
                    return this.locationField;
                }
                set
                {
                    this.locationField = value;
                }
            }

            /// <remarks/>
            public long quantity
            {
                get
                {
                    return this.quantityField;
                }
                set
                {
                    this.quantityField = value;
                }
            }

            /// <remarks/>
            public byte stock_status_id
            {
                get
                {
                    return this.stock_status_idField;
                }
                set
                {
                    this.stock_status_idField = value;
                }
            }

            /// <remarks/>
            public string video
            {
                get
                {
                    return this.videoField;
                }
                set
                {
                    this.videoField = value;
                }
            }

            /// <remarks/>
            public string image
            {
                get
                {
                    return this.imageField;
                }
                set
                {
                    this.imageField = value;
                }
            }

            /// <remarks/>
            public uint manufacturer_id
            {
                get
                {
                    return this.manufacturer_idField;
                }
                set
                {
                    this.manufacturer_idField = value;
                }
            }

            /// <remarks/>
            public string yazar_id
            {
                get
                {
                    return this.yazar_idField;
                }
                set
                {
                    this.yazar_idField = value;
                }
            }

            /// <remarks/>
            public string yayinevi_id
            {
                get
                {
                    return this.yayinevi_idField;
                }
                set
                {
                    this.yayinevi_idField = value;
                }
            }

            /// <remarks/>
            public string cevirmen_id
            {
                get
                {
                    return this.cevirmen_idField;
                }
                set
                {
                    this.cevirmen_idField = value;
                }
            }

            /// <remarks/>
            public string tur_id
            {
                get
                {
                    return this.tur_idField;
                }
                set
                {
                    this.tur_idField = value;
                }
            }

            /// <remarks/>
            public byte shipping_free
            {
                get
                {
                    return this.shipping_freeField;
                }
                set
                {
                    this.shipping_freeField = value;
                }
            }

            /// <remarks/>
            public decimal shipping_price
            {
                get
                {
                    return this.shipping_priceField;
                }
                set
                {
                    this.shipping_priceField = value;
                }
            }

            /// <remarks/>
            public string shipping_day
            {
                get
                {
                    return this.shipping_dayField;
                }
                set
                {
                    this.shipping_dayField = value;
                }
            }

            /// <remarks/>
            public decimal price
            {
                get
                {
                    return this.priceField;
                }
                set
                {
                    this.priceField = value;
                }
            }

            /// <remarks/>
            public string price_code
            {
                get
                {
                    return this.price_codeField;
                }
                set
                {
                    this.price_codeField = value;
                }
            }

            /// <remarks/>
            public decimal receiving_price
            {
                get
                {
                    return this.receiving_priceField;
                }
                set
                {
                    this.receiving_priceField = value;
                }
            }

            /// <remarks/>
            public byte tax_class_id
            {
                get
                {
                    return this.tax_class_idField;
                }
                set
                {
                    this.tax_class_idField = value;
                }
            }

            /// <remarks/>
            public string date_available
            {
                get
                {
                    return this.date_availableField;
                }
                set
                {
                    this.date_availableField = value;
                }
            }

            /// <remarks/>
            public decimal weight
            {
                get
                {
                    return this.weightField;
                }
                set
                {
                    this.weightField = value;
                }
            }

            /// <remarks/>
            public decimal length
            {
                get
                {
                    return this.lengthField;
                }
                set
                {
                    this.lengthField = value;
                }
            }

            /// <remarks/>
            public decimal width
            {
                get
                {
                    return this.widthField;
                }
                set
                {
                    this.widthField = value;
                }
            }

            /// <remarks/>
            public decimal height
            {
                get
                {
                    return this.heightField;
                }
                set
                {
                    this.heightField = value;
                }
            }

            /// <remarks/>
            public byte minimum
            {
                get
                {
                    return this.minimumField;
                }
                set
                {
                    this.minimumField = value;
                }
            }

            /// <remarks/>
            public byte maximum
            {
                get
                {
                    return this.maximumField;
                }
                set
                {
                    this.maximumField = value;
                }
            }

            /// <remarks/>
            public byte sort_order
            {
                get
                {
                    return this.sort_orderField;
                }
                set
                {
                    this.sort_orderField = value;
                }
            }

            /// <remarks/>
            public byte show_mainpage
            {
                get
                {
                    return this.show_mainpageField;
                }
                set
                {
                    this.show_mainpageField = value;
                }
            }

            /// <remarks/>
            public string show_badges
            {
                get
                {
                    return this.show_badgesField;
                }
                set
                {
                    this.show_badgesField = value;
                }
            }

            /// <remarks/>
            public byte status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
            public byte index_status
            {
                get
                {
                    return this.index_statusField;
                }
                set
                {
                    this.index_statusField = value;
                }
            }

            /// <remarks/>
            public string date_in_stock
            {
                get
                {
                    return this.date_in_stockField;
                }
                set
                {
                    this.date_in_stockField = value;
                }
            }

            /// <remarks/>
            public string date_added
            {
                get
                {
                    return this.date_addedField;
                }
                set
                {
                    this.date_addedField = value;
                }
            }

            /// <remarks/>
            public string date_modified
            {
                get
                {
                    return this.date_modifiedField;
                }
                set
                {
                    this.date_modifiedField = value;
                }
            }

            /// <remarks/>
            public ushort viewed
            {
                get
                {
                    return this.viewedField;
                }
                set
                {
                    this.viewedField = value;
                }
            }

            /// <remarks/>
            public string entegrasyon_code
            {
                get
                {
                    return this.entegrasyon_codeField;
                }
                set
                {
                    this.entegrasyon_codeField = value;
                }
            }

            /// <remarks/>
            public byte show_export
            {
                get
                {
                    return this.show_exportField;
                }
                set
                {
                    this.show_exportField = value;
                }
            }

            /// <remarks/>
            public byte customer_id
            {
                get
                {
                    return this.customer_idField;
                }
                set
                {
                    this.customer_idField = value;
                }
            }

            /// <remarks/>
            public byte language_id
            {
                get
                {
                    return this.language_idField;
                }
                set
                {
                    this.language_idField = value;
                }
            }

            /// <remarks/>
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public string title
            {
                get
                {
                    return this.titleField;
                }
                set
                {
                    this.titleField = value;
                }
            }

            /// <remarks/>
            public string small_description
            {
                get
                {
                    return this.small_descriptionField;
                }
                set
                {
                    this.small_descriptionField = value;
                }
            }

            /// <remarks/>
            public string description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            public string delivery_info
            {
                get
                {
                    return this.delivery_infoField;
                }
                set
                {
                    this.delivery_infoField = value;
                }
            }

            /// <remarks/>
            public string meta_description
            {
                get
                {
                    return this.meta_descriptionField;
                }
                set
                {
                    this.meta_descriptionField = value;
                }
            }

            /// <remarks/>
            public string meta_keyword
            {
                get
                {
                    return this.meta_keywordField;
                }
                set
                {
                    this.meta_keywordField = value;
                }
            }

            /// <remarks/>
            public string tag
            {
                get
                {
                    return this.tagField;
                }
                set
                {
                    this.tagField = value;
                }
            }

            /// <remarks/>
            public string category_id
            {
                get
                {
                    return this.category_idField;
                }
                set
                {
                    this.category_idField = value;
                }
            }

            /// <remarks/>
            public string category_ids
            {
                get
                {
                    return this.category_idsField;
                }
                set
                {
                    this.category_idsField = value;
                }
            }

            /// <remarks/>
            public string category_names
            {
                get
                {
                    return this.category_namesField;
                }
                set
                {
                    this.category_namesField = value;
                }
            }

            /// <remarks/>
            public string special_customer_group_id
            {
                get
                {
                    return this.special_customer_group_idField;
                }
                set
                {
                    this.special_customer_group_idField = value;
                }
            }

            /// <remarks/>
            public string special_price
            {
                get
                {
                    return this.special_priceField;
                }
                set
                {
                    this.special_priceField = value;
                }
            }
        }




    }
}
