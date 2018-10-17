using PatifoodApp.XmlModel;
using PatifoodDataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Linq;
using PatifoodDataModel.Models;

namespace PatifoodApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logTxt.Text = "StartDate: " + dateTimePicker1.Value + " EndDate: " + dateTimePicker2.Value;

            logTxt.AppendText("\r\ngetOrders");
            var param = new Dictionary<string, string>();

            param.Add("act", "getOrders");
            param.Add("start_date", String.Format("{0:yyyy-MM-dd}", dateTimePicker1.Value));
            param.Add("end_date", String.Format("{0:yyyy-MM-dd}", dateTimePicker2.Value));

            var pageContent = HttpPostRequest(param);


            XmlSerializer serializer = new XmlSerializer(typeof(Orders.items));
            StringReader rdr = new StringReader(pageContent);
            Orders.items orders = (Orders.items)serializer.Deserialize(rdr);

            progressBar1.Maximum = orders.item.Count();

           // bool hataVar = false;

            var say = 0;
            



            foreach (var orderItem in orders.item)
            {
                var context = new PatifoodDataContext();
                var newOrder = false;

                logTxt.AppendText("\r\n");
                logTxt.AppendText("OrderId:" + orderItem.order_id + " Name" + orderItem.firstname + " " + orderItem.lastname);
                say++;
                progressBar1.Value = say;
                lblStatus.Text = say + "/" + progressBar1.Maximum;

                var order = context.Orders.Where(c => c.order_id == orderItem.order_id).FirstOrDefault();

                if (order != null)
                    continue;
                else
                {
                    order = Form1.newOrder(orderItem);

                    newOrder = true;
                }
                //if (say == 94)
                //    MessageBox.Show("");

                //if (orderItem.order_status_id != 1 && orderItem.order_status_id != 12)
                //    continue;

                param = new Dictionary<string, string>();

                logTxt.AppendText("\r\n");
                logTxt.AppendText("getOrderProducts");

                param.Add("act", "getOrderProducts");
                param.Add("order_id", orderItem.order_id.ToString());

                pageContent = HttpPostRequest(param);

                serializer = new XmlSerializer(typeof(OrderProducts.items));
                rdr = new StringReader(pageContent);
                OrderProducts.items orderProducts = (OrderProducts.items)serializer.Deserialize(rdr);

                foreach (var orderProduct in orderProducts.item)
                {
                    logTxt.AppendText("\r\n");
                    logTxt.AppendText("OrderProductId:" + orderProduct.order_product_id + " Name" + orderProduct.name);

                    var orderProductContext = context.OrderProducts.FirstOrDefault(c=> c.order_product_id == orderProduct.order_product_id);

                    if (orderProductContext == null)
                    {
                        orderProductContext = new OrderProduct();

                        orderProductContext.Id = Guid.NewGuid();
                        orderProductContext.customer_id = orderProduct.customer_id;
                        orderProductContext.model = orderProduct.model;
                        orderProductContext.name = orderProduct.name;
                        orderProductContext.option_code = orderProduct.option_code;
                        orderProductContext.option_name = orderProduct.option_name;
                        orderProductContext.order = order;
                        orderProductContext.order_product_id = orderProduct.order_product_id;
                        orderProductContext.price = orderProduct.price;
                        orderProductContext.price_code = orderProduct.price_code;
                        orderProductContext.quantity = orderProduct.quantity;
                        orderProductContext.receiving_price = orderProduct.receiving_price;
                        orderProductContext.reward = orderProduct.reward;
                        orderProductContext.tax = orderProduct.tax;
                        orderProductContext.tax_class_description = orderProduct.tax_class_description;
                        orderProductContext.total = orderProduct.total;
                    }


                    logTxt.AppendText("\r\n");
                    logTxt.AppendText("getOrderProducts");

                    param = new Dictionary<string, string>();

                    param.Add("act", "getProduct");
                    param.Add("product_id", orderProduct.product_id.ToString());

                    pageContent = HttpPostRequest(param);

                    serializer = new XmlSerializer(typeof(XmlModel.Product.items));
                    rdr = new StringReader(pageContent);
                    XmlModel.Product.items product = (XmlModel.Product.items)serializer.Deserialize(rdr);

                    var productContext = context.Products.Where(c => c.product_id == product.item.product_id).FirstOrDefault();

                    //if (productContext != null)
                    //    order.Products.Add(productContext);
                    //else
                    {
                        productContext = new PatifoodDataModel.Models.Product();

                        productContext.Id = Guid.NewGuid();
                        productContext.category_names = product.item.category_names;
                        productContext.cevirmen_id = product.item.cevirmen_id;
                        productContext.customer_id = product.item.customer_id;
                        productContext.date_added = product.item.date_added;
                        productContext.date_available = product.item.date_available;
                        productContext.date_in_stock = product.item.date_in_stock;
                        productContext.date_modified = product.item.date_modified;
                        productContext.delivery_info = product.item.delivery_info;
                        productContext.description = product.item.description;
                        productContext.entegrasyon_code = product.item.entegrasyon_code;
                        productContext.height = product.item.height;
                        productContext.image = product.item.image;
                        productContext.index_status = product.item.index_status;
                        productContext.language_id = product.item.language_id;
                        productContext.length = product.item.length;
                        productContext.location = product.item.location;
                        productContext.manufacturer_id = int.Parse(product.item.manufacturer_id.ToString());
                        productContext.maximum = product.item.maximum;
                        productContext.meta_description = product.item.meta_description;
                        productContext.meta_keyword = product.item.meta_keyword;
                        productContext.minimum = product.item.minimum;
                        productContext.model = product.item.model;
                        productContext.name = product.item.name;
                        productContext.price = product.item.price;
                        productContext.price_code = product.item.price_code;
                        productContext.product_id = int.Parse(product.item.product_id.ToString());
                        productContext.quantity = product.item.quantity;
                        productContext.receiving_price = product.item.receiving_price;
                        productContext.shipping_day = product.item.shipping_day;
                        productContext.shipping_free = product.item.shipping_free;
                        productContext.shipping_price = product.item.shipping_price;
                        productContext.show_badges = product.item.show_badges;
                        productContext.show_export = product.item.show_export;
                        productContext.show_mainpage = product.item.show_mainpage;
                        productContext.small_description = product.item.small_description;
                        productContext.sort_order = product.item.sort_order;
                        productContext.special_customer_group_id = product.item.special_customer_group_id;
                        productContext.special_price = product.item.special_price;
                        productContext.status = product.item.status;
                        productContext.stock_status_id = product.item.stock_status_id;
                        productContext.tag = product.item.tag;
                        productContext.tax_class_id = product.item.tax_class_id;
                        productContext.title = product.item.title;
                        productContext.tur_id = product.item.tur_id;
                        productContext.video = product.item.video;
                        productContext.viewed = product.item.viewed;
                        productContext.weight = product.item.weight;
                        productContext.width = product.item.width;
                        productContext.yayinevi_id = product.item.yayinevi_id;
                        productContext.yazar_id = product.item.yazar_id;
                    }

                    var categoryIds = !string.IsNullOrEmpty(product.item.category_ids) ? product.item.category_ids.Split(';').ToList() : new List<string>() ;

                    productContext.Categorys = new List<ProductCategory>();

                    foreach (var categoryId in categoryIds)
                    {


                        var category = context.Categorys.FirstOrDefault(c => c.category_id == categoryId);

                        if (category == null)
                        {
                            param = new Dictionary<string, string>();

                            param.Add("act", "getCategory");
                            param.Add("category_id", categoryId);

                            pageContent = HttpPostRequest(param);

                            serializer = new XmlSerializer(typeof(Categorys.items));
                            rdr = new StringReader(pageContent);
                            Categorys.items categorys = (Categorys.items)serializer.Deserialize(rdr);

                            category = new Category();

                            category.Id = Guid.NewGuid();
                            category.bottom = categorys.item.First().bottom;
                            category.category_id = categorys.item.First().category_id;
                            category.column = categorys.item.First().column;
                            category.date_added = categorys.item.First().date_added;
                            category.date_close = categorys.item.First().date_close;
                            category.date_modified = categorys.item.First().date_modified;
                            category.description = categorys.item.First().description;
                            category.entegrasyon_code = categorys.item.First().entegrasyon_code;
                            category.footer_description = categorys.item.First().footer_description;
                            category.icon = categorys.item.First().icon;
                            category.image = categorys.item.First().image;
                            category.language_id = categorys.item.First().language_id;
                            category.left = categorys.item.First().left;
                            category.meta_description = categorys.item.First().meta_description;
                            category.meta_keyword = categorys.item.First().meta_keyword;
                            category.name = categorys.item.First().name;
                            category.parent_id = categorys.item.First().parent_id;
                            category.sort_order = categorys.item.First().sort_order;
                            category.status = categorys.item.First().status;
                            category.taksit_ayarlari = categorys.item.First().taksit_ayarlari;
                            category.title = categorys.item.First().title;
                            category.top = categorys.item.First().top;

                            context.Categorys.Add(category);
                        }

                        var productCategory = new ProductCategory();

                        productCategory.Id = Guid.NewGuid();
                        productCategory.Category = category;
                        productCategory.Product = productContext;

                        productContext.Categorys.Add(productCategory);

                        if (product.item.category_id == categoryId)
                            productContext.category = category;
                    }

                    int? birim = null;

                    var name = string.Empty;

                    if (string.IsNullOrEmpty(orderProductContext.option_name))
                        name = orderProductContext.name;
                    else
                        name = orderProductContext.option_name;

                    if (name.ToLower().Contains("adet"))
                    {
                        birim = getAdet(name);
                        orderProductContext.BirimName = "Adet";
                    }
                    else
                    {
                        birim = getKg(name);
                        orderProductContext.BirimName = "Kg";
                    }

                    orderProductContext.Birim = birim;

                    orderProductContext.product = productContext;
                    order.OrderProducts = new List<OrderProduct>();
                    order.OrderProducts.Add(orderProductContext);
                }

                if(newOrder)
                    context.Orders.Add(order);

                context.SaveChanges();
            }

            

        }

        private static Order newOrder(Orders.itemsItem orderItem)
        {
            Order order = new Order();
            order.Id = Guid.NewGuid();
            order.bank_transfer_discount = orderItem.bank_transfer_discount;
            order.comment = orderItem.comment;
            order.currency_code = orderItem.currency_code;
            order.currency_id = orderItem.currency_id;
            order.currency_value = orderItem.currency_value;
            order.customer = orderItem.customer;
            order.customer_group_id = orderItem.customer_group_id;
            order.customer_id = short.Parse(orderItem.customer_id.ToString());
            order.date_added = orderItem.date_added;
            order.date_modified = orderItem.date_modified;
            order.email = orderItem.email;
            order.fax = orderItem.fax != null ? orderItem.fax.ToString() : null;
            order.firstname = orderItem.firstname;
            order.forwarded_ip = orderItem.forwarded_ip != null ? orderItem.forwarded_ip.ToString() : null;
            order.genel_toplam = orderItem.genel_toplam;
            order.gsm = orderItem.gsm;
            order.is_viewed = orderItem.is_viewed;
            order.lastname = orderItem.lastname;
            order.order_id = orderItem.order_id;
            order.order_status_id = orderItem.order_status_id;
            order.payment_address_1 = orderItem.payment_address_1;
            order.payment_address_2 = orderItem.payment_address_2 != null ? orderItem.payment_address_2.ToString() : null;
            order.payment_address_format = orderItem.payment_address_format;
            order.payment_bank = orderItem.payment_bank;
            order.payment_city = orderItem.payment_city;
            order.payment_code = orderItem.payment_code;
            order.payment_company = orderItem.payment_company != null ? orderItem.payment_company.ToString() : null;
            order.payment_company_id = orderItem.payment_company_id;
            order.payment_country = orderItem.payment_country;
            order.payment_country_id = orderItem.payment_country_id;
            order.payment_fee = orderItem.payment_fee;
            order.payment_firstname = orderItem.payment_firstname;
            order.payment_gsm = orderItem.payment_gsm;
            order.payment_installment = orderItem.payment_installment;
            order.payment_lastname = orderItem.payment_lastname;
            order.payment_method = orderItem.payment_method;
            order.payment_postcode = orderItem.payment_postcode;
            order.payment_tax_id = orderItem.payment_tax_id;
            order.payment_zone = orderItem.payment_zone;
            order.payment_zone_id = short.Parse(orderItem.payment_zone_id.ToString());
            order.shipping_address_1 = orderItem.shipping_address_1;
            order.shipping_address_2 = orderItem.shipping_address_2 != null ? orderItem.shipping_address_2.ToString() : null;
            order.shipping_address_format = orderItem.shipping_address_format;
            order.shipping_city = orderItem.shipping_city;
            order.shipping_company = orderItem.shipping_company != null ? orderItem.shipping_company.ToString() : null;
            order.shipping_country = orderItem.shipping_country;
            order.shipping_country_id = orderItem.shipping_country_id;
            order.shipping_firstname = orderItem.shipping_firstname;
            order.shipping_gsm = orderItem.shipping_gsm;
            order.shipping_lastname = orderItem.shipping_lastname;
            order.shipping_method = orderItem.shipping_method;
            order.shipping_postcode = orderItem.shipping_postcode;
            order.shipping_price = orderItem.shipping_price;
            order.shipping_zone = orderItem.shipping_zone;
            order.shipping_zone_id = short.Parse(orderItem.shipping_zone_id.ToString());
            order.telephone = orderItem.telephone;
            order.total = orderItem.total;
            return order;
        }

        private int getAdet(string productName)
        {
            try
            {
                var adIndex = productName.ToLower().IndexOf("adet") - 1;
                var spaceIndex = productName.Substring(0, adIndex).LastIndexOf(' ') + 1;

                var ad = productName.Substring(spaceIndex, adIndex - spaceIndex);

                ad = ad.Replace('(', ' ').Trim();

                int result = 0;
                int.TryParse(ad, out result);
                return result;
            }
            catch (Exception ex)
            {
                return 0;

            }
        }

        private int getKg(string productName)
        {
            try
            {
                var kgIndex = productName.ToLower().IndexOf("kg") - 1;
                var spaceIndex = productName.Substring(0, kgIndex).LastIndexOf(' ') + 1;

                var kg = productName.Substring(spaceIndex, kgIndex - spaceIndex);
                int result = 0;
                int.TryParse(kg, out result);
                return result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        private string HttpPostRequest(Dictionary<string, string> postParameters)
        {
            string postData = "";

            postData += HttpUtility.UrlEncode("password") + "="
                     + HttpUtility.UrlEncode("mikro2255.?") + "&";
            postData += HttpUtility.UrlEncode("username") + "="
                     + HttpUtility.UrlEncode("mikro") + "&";

            foreach (string key in postParameters.Keys)
            {
                postData += HttpUtility.UrlEncode(key) + "="
                      + HttpUtility.UrlEncode(postParameters[key]) + "&";
            }

            HttpWebRequest myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create("https://www.patifood.com/index.php?page=module%2Fwebservice");
            myHttpWebRequest.Method = "POST";

            byte[] data = Encoding.ASCII.GetBytes(postData);

            myHttpWebRequest.ContentType = "application/x-www-form-urlencoded";
            myHttpWebRequest.ContentLength = data.Length;

            Stream requestStream = myHttpWebRequest.GetRequestStream();
            requestStream.Write(data, 0, data.Length);
            requestStream.Close();

            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

            Stream responseStream = myHttpWebResponse.GetResponseStream();

            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.UTF8);

            string pageContent = myStreamReader.ReadToEnd();

            myStreamReader.Close();
            responseStream.Close();

            myHttpWebResponse.Close();

            return pageContent;
        }
    }
}
