using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konzolmenuFejlesztes.konzolWindow.Komponensek
{
    class TextBlock : KonzolKomponens
    {
        //string text, int x, int y, ConsoleColor ForeGround, ConsoleColor BackGround
        public string text { get; set; } = "betmen";
        public override int Rx { get; set; } = 0;
        public override int Ry { get; set; } = 0;
        public ConsoleColor ForeGround { get; set; } = ConsoleColor.Black;
        public ConsoleColor BackGround { get; set; } = ConsoleColor.White;


        public override int width { get; set; } = 10;
        public override int height { get; set; } = 10;

        public TextBlock Text(string text)
        {
            this.text = text;
            return this;
        }
        public TextBlock Position(int rx, int ry)
        {
            Rx = rx;
            Ry = ry;
            return this;
        }
        public TextBlock Color(ConsoleColor ForeGround, ConsoleColor BackGround)
        {
            this.ForeGround = ForeGround;
            this.BackGround = BackGround;
            return this;
        }


        public TextBlock Construct(string text, int rx, int ry, ConsoleColor foreGround, ConsoleColor backGround)
        {
            this.text = text;
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
            konzolmenu.TextBlock(text, x+Rx, y+Ry, ForeGround, BackGround);
        }
        public override object Update(int x, int y)
        {
            Draw(x, y);
            return null;
        }

    }
}
