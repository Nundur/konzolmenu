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


        public override int Rx { get; set; } = 0;
        public override int Ry { get; set; } = 0;
        public int szelesseg { get; set; } = 10;
        public int hosszusag { get; set; } = 10;
        public ConsoleColor ForeGround { get; set; } = ConsoleColor.Black;
        public ConsoleColor BackGround { get; set; } = ConsoleColor.White;
        public ConsoleKey kilepes { get; set; } = ConsoleKey.Tab;

        
        public MTextBox Position(int rx, int ry)
        {
            Rx = rx;
            Ry = ry;
            return this;
        }
        public MTextBox Size(int Width, int Height)
        {
            this.szelesseg = Width;
            this.hosszusag = Height;
            return this;
        }
        public MTextBox Color(ConsoleColor ForeGround, ConsoleColor BackGround)
        {
            this.ForeGround = ForeGround;
            this.BackGround = BackGround;
            return this;
        }
        public MTextBox ExitB(ConsoleKey kilepes)
        {
            this.kilepes = kilepes;
            return this;
        }

        public MTextBox Construct(int rx, int ry, int szelesseg, int hosszusag, ConsoleColor foreGround, ConsoleColor backGround, ConsoleKey kilepes)
        {
            Rx = rx;
            Ry = ry;
            this.szelesseg = szelesseg;
            this.hosszusag = hosszusag;
            ForeGround = foreGround;
            BackGround = backGround;
            this.kilepes = kilepes;
            return this;
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
