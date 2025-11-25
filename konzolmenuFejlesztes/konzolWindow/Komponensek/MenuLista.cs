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
        public string[] elemek { get; set; } = new string[0];
        public override int Rx { get; set; } = 0;
        public override int Ry { get; set; } = 0;
        public int szelesseg { get; set; } = 10;
        public int hosszusag { get; set; } = 10;
        public ConsoleColor ForeGround { get; set; } = ConsoleColor.Black;
        public ConsoleColor BackGround { get; set; } = ConsoleColor.Gray;
        public ConsoleColor menu { get; set; } = ConsoleColor.Gray;
        public ConsoleColor SelectedMenu { get; set; } = ConsoleColor.Green;
        public Orientation merre { get; set; } = Orientation.vertical;
        public bool arnyek { get; set; } = true;

        public bool showScrol { get; set; } = false;
        public MenuLista Contain(string[] elemek)
        {
            this.elemek = elemek;
            return this;
        }
        public MenuLista Position(int rx, int ry)
        {
            Rx = rx;
            Ry = ry;
            return this;
        }
        public MenuLista Size(int Width, int Height)
        {
            this.szelesseg = Width;
            this.hosszusag = Height;
            return this;
        }
        public MenuLista Color(ConsoleColor ForeGround, ConsoleColor BackGround, ConsoleColor menu, ConsoleColor selectedMenu)
        {
            this.ForeGround = ForeGround;
            this.BackGround = BackGround;
            this.menu = menu;
            SelectedMenu = selectedMenu;
            return this;
        }
        public MenuLista showScroll(bool showScroll)
        {
            //bool shadow, ConsoleColor ForeGround, ConsoleColor BackGround
            this.showScrol = showScroll;
            return this;
        }
        public MenuLista OrientShadow(Orientation merre, bool shadow)
        {
            //bool shadow, ConsoleColor ForeGround, ConsoleColor BackGround
            this.merre = merre;
            this.arnyek = shadow;
            return this;
        }
        
        public override void Draw(int x, int y)
        {
            konzolmenu konzolmenu = new konzolmenu();
            if (merre == Orientation.horizontal)
            {
                int tempSzelesseg = (elemek.OrderByDescending(s => s.Length).First().Length) * elemek.Length;
                konzolmenu.Ablak(x + Rx, y + Ry, tempSzelesseg, 1, BackGround, arnyek, 0);
                //konzolmenu.MTextBlock(elemek, x + Rx, y + Ry, ForeGround, BackGround);
                for (int i = 0; i < elemek.Length; i++)
                {
                    konzolmenu.TextBlock(elemek[i], x+Rx + (i * tempSzelesseg/elemek.Length), y+Ry, ForeGround, BackGround);
                }
            } else
            {
                konzolmenu.Ablak(x + Rx, y + Ry, szelesseg, hosszusag, BackGround, arnyek, 0);
                if (elemek.Length > hosszusag)
                {
                    string[] sortedElemek = new string[hosszusag];
                    for (int i = 0; i < sortedElemek.Length; i++)//hogy ha hosszabb az elemek tartalma mint a hosszusag, ne irja tul
                    {
                        sortedElemek[i] = elemek[i];
                    }
                    konzolmenu.MTextBlock(sortedElemek, x + Rx, y + Ry, ForeGround, BackGround);
                } else konzolmenu.MTextBlock(elemek, x + Rx, y + Ry, ForeGround, BackGround);
                
               // konzolmenu.MTextBlock(sortedElemek, x + Rx, y + Ry, ForeGround, BackGround);
            }
            
        }
        public override object Update(int x, int y) 
        {
            konzolmenu konzolmenu = new konzolmenu();
            return konzolmenu.MenuLista(elemek, Rx+x, Ry+y, szelesseg, hosszusag, ForeGround, BackGround, menu, SelectedMenu, merre, arnyek, showScrol);
        }
        


    }
}
