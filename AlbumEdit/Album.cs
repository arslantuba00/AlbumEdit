using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AlbumEdit
{
    class Album : Form1
    {
        private List<string> gelenListe = new List<string>();
        private ListView liste = new ListView();

 

        public Album(ListView gelen)
        {
            liste = gelen;
        }

        public void Guncelle(List<string> gelenAlbum)
        {
            for (int i = 0; i < liste.Items.Count; i++)
            {

                if (liste.SelectedItems.Count<=3)
                {
                   

                    switch (i)
                    {
                        case 0:
                            listView1.Visible = false;
                            listView2.Visible = true;
                            button1.Visible = false;
                            button2.Enabled = true;
                            MessageBox.Show("1");
                            break;

                        case 1:
                            MessageBox.Show("2");

                            break;

                        case 2:
                            MessageBox.Show("3");
                            break;
                    }
                }
            }
        }
    }
}
