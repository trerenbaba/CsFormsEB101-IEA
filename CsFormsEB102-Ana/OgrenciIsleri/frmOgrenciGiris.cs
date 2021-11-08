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
        public int sehId = -1;
        public int bolId = -1;

        public frmOgrenciGiris()
        {
            InitializeComponent();
        }

        private void frmOgrenciGiris_Load(object sender, EventArgs e)
        {
            Comboolar();
            Temizle();
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var lst = from s in sdb.tblOgrenciBilgileri
                      select new
                      {
                          id = s.Id,
                          ad = s.Ad,
                          soyad = s.Soyad,
                          tc = s.Tcno,
                          ogrno = s.OgrNo,
                          sehir = s.tblSehirler.sehir,
                          bolum = s.tblDepartments.BolumAdi
                      };
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells["Id"].Value = k.id;
                Liste.Rows[i].Cells[1].Value = k.ad;
                Liste.Rows[i].Cells[2].Value = k.soyad;
                Liste.Rows[i].Cells[3].Value = k.tc;
                Liste.Rows[i].Cells[4].Value = k.ogrno;
                Liste.Rows[i].Cells[5].Value = k.sehir;
                Liste.Rows[i].Cells[6].Value = k.bolum;
                i++;
            }
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

        private void Comboolar()
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
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }
    }
}
