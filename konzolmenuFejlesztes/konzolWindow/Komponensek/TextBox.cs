using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konzolmenuFejlesztes.konzolWindow.Komponensek
{
    internal class TextBox : KonzolKomponens
    {
        //int x, int y, int Width, ConsoleColor ForeGround, ConsoleColor BackGround, bool passProtected


        public override string name { get; set; } = "TextBox";
        public override string header { get; set; }
        public override int Rx { get; set; } = 0;
        public override int Ry { get; set; } = 0;
        public override int width { get; set; } = 10;
        public override int height { get; set; } = 1;
        public override ConsoleColor ForeGround { get; set; } = ConsoleColor.Black;
        public override ConsoleColor BackGround { get; set; } = ConsoleColor.White;
        public bool passProtected { get; set; } = false;


        public TextBox SetWidth(int Width)
        {
            this.width = Width;
            return this;
        }
        public TextBox Position(int rx, int ry)
        {
            Rx = rx;
            Ry = ry;
            return this;
        }
        public TextBox Color(ConsoleColor ForeGround, ConsoleColor BackGround)
        {
            this.ForeGround = ForeGround;
            this.BackGround = BackGround;
            return this;
        }
        public TextBox PassProtect(bool passProtected)
        {
            this.passProtected = passProtected;
            return this;
        }
        public TextBox Construct(int x, int y, int Width, ConsoleColor foreGround, ConsoleColor backGround, bool passProtected)
        {
            this.Rx = x;
            this.Ry = y;
            //
            this.width = Width;
            //
            ForeGround = foreGround;
            BackGround = backGround;
            //
            this.passProtected = passProtected;
            return this;
        }

        public override void Draw(int x, int y)
        {
            konzolmenu konzolmenu = new konzolmenu();
            konzolmenu.Line(' ', width, x+Rx, y+Ry, Orientation.horizontal, ForeGround, BackGround);
        }
        public override object Update(int x, int y)
        {
            konzolmenu konzolmenu = new konzolmenu();


            return konzolmenu.TextBox(x + Rx, y + Ry, width, ForeGround, BackGround, passProtected); ;
        }


    }
}
