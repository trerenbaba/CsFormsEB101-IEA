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
    public partial class frmBolumGiris : Form
    {
        readonly StudentsEntities sdb = new StudentsEntities();
        private Mesajlar m = new Mesajlar();

        private int secimId = -1;
        private bool edit = false;
        public frmBolumGiris()
        {
            InitializeComponent();
        }

        private void frmBolumGiris_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            if (rbHepsi.Checked == true)
            {
                Liste.Rows.Clear();
                int i = 0;
                var lst = (from s in sdb.tblDepartments select s).ToList();
                foreach (var k in lst)
                {
                    Liste.Rows.Add();
                    Liste.Rows[i].Cells[0].Value = k.Id;
                    Liste.Rows[i].Cells[1].Value = k.BolumAdi;
                    Liste.Rows[i].Cells[2].Value = k.isActive;
                    i++;
                }
                Liste.AllowUserToAddRows = false;
                Liste.AllowUserToDeleteRows = false;
                Liste.AllowUserToOrderColumns = false;
            }
            else if (rbAktif.Checked == true)
            {
                Liste.Rows.Clear();
                int i = 0;
                var lst = (from s in sdb.tblDepartments where s.isActive == true select s).ToList();
                foreach (var k in lst)
                {
                    Liste.Rows.Add();
                    Liste.Rows[i].Cells[0].Value = k.Id;
                    Liste.Rows[i].Cells[1].Value = k.BolumAdi;
                    Liste.Rows[i].Cells[2].Value = k.isActive;
                    i++;
                }
                Liste.AllowUserToAddRows = false;
                Liste.AllowUserToDeleteRows = false;
                Liste.AllowUserToOrderColumns = false;
            }
            else if (rbPasif.Checked == true)
            {
                Liste.Rows.Clear();
                int i = 0;
                var lst = (from s in sdb.tblDepartments where s.isActive == false select s).ToList();
                foreach (var k in lst)
                {
                    Liste.Rows.Add();
                    Liste.Rows[i].Cells[0].Value = k.Id;
                    Liste.Rows[i].Cells[1].Value = k.BolumAdi;
                    Liste.Rows[i].Cells[2].Value = k.isActive;
                    i++;
                }
                Liste.AllowUserToAddRows = false;
                Liste.AllowUserToDeleteRows = false;
                Liste.AllowUserToOrderColumns = false;
            }
        }

        private void YeniKayit()
        {
            try
            {
                if (txtBolumAdi.Text!="")
                {
                    tblDepartments blm = new tblDepartments();
                    blm.BolumAdi = txtBolumAdi.Text;
                    blm.isActive = true;
                    sdb.tblDepartments.Add(blm);
                    sdb.SaveChanges();
                    m.YeniKayit("Yeni Kayıt Oluşturuldu");
                    //MessageBox.Show("Yeni kayıt oluşturuldu."); 
                }
                

            }
            catch (Exception e)
            {
                MessageBox.Show("Hata 101-01:" + e);
            }

        }
        private void Guncelle()
        {
            try
            {
                // tblDepartments blm = sdb.tblDepartments.First(x => x.Id == secimId); //First tek kayıt döndürmeyi sağlar.Hatalı bile    olsa sonuç döndürecek.Where gibi bölüm adı vs. çapırabiliriz.
                tblDepartments blm = sdb.tblDepartments.Find(secimId);
                 blm.BolumAdi = txtBolumAdi.Text;
               // blm.Id = 22222; //Hata alabilmekj için değiştirdik.
                sdb.SaveChanges();
                m.Guncelle(true);
            }
            catch (Exception e)
            {
                m.Guncelle(false);
                m.Guncelle(e);
               // MessageBox.Show("" + e);
                this.Close();
            }
           // MessageBox.Show("Kayıt Güncelleştirildi!!!...");
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (secimId > 0 && edit == true && m.Guncelle()==DialogResult.Yes)
            {
                Guncelle();
            }
            else if(edit==false)
            {
                YeniKayit();
            }
            //else
            //{
            //    Temizle();
            //}
            Listele();
            Temizle();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int)Liste.CurrentRow.Cells[0].Value;
            txtBolumAdi.Text = Liste.CurrentRow.Cells[1].Value.ToString();
            //MessageBox.Show(secimId.ToString());
            if (secimId>0)
            {
                edit = true;
            }


        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            secimId = -1;
            edit = false;
            txtBolumAdi.Clear();

        }

        private void txtBolumAdi_TextChanged(object sender, EventArgs e)
        {
            //if (txtBolumAdi.Text == "")
            //{
            //    edit = false;
            //}
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
            Temizle();
            Listele();
        }
        private void Sil()
        {
            try
            {
                tblDepartments blm = sdb.tblDepartments.Find(secimId);
                // blm.BolumAdi = txtBolumAdi.Text;
                blm.isActive = false; //Hata alabilmekj için değiştirdik.
               // blm.Id = 2222222; // hata için
                sdb.SaveChanges();
                m.Sil(true);
                //MessageBox.Show("Kayıt silinmiştir.");
            }
            catch (Exception e)
            {
                m.Sil(false);
                m.Sil(e);
                
            }
        }

        private void btnTamSil_Click(object sender, EventArgs e)
        {
            try
            {
                tblDepartments blm = sdb.tblDepartments.Find(secimId);
                sdb.tblDepartments.Remove(sdb.tblDepartments.Find(secimId));
                blm.Id = 2222222; //hata için
                sdb.SaveChanges();
                m.TamSil(true);
                Temizle();
                Listele();
            }
            catch (Exception ee)
            {

                m.TamSil(false);
                m.TamSil(ee);
            }
        }

        private void chkPasif_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPasif.Checked==true)
            {
                Liste.Rows.Clear();
                int i = 0;
                var lst = (from s in sdb.tblDepartments where s.isActive == false select s).ToList();
                foreach (var k in lst)
                {
                    Liste.Rows.Add();
                    Liste.Rows[i].Cells[0].Value = k.Id;
                    Liste.Rows[i].Cells[1].Value = k.BolumAdi;
                    i++;
                }
                Liste.AllowUserToAddRows = false;
            }
            else
            {
                Listele();
            }
        }

        private void rbHepsi_CheckedChanged(object sender, EventArgs e)
        {
            Listele();
        }

        private void rbAktif_CheckedChanged(object sender, EventArgs e)
        {
            Listele();
        }

        private void rbPasif_CheckedChanged(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
