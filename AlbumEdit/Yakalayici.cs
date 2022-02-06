using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumEdit
{
    abstract class Yakalayici
    {
        protected Yakalayici varis;
        public void Varis(Yakalayici varis) { this.varis = varis; }

        public abstract void Istek(string istek);
    }
}
