using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace konzolmenuFejlesztes.konzolWindow.Komponensek
{
    class Line : KonzolKomponens
    {
        public override string name { get; set; } = "Line";
        public override int Rx { get; set; } = 0;
        public override int Ry { get; set; } = 0;
        public override string header { get; set; }
        public override int width { get; set; } = 1;
        public override int height { get; set; } = 10;
        public Orientation merre { get; set; }
        public char mibolxd { get; set; }
        public override ConsoleColor ForeGround { get; set; }
        public override ConsoleColor BackGround { get; set; }

        public List<KonzolKomponens> Komponensek { get; set; } = new List<KonzolKomponens>();

        public string title { get; set; }

        //char mibolxd, int hossz, int x, int y, Orientation merre, ConsoleColor ForeGround, ConsoleColor BackGround

        public Line Construct(char mibolxd = '-', int hossz = 20, int x = 2, int y = 2, Orientation merre = Orientation.horizontal, ConsoleColor ForeGround = ConsoleColor.Black, ConsoleColor BackGround = ConsoleColor.White)
        {
            this.mibolxd = mibolxd;
            this.width = hossz;
            this.Rx = x;
            this.Ry = y;
            this.merre = merre;
            this.ForeGround = ForeGround;
            this.BackGround = BackGround;
            return this;
        }
        //asd

        public Line Char(char asd)
        {
            this.mibolxd = asd;
            return this;
        }
        public Line Position(int x, int y)
        {
            this.Rx = x;
            this.Ry = y;
            return this;
        }
        public Line Size(int Width, int Height)
        {
            this.width = Width;
            this.height = Height;
            return this;
        }
        public Line Color(ConsoleColor ForeGround, ConsoleColor BackGround)
        {
            this.ForeGround = ForeGround;
            this.BackGround = BackGround;
            return this;
        }

        public Line Componens(List<KonzolKomponens> Componens)
        {
            this.Komponensek = Componens;
            return this;
        }
        //asd


        public override void Draw(int x, int y)
        {
            konzolmenu konzolmenu = new konzolmenu();
            konzolmenu.Line(mibolxd, height, x+Rx, y+Ry, merre, ForeGround, BackGround);
        }

        public override object Update(int x, int y)
        {
            konzolmenu konzolmenu = new konzolmenu();
            konzolmenu.Line(mibolxd, height, x+Rx, y+Ry, merre, ForeGround, BackGround);
            return "";
        }
    }
}
