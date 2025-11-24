using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konzolmenuFejlesztes.konzolWindow.Komponensek
{
    class MTextBlock : KonzolKomponens
    {

        public string[] szoveg { get; set; }
        public override int Rx { get; set; }
        public override int Ry { get; set; }
        public ConsoleColor ForeGround { get; set; }
        public ConsoleColor BackGround { get; set; }

        public MTextBlock(string[] szoveg, int rx, int ry, ConsoleColor foreGround, ConsoleColor backGround)
        {
            this.szoveg = szoveg;
            Rx = rx;
            Ry = ry;
            ForeGround = foreGround;
            BackGround = backGround;
        }

        public override void Draw(int x, int y)
        {
            konzolmenu konzolmenu = new konzolmenu();
            konzolmenu.MTextBlock(szoveg, x+Rx, y+Ry, ForeGround, BackGround);
        }

        public override object Update(int x, int y)
        {
            Draw(x, y);
            return null;
        }
    }
}
