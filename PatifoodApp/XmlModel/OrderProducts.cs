using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatifoodApp.XmlModel
{
    public class OrderProducts
    {

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class items
        {

            private itemsItem[] itemField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("item")]
            public itemsItem[] item
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

            private int order_product_idField;

            private int order_idField;

            private int product_idField;

            private string customer_idField;

            private string nameField;

            private string modelField;

            private byte quantityField;

            private decimal priceField;

            private string price_codeField;

            private decimal totalField;

            private decimal taxField;

            private byte rewardField;

            private decimal receiving_priceField;

            private string option_nameField;

            private string option_codeField;

            private string tax_class_descriptionField;

            /// <remarks/>
            public int order_product_id
            {
                get
                {
                    return this.order_product_idField;
                }
                set
                {
                    this.order_product_idField = value;
                }
            }

            /// <remarks/>
            public int order_id
            {
                get
                {
                    return this.order_idField;
                }
                set
                {
                    this.order_idField = value;
                }
            }

            /// <remarks/>
            public int product_id
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
            public string customer_id
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
            public byte quantity
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
            public decimal total
            {
                get
                {
                    return this.totalField;
                }
                set
                {
                    this.totalField = value;
                }
            }

            /// <remarks/>
            public decimal tax
            {
                get
                {
                    return this.taxField;
                }
                set
                {
                    this.taxField = value;
                }
            }

            /// <remarks/>
            public byte reward
            {
                get
                {
                    return this.rewardField;
                }
                set
                {
                    this.rewardField = value;
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
            public string option_name
            {
                get
                {
                    return this.option_nameField;
                }
                set
                {
                    this.option_nameField = value;
                }
            }

            /// <remarks/>
            public string option_code
            {
                get
                {
                    return this.option_codeField;
                }
                set
                {
                    this.option_codeField = value;
                }
            }

            /// <remarks/>
            public string tax_class_description
            {
                get
                {
                    return this.tax_class_descriptionField;
                }
                set
                {
                    this.tax_class_descriptionField = value;
                }
            }
        }


    }
}
