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



        public override int Rx { get; set; } = 0;
        public override int Ry { get; set; } = 0;
        public int szelesseg { get; set; } = 10;
        public int hossz { get; set; } = 2;
        public ConsoleColor ForeGround { get; set; } = ConsoleColor.Green;
        public ConsoleColor BackGround { get; set; } = ConsoleColor.White;
        public int miliSec { get; set; } = 20;


        public ProgressBar Position(int rx, int ry)
        {
            Rx = rx;
            Ry = ry;
            return this;
        }
        public ProgressBar Size(int Width, int Height)
        {
            this.szelesseg = Width;
            this.hossz = Height;
            return this;
        }
        public ProgressBar Color(ConsoleColor ForeGround, ConsoleColor BackGround)
        {
            this.ForeGround = ForeGround;
            this.BackGround = BackGround;
            return this;
        }
        public ProgressBar MiliSec(int miliSec)
        {
            this.miliSec = miliSec;
            return this;
        }

        public ProgressBar Construct(int rx, int ry, int szelesseg, int hossz, ConsoleColor foreGround, ConsoleColor backGround, int miliSec)
        {
            Rx = rx;
            Ry = ry;
            //
            this.szelesseg = szelesseg;
            this.hossz = hossz;
            //
            ForeGround = foreGround;
            BackGround = backGround;
            //
            this.miliSec = miliSec;
            return this;
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
