using PatifoodDataModel;
using PatifoodDataModel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatifoodApp
{
    public partial class Sorgulama : Form
    {
        private int kumbaraParentId = 999999802;

        public Sorgulama()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Sorgula_Click(object sender, EventArgs e)
        {
            var names = new List<string> { "aaa", "bbb" };

            names.Add("ccc");

            var context = new PatifoodDataContext();
            //var orders = context.Orders.ToList();


            //var orders = context.Orders.Where(c => c.OrderProducts.Any(op => names.Contains(op.product.category.name) && op.product.category.name == cmb_Il.SelectedValue && op.product.name == cmb_TeslimYeri.SelectedValue )).ToList();

            var orders = context.OrderProducts.Where(c => c.product.name == cmb_TeslimYeri.SelectedValue).ToList();

            Dgw1.DataSource = orders;
        }


        private void btn_Paket_Click(object sender, EventArgs e)
        {

        }

        private void Sorgulama_Load(object sender, EventArgs e)
        {
            var context = new PatifoodDataContext();

            var categorys = context.Categorys.Where(c => c.parent_id == kumbaraParentId).GroupBy(c => c.name)
                .Select(c => c.FirstOrDefault().name).ToDictionary(c => c, c => c);

            cmb_Il.DataSource = new BindingSource(categorys, null);
            cmb_Il.DisplayMember = "Value";
            cmb_Il.ValueMember = "Key";

            var products = context.Products.Where(c => c.category.parent_id == kumbaraParentId).GroupBy(c => c.name)
                .Select(c => c.FirstOrDefault().name).ToDictionary(c => c, c => c);

            cmb_TeslimYeri.DataSource = new BindingSource(products, null);
            cmb_TeslimYeri.DisplayMember = "Value";
            cmb_TeslimYeri.ValueMember = "Key";

            var list = context.OrderProducts.Where(c => c.product.category.parent_id == kumbaraParentId).Select(c => new { c.Id, BarinakName = c.name, UrunName = c.option_name, c.Birim, c.BirimName, Adet = c.quantity, UrunOptionCode = c.option_code, Toplam = c.quantity * c.Birim }).ToList();

            //        var groupList = list.GroupBy(
            //p => p.BarinakName,
            //p => p.UrunName,
            //(key, g) => new { BarinakName = key, UrunName = g.Fir() }).Select(c => new { c.BarinakName, c.UrunName, Birim = list.Where(p => p.BarinakName == c.BarinakName && p.UrunName == c.UrunName).Sum(p => p.Adet) } ).ToList();


            var groupList = list.GroupBy(n => new { n.BarinakName, n.UrunName })
                .Select(c => new { c.Key.BarinakName, c.Key.UrunName, Birim = list.Where(p => p.BarinakName == c.Key.BarinakName && p.UrunName == c.Key.UrunName).Sum(p => p.Toplam) }).ToList();

            Dgw2.DataSource = groupList.OrderBy(x => x.BarinakName).ThenBy(x => x.Birim).ToList();
            //return;
            var deletePAcket = context.Packet.Where(c => c.IsTemp);
            

            context.PacketOrderProduct.RemoveRange(deletePAcket.SelectMany(c=> c.PacketOrderProducts));
            context.PacketOrderProduct.RemoveRange(deletePAcket.SelectMany(c=> c.UnPacketOrderProducts));

            context.Packet.RemoveRange(deletePAcket);
            context.SaveChanges();

            var bariknameGroup = list.GroupBy(n => n.BarinakName)
                .Select(c => new { BarinakName = c.Key }).ToList();

            bariknameGroup = bariknameGroup.Where(c => c.BarinakName.Contains("Mehmet Ali Turgut")).ToList();
            foreach (var bariknameItem in bariknameGroup)
            {
                var packet = new Packet();

                packet.Id = Guid.NewGuid();
                packet.Name = bariknameItem.BarinakName;
                packet.IsTemp = true;
                packet.CargoStatus = 0;
                packet.PacketOrderProducts = new List<PacketOrderProduct>();
                packet.UnPacketOrderProducts = new List<PacketOrderProduct>();
                var ids = new List<Guid>();

                var packedGroupItems = groupList.Where(c => c.BarinakName == bariknameItem.BarinakName);

                foreach (var packedGroupItem in packedGroupItems)
                {
                    var tempProducts = list.Where(p => p.BarinakName == packedGroupItem.BarinakName && p.UrunName == packedGroupItem.UrunName);
                    var productOptCodeGroups = tempProducts.GroupBy(c => c.UrunOptionCode).Select(c => new { OptionCode = c.Key });

                    foreach (var productOptCodeGroup in productOptCodeGroups)
                    {
                        var conf = context.ProductConfig.First(c => c.OptionCode == productOptCodeGroup.OptionCode);
                        var optCodeProducts = tempProducts.Where(c => c.UrunOptionCode == productOptCodeGroup.OptionCode).ToList();

                        var urunAdet = optCodeProducts.Sum(c => c.Toplam);

                        if (conf.Quantity > 1)
                        {
                            for (int i = urunAdet.Value / conf.Quantity; i > 0; i--)
                            {
                                indexlist = new List<int>();
                                strlist = new List<string>();
                                x = optCodeProducts.Select(c => c.Toplam.Value).ToList();

                                calculate(x, conf.Quantity * i, indexlist);

                                if (strlist != null && strlist.Count > 0)
                                {
                                    foreach (var strItem in strlist)
                                    {
                                        var sayilar = strItem.Split(',');

                                        foreach (var sayi in sayilar)
                                        {
                                            var optCodeProduct = optCodeProducts.First(c => c.Toplam.Value == int.Parse(sayi));
                                            packet.PacketOrderProducts.Add(new PacketOrderProduct
                                            {
                                                OrderProduct = context.OrderProducts.First(c => c.Id == optCodeProduct.Id),
                                                Id = Guid.NewGuid(),
                                                DateCreated = DateTime.Now
                                            });

                                            optCodeProducts.Remove(optCodeProduct);
                                        }
                                    }
                                }
                            }

                            ids = optCodeProducts.Select(o => o.Id).ToList();
                            var unPackedProducts = context.OrderProducts.Where(c => ids.Contains(c.Id)).ToList();

                            foreach (var unPacketOrderProduct in unPackedProducts)
                            {
                                packet.UnPacketOrderProducts.Add(new PacketOrderProduct
                                {
                                    OrderProduct = unPacketOrderProduct,
                                    Id = Guid.NewGuid(),
                                    DateCreated = DateTime.Now
                                });
                            }
                        }
                        else
                        {
                            ids = optCodeProducts.Select(o => o.Id).ToList();
                            var packedProducts = context.OrderProducts.Where(c => ids.Contains(c.Id)).ToList();

                            foreach (var packedProduct in packedProducts)
                            {
                                packet.PacketOrderProducts.Add(new PacketOrderProduct
                                {
                                    OrderProduct = packedProduct,
                                    Id = Guid.NewGuid(),
                                    DateCreated = DateTime.Now
                                });
                            }
                            

                        }
                        

                        //var uyanlar = GetCombinations(sayilar, 15 * (32 / 15), "");
                        //var uyanlar = GetCombinations(sayilar, 15 * (15 / 15), "");

                        //Toplamlarının conf a bölümü kadar for dön (büyükten küçüğe)
                        //GetCombinations çalıştır uyanları packet packet.PacketOrderProducts ekle listeden çıkart
                        //bütün döngü bittikten sonra kalan varsa packet.UnPacketOrderProducts ekle
                        //ssss
                    }
                }
                context.Packet.Add(packet);

                context.SaveChanges();
            }

            
        }

        int olas = 0;

        List<int> indexlist = new List<int>();
        List<string> strlist = new List<string>();
        List<int> x = new List<int>();

        private void calculate(List<int> array, int toplam, List<int> index)
        {
            int temp = 0;

            for (int i = 0; i < array.Count; i++)
            {
                temp = toplam - array[i];

                for (int y = i + 1; y < array.Count; y++)
                {
                    if (array[y] == temp)
                    {
                        index.Add(array[i]);
                        index.Add(array[y]);

                        olas++;

                        strlist.Add(string.Join(",", index));

                        index.Clear();
                    }
                }

                if (array.Any(k => k != array[i] && k <= temp))
                {
                    var a = olas;

                    index.Add(array[i]);
                    calculate(array.GetRange(i, array.Count - i).Where(x => x != array[i] && x <= temp).ToList(), temp, index);

                    if (olas > a)
                    {
                        strlist.Add(string.Join(",", index));
                    }

                    index.Clear();
                }
            }
        }

        private IEnumerable<string> GetCombinations(int[] set, int sum, string values)
        {
            for (int i = 0; i < set.Length; i++)
            {
                int left = sum - set[i];
                string vals = set[i] + "," + values;
                if (left == 0)
                {
                    yield return vals;
                }
                else
                {
                    int[] possible = set.Take(i).Where(n => n <= sum).ToArray();
                    if (possible.Length > 0)
                    {
                        foreach (string s in GetCombinations(possible, left, vals))
                        {
                            yield return s;
                        }
                    }
                }
            }
        }

        private void cmb_Il_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Dgw1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        private void button1_Click(object sender, EventArgs e)
        {


            //    DataGridView sourceGrid = this.Dgw1;
            //    DataGridView targetGrid = this.Dgw2;

            //    //Copy all rows and cells.

            //    var targetRows = new List<DataGridViewRow>();

            //    foreach (DataGridViewRow sourceRow in sourceGrid.Rows)
            //    {

            //        if (!sourceRow.IsNewRow)
            //        {

            //            var targetRow = (DataGridViewRow)sourceRow.Clone();


            //            foreach (DataGridViewCell cell in sourceRow.Cells)
            //            {
            //                targetRow.Cells[cell.ColumnIndex].Value = cell.Value;
            //            }

            //            targetRows.Add(targetRow);

            //        }

            //    }

            //    //Clear target columns and then clone all source columns.

            //    targetGrid.Columns.Clear();

            //    foreach (DataGridViewColumn column in sourceGrid.Columns)
            //    {
            //        //        targetGrid.Columns.Add((DataGridViewColumn)column.Clone());
        }

        private void Dgw1_MultiSelectChanged(object sender, EventArgs e)
        {
            //DataTable table = new DataTable();

            //table.Columns.Add("Name", typeof(string));
            //table.Columns.Add("Name2", typeof(string));
            //table.Columns.Add("Name3", typeof(string));

            //foreach (DataGridViewRow dr in Dgw1.Rows)
            //{
            //    var value = ((DataGridViewCheckBoxCell)dr.Cells[0]).Value;
            //    if (value != null && (bool)value)
            //    {
            //        table.Rows.Add(dr.Cells[1].Value, dr.Cells[3].Value, dr.Cells[5].Value);

            //    }
            //}

            //Dgw2.DataSource = table;
        }

        private void Dgw1_CurrentCellChanged(object sender, EventArgs e)
        {

            //DataTable table = new DataTable();

            //table.Columns.Add("ID", typeof(string));
            //table.Columns.Add("Adı", typeof(string));
            //table.Columns.Add("Soyadı", typeof(string));

            //foreach (DataGridViewRow dr in Dgw1.Rows)
            //{
            //    var value = ((DataGridViewCheckBoxCell)dr.Cells[0]).Value;
            //    if (value != null && (bool)value)
            //    {
            //        table.Rows.Add(dr.Cells[1].Value, dr.Cells[5].Value, dr.Cells[6].Value);

            //    }
            //}

            //Dgw2.DataSource = table;
        }

        //private void button2_Click(object sender, EventArgs e)
        //{


        //    DataTable table = new DataTable();

        //    table.Columns.Add("Name", typeof(string));
        //    table.Columns.Add("Name2", typeof(string));
        //    table.Columns.Add("Name3", typeof(string));

        //    foreach (DataGridViewRow dr in Dgw1.Rows)
        //    {
        //        var value = ((DataGridViewCheckBoxCell)dr.Cells[0]).Value;
        //        if (value != null && (bool)value)
        //        {
        //            table.Rows.Add(dr.Cells[1].Value, dr.Cells[3].Value, dr.Cells[5].Value);

        //        }
        //    }

        //    Dgw2.DataSource = table;



        //}

        //    //    //It's recommended to use the AddRange method (if available)
        //    //    //when adding multiple items to a collection.



        //}

    }
}

