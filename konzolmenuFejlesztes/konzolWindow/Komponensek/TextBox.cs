using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konzolmenuFejlesztes.konzolWindow.Komponensek
{
    internal class TextBox : KonzolKomponens
    {
        //int x, int y, int hossz, ConsoleColor ForeGround, ConsoleColor BackGround, bool passProtected


        public override int Rx { get; set; } = 0;
        public override int Ry { get; set; } = 0;
        public int hossz { get; set; } = 10;
        public ConsoleColor ForeGround { get; set; } = ConsoleColor.Black;
        public ConsoleColor BackGround { get; set; } = ConsoleColor.White;
        public bool passProtected { get; set; } = false;

        public TextBox(int x, int y, int hossz, ConsoleColor foreGround, ConsoleColor backGround, bool passProtected)
        {
            this.Rx = x;
            this.Ry = y;
            this.hossz = hossz;
            ForeGround = foreGround;
            BackGround = backGround;
            this.passProtected = passProtected;
        }

        public override void Draw(int x, int y) 
        {
            konzolmenu konzolmenu = new konzolmenu();
            konzolmenu.Line(' ', hossz, x+Rx, y+Ry, Orientation.horizontal, ForeGround, BackGround);
        }
        public override object Update(int x, int y)
        {
            konzolmenu konzolmenu = new konzolmenu();

            
            return konzolmenu.TextBox(x + Rx, y + Ry, hossz, ForeGround, BackGround, passProtected); ;
        }


    }
}
