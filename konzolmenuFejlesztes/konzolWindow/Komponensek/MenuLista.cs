using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konzolmenuFejlesztes.konzolWindow.Komponensek
{
    internal class MenuLista : KonzolKomponens
    {


        //string[] elemek, int x, int y, int width, int height,
        //ConsoleColor ForeGround, ConsoleColor BackGround, ConsoleColor Menu, ConsoleColor SelectedMenu,
        //Orientation orientation = Orientation.vertical, bool shadowbool = false
        public string[] elemek { get; set; } = new string[0];
        public override int Rx { get; set; } = 0;
        public override int Ry { get; set; } = 0;
        public override int width { get; set; } = 10;
        public override int height { get; set; } = 10;
        public ConsoleColor ForeGround { get; set; } = ConsoleColor.Black;
        public ConsoleColor BackGround { get; set; } = ConsoleColor.Gray;
        public ConsoleColor menu { get; set; } = ConsoleColor.Gray;
        public ConsoleColor SelectedMenu { get; set; } = ConsoleColor.Green;
        public Orientation orientation { get; set; } = Orientation.vertical;
        public bool shadowbool { get; set; } = true;


        public ConsoleColor shadowForeGround { get; set; } = ConsoleColor.Black;

        public ConsoleColor shadowBackGround { get; set; } = ConsoleColor.Gray;
        public ShadowType shadowtype { get; set; } = ShadowType.block;

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
            this.width = Width;
            this.height = Height;
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
        public MenuLista OrientShadow(Orientation orientation, bool shadow /*,ConsoleColor ForeGround, ConsoleColor BackGround, ShadowType shadowtype*/)
        {
            //bool shadow, ConsoleColor ForeGround, ConsoleColor BackGround
            this.orientation = orientation;
            this.shadowbool = shadow;
            this.shadowBackGround = BackGround;
            this.shadowForeGround = ForeGround;
            this.shadowtype = shadowtype;
            return this;
        }
        
        public override void Draw(int x, int y)
        {
            konzolmenu konzolmenu = new konzolmenu();
            if (orientation == Orientation.horizontal)
            {
                int tempSzelesseg = (elemek.OrderByDescending(s => s.Length).First().Length) * elemek.Length;
                konzolmenu.Ablak(x + Rx, y + Ry, tempSzelesseg, 1, BackGround, shadowbool, 0);
                //konzolmenu.KomplexAblak(x + Rx, y + Ry, tempSzelesseg, 1, BackGround, ForeGround, shadowbool, shadowtype, shadowBackGround, shadowForeGround, "", ' ', false);
                //konzolmenu.MTextBlock(elemek, x + Rx, y + Ry, ForeGround, BackGround);
                for (int i = 0; i < elemek.Length; i++)
                {
                    //(i * tempSzelesseg / elemek.Length)
                    konzolmenu.TextBlock(elemek[i], x + Rx + width * i, y + Ry, ForeGround, BackGround);
                }
            } else
            {
                konzolmenu.Ablak(x + Rx, y + Ry, width, height, BackGround, shadowbool, 0);
                //konzolmenu.KomplexAblak(x + Rx, y + Ry, width, height, BackGround, ForeGround, shadowbool, shadowtype, shadowBackGround, shadowForeGround, "", ' ', false);
                
                if (elemek.Length > height)
                {
                    string[] sortedElemek = new string[height];
                    for (int i = 0; i < sortedElemek.Length; i++)//hogy ha hosszabb az elemek tartalma mint a height, ne irja tul
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
            return konzolmenu.MenuLista(elemek, Rx+x, Ry+y, width, height, ForeGround, BackGround, menu, SelectedMenu, orientation, shadowbool, showScrol);
        }
        


    }
}
