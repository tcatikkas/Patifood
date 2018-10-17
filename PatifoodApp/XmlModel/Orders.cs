using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatifoodApp.XmlModel
{
    public class Orders
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

            private ushort order_idField;

            private ushort customer_idField;

            private byte customer_group_idField;

            private string firstnameField;

            private string lastnameField;

            private string emailField;

            private string telephoneField;

            private string gsmField;

            private object faxField;

            private string payment_firstnameField;

            private string payment_lastnameField;

            private object payment_companyField;

            private string payment_company_idField;

            private string payment_tax_idField;

            private string payment_address_1Field;

            private object payment_address_2Field;

            private string payment_cityField;

            private string payment_gsmField;

            private string payment_postcodeField;

            private string payment_countryField;

            private byte payment_country_idField;

            private string payment_zoneField;

            private ushort payment_zone_idField;

            private string payment_address_formatField;

            private string payment_methodField;

            private string payment_bankField;

            private byte payment_installmentField;

            private string payment_codeField;

            private byte bank_transfer_discountField;

            private string shipping_firstnameField;

            private string shipping_lastnameField;

            private object shipping_companyField;

            private string shipping_address_1Field;

            private object shipping_address_2Field;

            private string shipping_cityField;

            private string shipping_gsmField;

            private string shipping_postcodeField;

            private string shipping_countryField;

            private byte shipping_country_idField;

            private string shipping_zoneField;

            private ushort shipping_zone_idField;

            private string shipping_address_formatField;

            private string shipping_methodField;

            private string commentField;

            private decimal totalField;

            private byte order_status_idField;

            private byte currency_idField;

            private string currency_codeField;

            private decimal currency_valueField;

            private object forwarded_ipField;

            private string date_addedField;

            private string date_modifiedField;

            private byte is_viewedField;

            private string customerField;

            private decimal shipping_priceField;

            private decimal payment_feeField;

            private bool payment_feeFieldSpecified;

            private decimal genel_toplamField;

            /// <remarks/>
            public ushort order_id
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
            public ushort customer_id
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
            public byte customer_group_id
            {
                get
                {
                    return this.customer_group_idField;
                }
                set
                {
                    this.customer_group_idField = value;
                }
            }

            /// <remarks/>
            public string firstname
            {
                get
                {
                    return this.firstnameField;
                }
                set
                {
                    this.firstnameField = value;
                }
            }

            /// <remarks/>
            public string lastname
            {
                get
                {
                    return this.lastnameField;
                }
                set
                {
                    this.lastnameField = value;
                }
            }

            /// <remarks/>
            public string email
            {
                get
                {
                    return this.emailField;
                }
                set
                {
                    this.emailField = value;
                }
            }

            /// <remarks/>
            public string telephone
            {
                get
                {
                    return this.telephoneField;
                }
                set
                {
                    this.telephoneField = value;
                }
            }

            /// <remarks/>
            public string gsm
            {
                get
                {
                    return this.gsmField;
                }
                set
                {
                    this.gsmField = value;
                }
            }

            /// <remarks/>
            public object fax
            {
                get
                {
                    return this.faxField;
                }
                set
                {
                    this.faxField = value;
                }
            }

            /// <remarks/>
            public string payment_firstname
            {
                get
                {
                    return this.payment_firstnameField;
                }
                set
                {
                    this.payment_firstnameField = value;
                }
            }

            /// <remarks/>
            public string payment_lastname
            {
                get
                {
                    return this.payment_lastnameField;
                }
                set
                {
                    this.payment_lastnameField = value;
                }
            }

            /// <remarks/>
            public object payment_company
            {
                get
                {
                    return this.payment_companyField;
                }
                set
                {
                    this.payment_companyField = value;
                }
            }

            /// <remarks/>
            public string payment_company_id
            {
                get
                {
                    return this.payment_company_idField;
                }
                set
                {
                    this.payment_company_idField = value;
                }
            }

            /// <remarks/>
            public string payment_tax_id
            {
                get
                {
                    return this.payment_tax_idField;
                }
                set
                {
                    this.payment_tax_idField = value;
                }
            }

            /// <remarks/>
            public string payment_address_1
            {
                get
                {
                    return this.payment_address_1Field;
                }
                set
                {
                    this.payment_address_1Field = value;
                }
            }

            /// <remarks/>
            public object payment_address_2
            {
                get
                {
                    return this.payment_address_2Field;
                }
                set
                {
                    this.payment_address_2Field = value;
                }
            }

            /// <remarks/>
            public string payment_city
            {
                get
                {
                    return this.payment_cityField;
                }
                set
                {
                    this.payment_cityField = value;
                }
            }

            /// <remarks/>
            public string payment_gsm
            {
                get
                {
                    return this.payment_gsmField;
                }
                set
                {
                    this.payment_gsmField = value;
                }
            }

            /// <remarks/>
            public string payment_postcode
            {
                get
                {
                    return this.payment_postcodeField;
                }
                set
                {
                    this.payment_postcodeField = value;
                }
            }

            /// <remarks/>
            public string payment_country
            {
                get
                {
                    return this.payment_countryField;
                }
                set
                {
                    this.payment_countryField = value;
                }
            }

            /// <remarks/>
            public byte payment_country_id
            {
                get
                {
                    return this.payment_country_idField;
                }
                set
                {
                    this.payment_country_idField = value;
                }
            }

            /// <remarks/>
            public string payment_zone
            {
                get
                {
                    return this.payment_zoneField;
                }
                set
                {
                    this.payment_zoneField = value;
                }
            }

            /// <remarks/>
            public ushort payment_zone_id
            {
                get
                {
                    return this.payment_zone_idField;
                }
                set
                {
                    this.payment_zone_idField = value;
                }
            }

            /// <remarks/>
            public string payment_address_format
            {
                get
                {
                    return this.payment_address_formatField;
                }
                set
                {
                    this.payment_address_formatField = value;
                }
            }

            /// <remarks/>
            public string payment_method
            {
                get
                {
                    return this.payment_methodField;
                }
                set
                {
                    this.payment_methodField = value;
                }
            }

            /// <remarks/>
            public string payment_bank
            {
                get
                {
                    return this.payment_bankField;
                }
                set
                {
                    this.payment_bankField = value;
                }
            }

            /// <remarks/>
            public byte payment_installment
            {
                get
                {
                    return this.payment_installmentField;
                }
                set
                {
                    this.payment_installmentField = value;
                }
            }

            /// <remarks/>
            public string payment_code
            {
                get
                {
                    return this.payment_codeField;
                }
                set
                {
                    this.payment_codeField = value;
                }
            }

            /// <remarks/>
            public byte bank_transfer_discount
            {
                get
                {
                    return this.bank_transfer_discountField;
                }
                set
                {
                    this.bank_transfer_discountField = value;
                }
            }

            /// <remarks/>
            public string shipping_firstname
            {
                get
                {
                    return this.shipping_firstnameField;
                }
                set
                {
                    this.shipping_firstnameField = value;
                }
            }

            /// <remarks/>
            public string shipping_lastname
            {
                get
                {
                    return this.shipping_lastnameField;
                }
                set
                {
                    this.shipping_lastnameField = value;
                }
            }

            /// <remarks/>
            public object shipping_company
            {
                get
                {
                    return this.shipping_companyField;
                }
                set
                {
                    this.shipping_companyField = value;
                }
            }

            /// <remarks/>
            public string shipping_address_1
            {
                get
                {
                    return this.shipping_address_1Field;
                }
                set
                {
                    this.shipping_address_1Field = value;
                }
            }

            /// <remarks/>
            public object shipping_address_2
            {
                get
                {
                    return this.shipping_address_2Field;
                }
                set
                {
                    this.shipping_address_2Field = value;
                }
            }

            /// <remarks/>
            public string shipping_city
            {
                get
                {
                    return this.shipping_cityField;
                }
                set
                {
                    this.shipping_cityField = value;
                }
            }

            /// <remarks/>
            public string shipping_gsm
            {
                get
                {
                    return this.shipping_gsmField;
                }
                set
                {
                    this.shipping_gsmField = value;
                }
            }

            /// <remarks/>
            public string shipping_postcode
            {
                get
                {
                    return this.shipping_postcodeField;
                }
                set
                {
                    this.shipping_postcodeField = value;
                }
            }

            /// <remarks/>
            public string shipping_country
            {
                get
                {
                    return this.shipping_countryField;
                }
                set
                {
                    this.shipping_countryField = value;
                }
            }

            /// <remarks/>
            public byte shipping_country_id
            {
                get
                {
                    return this.shipping_country_idField;
                }
                set
                {
                    this.shipping_country_idField = value;
                }
            }

            /// <remarks/>
            public string shipping_zone
            {
                get
                {
                    return this.shipping_zoneField;
                }
                set
                {
                    this.shipping_zoneField = value;
                }
            }

            /// <remarks/>
            public ushort shipping_zone_id
            {
                get
                {
                    return this.shipping_zone_idField;
                }
                set
                {
                    this.shipping_zone_idField = value;
                }
            }

            /// <remarks/>
            public string shipping_address_format
            {
                get
                {
                    return this.shipping_address_formatField;
                }
                set
                {
                    this.shipping_address_formatField = value;
                }
            }

            /// <remarks/>
            public string shipping_method
            {
                get
                {
                    return this.shipping_methodField;
                }
                set
                {
                    this.shipping_methodField = value;
                }
            }

            /// <remarks/>
            public string comment
            {
                get
                {
                    return this.commentField;
                }
                set
                {
                    this.commentField = value;
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
            public byte order_status_id
            {
                get
                {
                    return this.order_status_idField;
                }
                set
                {
                    this.order_status_idField = value;
                }
            }

            /// <remarks/>
            public byte currency_id
            {
                get
                {
                    return this.currency_idField;
                }
                set
                {
                    this.currency_idField = value;
                }
            }

            /// <remarks/>
            public string currency_code
            {
                get
                {
                    return this.currency_codeField;
                }
                set
                {
                    this.currency_codeField = value;
                }
            }

            /// <remarks/>
            public decimal currency_value
            {
                get
                {
                    return this.currency_valueField;
                }
                set
                {
                    this.currency_valueField = value;
                }
            }

            /// <remarks/>
            public object forwarded_ip
            {
                get
                {
                    return this.forwarded_ipField;
                }
                set
                {
                    this.forwarded_ipField = value;
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
            public byte is_viewed
            {
                get
                {
                    return this.is_viewedField;
                }
                set
                {
                    this.is_viewedField = value;
                }
            }

            /// <remarks/>
            public string customer
            {
                get
                {
                    return this.customerField;
                }
                set
                {
                    this.customerField = value;
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
            public decimal payment_fee
            {
                get
                {
                    return this.payment_feeField;
                }
                set
                {
                    this.payment_feeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool payment_feeSpecified
            {
                get
                {
                    return this.payment_feeFieldSpecified;
                }
                set
                {
                    this.payment_feeFieldSpecified = value;
                }
            }

            /// <remarks/>
            public decimal genel_toplam
            {
                get
                {
                    return this.genel_toplamField;
                }
                set
                {
                    this.genel_toplamField = value;
                }
            }
        }
    }

}
