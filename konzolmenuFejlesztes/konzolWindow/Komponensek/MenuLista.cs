using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konzolmenuFejlesztes.konzolWindow.Komponensek
{
    internal class MenuLista : KonzolKomponens
    {


        //string[] elemek, int x, int y, int szelesseg, int hosszusag,
        //ConsoleColor ForeGround, ConsoleColor BackGround, ConsoleColor Menu, ConsoleColor SelectedMenu,
        //Orientation merre = Orientation.vertical, bool arnyek = false
        public string[] elemek { get; set; }
        public override int Rx { get; set; }
        public override int Ry { get; set; }
        public int szelesseg { get; set; }
        public int hosszusag { get; set; }
        public ConsoleColor ForeGround { get; set; }
        public ConsoleColor BackGround { get; set; }
        public ConsoleColor menu { get; set; }
        public ConsoleColor SelectedMenu { get; set; }
        public Orientation merre { get; set; }
        public bool arnyek { get; set; }

        public MenuLista(string[] elemek, int rx, int ry, int szelesseg, int hosszusag, ConsoleColor foreGround, ConsoleColor backGround, ConsoleColor menu, ConsoleColor selectedMenu, Orientation merre, bool arnyek)
        {
            

            this.elemek = elemek;
            Rx = rx;
            Ry = ry;
            this.szelesseg = szelesseg;
            this.hosszusag = hosszusag;
            ForeGround = foreGround;
            BackGround = backGround;
            this.menu = menu;
            SelectedMenu = selectedMenu;
            this.merre = merre;
            this.arnyek = arnyek;
        }

        public override void Draw(int x, int y)
        {
            konzolmenu konzolmenu = new konzolmenu();
            konzolmenu.Ablak(x+Rx, y+Ry, szelesseg, hosszusag, BackGround, arnyek, 0);
            konzolmenu.MTextBlock(elemek, x+Rx, y+Ry, ForeGround, BackGround);
        }
        public override object Update(int x, int y) 
        {
            konzolmenu konzolmenu = new konzolmenu();
            return konzolmenu.MenuLista(elemek, Rx+x, Ry+y, szelesseg, hosszusag, ForeGround, BackGround, menu, SelectedMenu, merre, arnyek);
        }
        


    }
}
