using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatifoodApp.XmlModel
{
    public class Categorys
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

            private string category_idField;

            private string imageField;

            private string iconField;

            private int parent_idField;

            private byte topField;

            private byte bottomField;

            private byte columnField;

            private byte leftField;

            private byte sort_orderField;

            private byte statusField;

            private string date_closeField;

            private string date_addedField;

            private string date_modifiedField;

            private string entegrasyon_codeField;

            private string taksit_ayarlariField;

            private byte language_idField;

            private string nameField;

            private string titleField;

            private string descriptionField;

            private string footer_descriptionField;

            private string meta_descriptionField;

            private string meta_keywordField;

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
            public string icon
            {
                get
                {
                    return this.iconField;
                }
                set
                {
                    this.iconField = value;
                }
            }

            /// <remarks/>
            public int parent_id
            {
                get
                {
                    return this.parent_idField;
                }
                set
                {
                    this.parent_idField = value;
                }
            }

            /// <remarks/>
            public byte top
            {
                get
                {
                    return this.topField;
                }
                set
                {
                    this.topField = value;
                }
            }

            /// <remarks/>
            public byte bottom
            {
                get
                {
                    return this.bottomField;
                }
                set
                {
                    this.bottomField = value;
                }
            }

            /// <remarks/>
            public byte column
            {
                get
                {
                    return this.columnField;
                }
                set
                {
                    this.columnField = value;
                }
            }

            /// <remarks/>
            public byte left
            {
                get
                {
                    return this.leftField;
                }
                set
                {
                    this.leftField = value;
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
            public string date_close
            {
                get
                {
                    return this.date_closeField;
                }
                set
                {
                    this.date_closeField = value;
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
            public string taksit_ayarlari
            {
                get
                {
                    return this.taksit_ayarlariField;
                }
                set
                {
                    this.taksit_ayarlariField = value;
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
            public string footer_description
            {
                get
                {
                    return this.footer_descriptionField;
                }
                set
                {
                    this.footer_descriptionField = value;
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
        }


    }
}
