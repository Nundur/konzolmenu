using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konzolmenuFejlesztes.konzolWindow.Komponensek
{
    class MTextBlock : KonzolKomponens
    {

        public override string name { get; set; } = "MTextBlock";
        public string[] text { get; set; } = new string[0];
        public override string header { get; set; }
        public override int Rx { get; set; } = 0;
        public override int Ry { get; set; } = 0;

        public override ConsoleColor ForeGround { get; set; } = ConsoleColor.Black;
        public override ConsoleColor BackGround { get; set; } = ConsoleColor.Gray;

        //nincsenek hasznalva (MÉG)
        public override int width { get; set; } = 10;
        public override int height { get; set; } = 2;

        public MTextBlock Text(string[] text)
        {
            this.text = text;
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

        public MTextBlock Construct(string[] text, int rx, int ry, ConsoleColor foreGround, ConsoleColor backGround)
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
            konzolmenu.MTextBlock(text, x + Rx, y + Ry, ForeGround, BackGround);
        }

        public override object Update(int x, int y)
        {
            Draw(x, y);
            return null;
        }
    }
}
