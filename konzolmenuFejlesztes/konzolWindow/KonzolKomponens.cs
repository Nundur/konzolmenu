using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konzolmenuFejlesztes.konzolWindow
{
    abstract class KonzolKomponens
    {

        public abstract void Draw(int x, int y);
        public abstract object Update(int x, int y);
        public abstract int Rx { get; set; }
        public abstract int Ry { get; set; }

    }
}
