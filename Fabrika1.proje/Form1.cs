using Fabrika1.proje.ORM.Context;
using Fabrika1.proje.ORM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fabrika1.proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        Internet_Sales net;
        Context db = new Context();
        FabrikaEntities fab = new FabrikaEntities();

        


        private void btn_internet_Click(object sender, EventArgs e)
        {
            //List<Internet_Sales> liste = db.Internet_Sales.ToList();
            dataGridView1.DataSource = db.Internet_Sales.ToList();
        }
       
        
        private void btn_ayakkabıGiriş_çıkış_Click(object sender, EventArgs e)
        {

        }
        private void btn_malzemeler_Click(object sender, EventArgs e)
        {

        }
        private void btn_manufacturing_Click(object sender, EventArgs e)
        {

        }
        private void DateGridview1_celldoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_barkod.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            net = new Internet_Sales();

            if (net!=null)
            {
                
                net.Model = txt_model.Text;
                net.Brand = txt_marka.Text;
                net.Colour = txt_renk.Text;
                net.Number = txt_numara.Text;
                net.pıece = txt_adet.Text;
                net.prıce = Convert.ToInt32(txt_fiyat.Text);
                net.barcod_no = Convert.ToInt32(txt_barkod.Text);

                db.Internet_Sales.Add(net);
                db.SaveChanges();

                txt_model.Text = "";
                txt_marka.Text = " ";
                txt_renk.Text = "";
                txt_numara.Text = "";
                txt_adet.Text = "";
                txt_fiyat.Text = "";
                txt_barkod.Text = "";

                MessageBox.Show("Veri eklendi!");
                dataGridView1.DataSource = db.Internet_Sales.ToList();

            }
            else
                MessageBox.Show("Veri yüklenmedi!");
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            //net = new Internet_Sales();
            int Barkod =Convert.ToInt32( txt_barkod.Text);
            var i = db.Internet_Sales.Where(w => w.barcod_no == Barkod).FirstOrDefault();

            i.Model = txt_model.Text;
            i.Brand = txt_marka.Text;
            i.Colour = txt_renk.Text;
            i.Number = txt_numara.Text;
            i.pıece = txt_adet.Text;
            i.prıce = Convert.ToInt32(txt_fiyat.Text);
            i.barcod_no = Convert.ToInt32(txt_barkod.Text);

            db.Internet_Sales.Add(i);
            db.SaveChanges();

            txt_marka.Text = " ";
            txt_renk.Text = "";
            txt_numara.Text = "";
            txt_adet.Text = "";
            txt_fiyat.Text = "";
            txt_barkod.Text = "";

            MessageBox.Show("Güncelleme gerçekleşti!");
            dataGridView1.DataSource = db.Internet_Sales.ToList();
        }    

        private void btn_sil_Click(object sender, EventArgs e)
        {
            net = new Internet_Sales();
            net.barcod_no = Convert.ToInt32(txt_barkod.Text);            
            net = db.Internet_Sales.Find(net.barcod_no);
            if (net != null)
            {
                db.Internet_Sales.Remove(net);
                db.SaveChanges();

                txt_model.Text = "";
                txt_marka.Text = " ";
                txt_renk.Text = "";
                txt_numara.Text = "";
                txt_adet.Text = "";
                txt_fiyat.Text = "";
                txt_barkod.Text = "";

                MessageBox.Show("Veri Silindi!");
                dataGridView1.DataSource = db.Internet_Sales.ToList();
            }
            else
                MessageBox.Show("Hata! Veri Silinemedi!");
        }

        
    }
    
}
