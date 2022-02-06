using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AlbumEdit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ListView oge;
        List<string> gelenAlbum = new List<string>();
        Klasor album;

        Album nesne;
        DosyaIslemleri islem;

        Yakalayici jpg1 = new JpgYakalayici();
        Yakalayici png1 = new JpgYakalayici();
        
        


        NesneYaratici nesnemiz = NesneYaratici.Yaratici();

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.FileSystemInfo fsi = new FileInfo("klasor.png");
            album = new Klasor(fsi.FullName);
            album.Dolas();

            islem = new DosyaIslemleri(listView1);
            oge=islem.DosyaOlusturma();
            gelenAlbum=islem.IsimGonder(oge);



        }


        private void listView1_DoubleClick(object sender, EventArgs e)
        {

            nesne = new Album(oge);
            nesne.Guncelle(gelenAlbum);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            islem.DosyaOkutma();

            jpg1.Istek(png1.ToString());
        }
    }
}
