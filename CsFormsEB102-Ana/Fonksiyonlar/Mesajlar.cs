using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsFormsEB102_Ana.Fonksiyonlar
{
    class Mesajlar
    {
        public void YeniKayit(string mesaj)
        {
            MessageBox.Show(mesaj,"Yeni Kayıt Giriş",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public DialogResult Guncelle()
        {

            return MessageBox.Show("Seçili olan kayıt güncellenecektir.\n Güncelleme işlemini onaylıyor musunuz?", "Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public void Guncelle(bool guncelleme)
        {
            if (guncelleme==true)
            {
                MessageBox.Show("Kayıt güncellenmiştir.", "Kayıt Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Hata oluştu.");
            }
        }
        public void Guncelle(Exception e)
        {
            MessageBox.Show("" + e, "Kayıt Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Sil(bool silindiMi)
        {
            if (silindiMi==true)
            {
                MessageBox.Show("Kayıt silinmiştir","Kayıt Silme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hata oluştu.");
            }
        }
        public void Sil(Exception e)
        {
            MessageBox.Show(""+e,"Kayıt Silme",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        public void TamSil(bool tamSilindiMi)
        {
            if (tamSilindiMi==true)
            {
                MessageBox.Show("Kayıt tamamen silinmiştir", "Tamamen Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Tamamen Silinme İşleminde Hata Oluştu.");
            }
        }
        public void TamSil(Exception e)
        {
            MessageBox.Show("" + e, "Tam Kayıt Silme", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Hata(Exception hata)
        {
            MessageBox.Show(hata.Message, "işler yolunda gitmiyor.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
