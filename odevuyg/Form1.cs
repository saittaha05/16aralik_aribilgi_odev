using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odevuyg
{
    public partial class Form1 : Form
    {
        NorthwindEntities db = new NorthwindEntities(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ***ALFKI müşteri ID'sine sahip müşterinin siparişlerini listeleyelim,

            //* **Ürünler tablosunda en yüksek fiyata sahip ürünün id ve isim bilgisini bulalım,

            //***Siparişler tablosunda 20 ile 50.siparişlerin bilgilerini bulalım,

            //***Chai adlı ürünün tüm sipariş detaylarını listeleyelim


        }

        private void btnsprs_Click(object sender, EventArgs e)
        {
            var data = db.Orders
                         .Where(x => x.CustomerID == "ALFKI")
                         .OrderBy(x => x.OrderID)
                         //.Select(x => x)
                         //.Select(x => x.CompanyName)
                         .Select(x => new
                         {
                            siparisnumarasi = x.OrderID,
                             musterinumarasi = x.CustomerID,
                             calisan = x.EmployeeID,
                             siparistarihi= x.OrderDate,
                         })
                         .ToList();

            foreach (var item in data)
            {
                MessageBox.Show("sipariş numarası " + item.siparisnumarasi+ "\n"+
                    "Müşteri numarası "+item.musterinumarasi+"\n"+"calisan "+item.calisan +"\n"+ "sipariş tarihi"+item.siparistarihi);
            }
        }

        private void btnurun_Click(object sender, EventArgs e)
        {
            var data = db.Products.OrderByDescending(x => x.UnitPrice).First();
            MessageBox.Show("Ürün ID: " + data.ProductID +"\n"+ "Ürün Adı : "+ data.ProductName);

        }

        private void btnorders_Click(object sender, EventArgs e)
        {
            var data = db.Orders.OrderBy(x => x.OrderID).Skip(20).Take(50).ToList();
            foreach (var item in data) 
            {
                MessageBox.Show("Sipariş numarası : " + item.OrderID + "\n" + "Müşteri Adı :" + item.ShipName);
            }
        }

        private void btnchai_Click(object sender, EventArgs e)
        {
            var data= db.Order_Details
                .Join(db.Products,
                od => od.ProductID,
                p=> p.ProductID,
                (od, p)=> new {Order_Details = od, Products = p})
                .Where(x => x.Products.ProductName=="Cahi")
                .Select(x=> new 
                {
                    OrderID = x.Order_Details.OrderID,
                    ProductName = x.Products.ProductName,
                    UnitPrice = x.Order_Details.UnitPrice,

                })
                .ToList();
            foreach(var item in data) 
            {
                MessageBox.Show("Ürün Adı : " + item.ProductName + "\n" +"Sipariş numarasi"+ item.OrderID  + "\n"+"Ürün fiyatı :" + item.UnitPrice);
                

            }
        }
    }
}
