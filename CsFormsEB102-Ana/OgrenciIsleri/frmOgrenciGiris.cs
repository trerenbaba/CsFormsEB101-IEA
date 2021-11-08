using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsFormsEB102_Ana.OgrenciIsleri.OgrEntity;
using CsFormsEB102_Ana.Fonksiyonlar;

namespace CsFormsEB102_Ana.OgrenciIsleri
{
    public partial class frmOgrenciGiris : Form
    {
        readonly StudentsEntities sdb = new StudentsEntities();
        private Mesajlar m = new Mesajlar();
        public int secimId = -1;
        public int sehId = -1;
        public int bolId = -1;
        public bool edit = false;

        public frmOgrenciGiris()
        {
            InitializeComponent();
        }

        private void frmOgrenciGiris_Load(object sender, EventArgs e)
        {
            Combolar();
            Temizle();
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0, sayi = 1;
            var lst = from s in sdb.tblOgrenciBilgileri
                      where s.isActive==true
                      select new
                      {
                          id = s.Id,
                          ad = s.Ad,
                          soyad = s.Soyad,
                          tc = s.Tcno,
                          ogrno = s.OgrNo,
                          sehir = s.tblSehirler.sehir,
                          bolum = s.tblDepartments.BolumAdi,
                          durum = s.isActive
                      };
            foreach (var k in lst)
            {
                string sayi1 = DateTime.Now.Year+"-"+sayi.ToString().PadLeft(7, '0');
                Liste.Rows.Add();
                Liste.Rows[i].Cells["Id"].Value = k.id;
                Liste.Rows[i].Cells[1].Value = sayi1;
                Liste.Rows[i].Cells[2].Value = k.ad;
                Liste.Rows[i].Cells[3].Value = k.soyad;
                Liste.Rows[i].Cells[4].Value = k.tc;
                Liste.Rows[i].Cells[5].Value = k.ogrno;
                Liste.Rows[i].Cells[6].Value = k.sehir;
                Liste.Rows[i].Cells[7].Value = k.bolum;
                Liste.Rows[i].Cells[8].Value = k.durum;
                i++;
                sayi++;
            }

            Liste.AllowUserToAddRows = false;

        }
       
        private void YeniKayit()
        {
            try
            {
                tblOgrenciBilgileri ogr = new tblOgrenciBilgileri();
                ogr.Ad = txtAd.Text;
                ogr.Soyad = txtSoyad.Text;
                ogr.Tcno = mTxtTc.Text;
                ogr.OgrNo = mTxtOgrNo.Text;
                //ogr.SehirId = sehId;
                ogr.SehirId = sdb.tblSehirler.First(x=>x.sehir==txtSehir.Text).id;
                //ogr.BolumId = bolId;
                ogr.BolumId = sdb.tblDepartments.First(x=>x.BolumAdi==txtBolum.Text).Id;
                ogr.isActive = true;

                sdb.tblOgrenciBilgileri.Add(ogr);
                sdb.SaveChanges();
                m.YeniKayit("Ogr bilgileri kaydedildi...");
                Listele();
            }
            catch (Exception e)
            {
                m.Hata(e);
            }

        }

        private void Combolar()
        {
            txtSehir.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection veri = new AutoCompleteStringCollection();

            var lst = sdb.tblSehirler.Select(x => x.sehir).Distinct();
         
            foreach (string s in lst)
            {

                veri.Add(s);
                txtSehir.Items.Add(s);
            }
            txtSehir.AutoCompleteCustomSource = veri;

            txtBolum.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection veri1 = new AutoCompleteStringCollection();

            var lst1 = sdb.tblDepartments.Where(x => x.isActive == true).Select(x=>x.BolumAdi).Distinct();
            foreach (string s in lst1)
            {
                veri1.Add(s);
                txtBolum.Items.Add(s);
            }
            txtBolum.AutoCompleteCustomSource = veri;
        }

        private void Temizle()
        {
            // txtSehir.Items.Clear(); // Bu işlem combobox içindeki bütün verileri 0 lar
            //txtAd.Clear();
            //txtSoyad.Clear();
            //txtTcno.Clear();
            //txtOgrno.Clear();

            foreach (Control ct in scOgr.Panel1.Controls)
            {
                if (ct is TextBox || ct is ComboBox || ct is MaskedTextBox)
                {
                    ct.Text = "";
                }
            }
            secimId = -1;
            edit = false;
            bolId = -1;
            sehId = -1;
           
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            if (secimId>0 && edit==true && m.Guncelle()==DialogResult.Yes)
            {
                Guncelle();
            }
            else if (edit==false)
            {
                YeniKayit();
            }
            Listele();
            Temizle();
        }

        private void Guncelle()
        {
            try
            {
                tblOgrenciBilgileri ogr = sdb.tblOgrenciBilgileri.Find(secimId);
                ogr.Ad = txtAd.Text;
                ogr.Soyad = txtSoyad.Text;
                ogr.SehirId = sdb.tblSehirler.First(x => x.sehir == txtSehir.Text).id;
                ogr.BolumId = sdb.tblDepartments.First(x => x.BolumAdi == txtBolum.Text).Id;
                ogr.Tcno = mTxtTc.Text;
                ogr.OgrNo = mTxtOgrNo.Text;
                sdb.SaveChanges();
                m.Guncelle(true);
                Temizle();
            }
            catch (Exception e)
            {
                m.Hata(e);
            }
        }

        private void Ac()
        {
            try
            {
                tblOgrenciBilgileri ogr = sdb.tblOgrenciBilgileri.Find(secimId);
                txtSehir.Text = ogr.tblSehirler.sehir;
                txtBolum.Text = ogr.tblDepartments.BolumAdi;
                txtAd.Text = ogr.Ad;
                txtSoyad.Text = ogr.Soyad;
                mTxtOgrNo.Text = ogr.OgrNo;
                mTxtTc.Text = ogr.Tcno;
            }
            catch (Exception e)
            {
                m.Hata(e);
            }
        }
        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                edit = true;
                secimId = (int)Liste.CurrentRow.Cells[0].Value;
                Ac();

            }
            catch (Exception)
            {
                secimId = -1;
                edit = false;

            }            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            tblOgrenciBilgileri ogr = sdb.tblOgrenciBilgileri.Find(secimId);
            ogr.isActive = false;
            sdb.SaveChanges();
            MessageBox.Show("Kayıt başarı ile silindi...");
            Temizle();
            Listele();
        }
    }
}
