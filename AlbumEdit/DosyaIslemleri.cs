using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace AlbumEdit
{
    class DosyaIslemleri : Form1
    {
        List<string> albumIsim = new List<string>();
        private ListView gelenListe = new ListView();

        public DosyaIslemleri(ListView gelenListe)
        {
            this.gelenListe = gelenListe;

        }

        public ListView DosyaOlusturma()
        {
           

            try
            {
                ImageList list = new ImageList();
                list.ImageSize = new System.Drawing.Size(90, 90);
                var isim = Image.FromFile(@"C:\Users\tubaa\source\repos\AlbumEdit\AlbumEdit\bin\Debug\klasor.png");


                list.Images.Add(isim);
                list.Images.Add(isim);
                list.Images.Add(isim);
                gelenListe.LargeImageList = list;
                gelenListe.Items.Add(new ListViewItem("Okul", 0));
                gelenListe.Items.Add(new ListViewItem("Yaz", 1));
                gelenListe.Items.Add(new ListViewItem("Tatil", 2));


            }
            catch (Exception t)
            {
                MessageBox.Show("Dosya oluşturulurken hata oluştu.", t.Message);
            }

            return gelenListe;
            
            

        }

        public List<string> IsimGonder(ListView gelenListe)
        {
            for (int i = 0; i < gelenListe.Items.Count; i++)
            {
                albumIsim.Add(gelenListe.Items[i].Text);
            }

            return albumIsim;
        }

        public void DosyaOkutma()
        {

            try
            {
                OpenFileDialog d = new OpenFileDialog() {};
                d.ShowDialog();
                string resimYolu = d.FileName;
                pictureBox1.Image = Image.FromFile(resimYolu);
                
                
            }
            catch (Exception t)
            {
                MessageBox.Show("Dosya okutulurken hata oluştu.", t.Message);
            }
        }

        public void DosyaKaydetme()
        {

            try
            {
                //dosya kaydetme işlemi
            }
            catch (Exception t)
            {
                MessageBox.Show("Dosya kaydedilirken hata oluştu.", t.Message);
            }
        }

        // album klasörü oluşturma kaydetme vs.
    }
}
