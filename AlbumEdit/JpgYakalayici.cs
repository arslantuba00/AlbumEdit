using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumEdit
{
    class JpgYakalayici : Yakalayici
    {
        public override void Istek(string istek)
        {
            if (istek.EndsWith(".jpg"))
            {

            }
            else if (istek == null) { varis.Istek(istek); }
        }
    }
}
