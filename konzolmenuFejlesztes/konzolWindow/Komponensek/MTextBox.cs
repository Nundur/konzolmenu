using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konzolmenuFejlesztes.konzolWindow.Komponensek
{
    class MTextBox : KonzolKomponens
    {
        //int x, int y, int szelesseg, int hosszusag,
        //ConsoleColor ForeGround, ConsoleColor BackGround,
        //ConsoleKey kilepes


        public override int Rx { get; set; }
        public override int Ry { get; set; }
        public int szelesseg { get; set; }
        public int hosszusag { get; set; }
        public ConsoleColor ForeGround { get; set; }
        public ConsoleColor BackGround { get; set; }
        public ConsoleKey kilepes { get; set; }

        public MTextBox(int rx, int ry, int szelesseg, int hosszusag, ConsoleColor foreGround, ConsoleColor backGround, ConsoleKey kilepes)
        {
            Rx = rx;
            Ry = ry;
            this.szelesseg = szelesseg;
            this.hosszusag = hosszusag;
            ForeGround = foreGround;
            BackGround = backGround;
            this.kilepes = kilepes;
        }

        public override void Draw(int x, int y)
        {
            konzolmenu konzolmenu = new konzolmenu();
            konzolmenu.Ablak(Rx+x, Ry+y, szelesseg, hosszusag, BackGround, false, 0);
        }

        public override object Update(int x, int y)
        {
            konzolmenu konzolmenu = new konzolmenu();
            return konzolmenu.MTextBox(x+Rx, y+Ry, szelesseg, hosszusag, ForeGround, BackGround, kilepes);
        }
    }
}
