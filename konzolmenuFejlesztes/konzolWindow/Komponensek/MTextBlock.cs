using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konzolmenuFejlesztes.konzolWindow.Komponensek
{
    class MTextBlock : KonzolKomponens
    {

        public string[] szoveg { get; set; } = new string[0];
        public override int Rx { get; set; } = 0;
        public override int Ry { get; set; } = 0;
        public ConsoleColor ForeGround { get; set; } = ConsoleColor.Black;
        public ConsoleColor BackGround { get; set; } = ConsoleColor.Gray;

        public MTextBlock Text(string[] szoveg)
        {
            this.szoveg = szoveg;
            return this;
        }
        public MTextBlock Position(int rx, int ry)
        {
            Rx = rx;
            Ry = ry;
            return this;
        }
        public MTextBlock Color(ConsoleColor ForeGround, ConsoleColor BackGround)
        {
            this.ForeGround = ForeGround;
            this.BackGround = BackGround;
            return this;
        }
        
        public MTextBlock Construct(string[] szoveg, int rx, int ry, ConsoleColor foreGround, ConsoleColor backGround)
        {
            this.szoveg = szoveg;
            //
            Rx = rx;
            Ry = ry;
            //
            ForeGround = foreGround;
            BackGround = backGround;
            return this;
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
