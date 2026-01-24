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
        public abstract string name { get; set; }

        public abstract ConsoleColor ForeGround { get; set; }
        public abstract ConsoleColor BackGround { get; set; }
        public abstract string header { get; set; }
        public abstract int Rx { get; set; }
        public abstract int Ry { get; set; }
        public abstract int width { get; set; }
        public abstract int height { get; set; }

    }
}
