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
        //int width, int height,
        //ConsoleColor ForeGround, ConsoleColor BackGround,
        //int miliSec)


        public override string name { get; set; } = "ProgressBar";
        public override string header { get; set; }
        public override int Rx { get; set; } = 0;
        public override int Ry { get; set; } = 0;
        public override int width { get; set; } = 10;
        public override int height { get; set; } = 2;
        public override ConsoleColor ForeGround { get; set; } = ConsoleColor.Green;
        public override ConsoleColor BackGround { get; set; } = ConsoleColor.White;
        public int miliSec { get; set; } = 20;


        public ProgressBar Position(int rx, int ry)
        {
            Rx = rx;
            Ry = ry;
            return this;
        }
        public ProgressBar Size(int Width, int Height)
        {
            this.width = Width;
            this.height = Height;
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

        public ProgressBar Construct(int rx, int ry, int width, int height, ConsoleColor foreGround, ConsoleColor backGround, int miliSec)
        {
            Rx = rx;
            Ry = ry;
            //
            this.width = width;
            this.height = height;
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
            konzolmenu.Ablak(x+Rx, y+Ry, width, height, BackGround, false, 0);
        }

        public override object Update(int x, int y)
        {
            konzolmenu konzolmenu = new konzolmenu();
            konzolmenu.progressBar(x + Rx, y + Ry, width, height, ForeGround, BackGround, miliSec);
            return null;
        }



    }
}
