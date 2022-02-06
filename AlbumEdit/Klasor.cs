using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Collections;

namespace AlbumEdit
{
    class Klasor : Form, IBilesen
    {
        private string dosyayolu;
        public Klasor(string dosyaYolu)
        {
            this.dosyayolu = dosyaYolu;
        }
        private List <IBilesen> liste = new List<IBilesen>();

        public void Ekle(IBilesen b)
        {
            liste.Add(b);
        }

        public void Dolas()
        {
            MessageBox.Show(String.Format("{0}", dosyayolu));

            foreach (IBilesen item in liste)
            {
                item.Dolas();
            }
        }

    }
}
