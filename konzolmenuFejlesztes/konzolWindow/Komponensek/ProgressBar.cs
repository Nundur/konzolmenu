using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konzolmenuFejlesztes.konzolWindow.Komponensek
{
    class ProgressBar : KonzolKomponens
    {
        //int x, int y,
        //int szelesseg, int hossz,
        //ConsoleColor ForeGround, ConsoleColor BackGround,
        //int miliSec)



        public override int Rx { get; set; }
        public override int Ry { get; set; }
        public int szelesseg { get; set; }
        public int hossz { get; set; }
        public ConsoleColor ForeGround { get; set; }
        public ConsoleColor BackGround { get; set; }
        public int miliSec { get; set; }

        public ProgressBar(int rx, int ry, int szelesseg, int hossz, ConsoleColor foreGround, ConsoleColor backGround, int miliSec)
        {
            Rx = rx;
            Ry = ry;
            this.szelesseg = szelesseg;
            this.hossz = hossz;
            ForeGround = foreGround;
            BackGround = backGround;
            this.miliSec = miliSec;
        }

        public override void Draw(int x, int y)
        {
            konzolmenu konzolmenu = new konzolmenu();
            konzolmenu.Ablak(x+Rx, y+Ry, szelesseg, hossz, BackGround, false, 0);
        }

        public override object Update(int x, int y)
        {
            konzolmenu konzolmenu = new konzolmenu();
            konzolmenu.progressBar(x+Rx, y+Ry, szelesseg, hossz, ForeGround, BackGround, miliSec);
            return null;
        }



    }
}
