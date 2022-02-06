using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumEdit
{
    class NesneYaratici
    {
        private static NesneYaratici nesne;

        private NesneYaratici()
        {

        }

        public static NesneYaratici Yaratici()
        {
            if(nesne == null) { nesne = new NesneYaratici(); }
            return nesne;
        }

    }
}
