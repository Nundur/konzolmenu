using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konzolmenuFejlesztes.konzolWindow
{
    class KonzolWindow : KonzolKomponens
    {

        public override string name { get; set; } = "KonzolWindow";
        //int x, int y, int width, int height, ConsoleColor BackGround,
        //ConsoleColor ForeGround, bool arnyek,
        //ConsoleColor arnyekSzin, ConsoleColor arnyekBackGround,
        //string cim, char cimVonal, bool szegely


        public int x { get; set; } = 1;
        public int y { get; set; } = 1;

        public override int Rx { get; set; } = 1;
        public override int Ry { get; set; } = 1;

        public override int width { get; set; } = 20;
        public override int height { get; set; } = 20;
        public override ConsoleColor BackGround { get; set; } = ConsoleColor.Green;
        public override ConsoleColor ForeGround { get; set; } = ConsoleColor.White;
        public bool arnyek { get; set; } = true;
        public ShadowType shadowtype { get; set; } = ShadowType.faded;
        public ConsoleColor arnyekSzin { get; set; } = ConsoleColor.DarkGray;
        public ConsoleColor arnyekBackGround { get; set; } = ConsoleColor.Black;
        public override string header { get; set; } = "title";
        public char cimVonal { get; set; } = '═';
        public bool szegely { get; set; } = true;

        public TitleType TitleTypee { get; set; }
        public List<KonzolKomponens> Komponensek { get; set; } = new List<KonzolKomponens>();

        //proba:
        public KonzolWindow Position(int x, int y)
        {
            this.x = x;
            this.y = y;
            return this;
        }
        public KonzolWindow Size(int Width, int Height)
        {
            this.width = Width;
            this.height = Height;
            return this;
        }
        public KonzolWindow Color(ConsoleColor ForeGround, ConsoleColor BackGround)
        {
            this.ForeGround = ForeGround;
            this.BackGround = BackGround;
            return this;
        }
        public KonzolWindow Shadow(bool shadow, ConsoleColor ForeGround, ConsoleColor BackGround, ShadowType shadowtype)
        {
            this.shadowtype = shadowtype;
            this.arnyek = shadow;
            this.arnyekSzin = ForeGround;
            this.arnyekBackGround = BackGround;
            return this;
        }
        public KonzolWindow Title(string title, TitleType titleTypee = TitleType.inWindow, char titleLine = '═', bool border = true)
        {
            this.header = title;
            this.TitleTypee = titleTypee;
            this.cimVonal = titleLine;
            this.szegely = border;
            return this;
        }
        public KonzolWindow Componens(List<KonzolKomponens> Componens)
        {
            this.Komponensek = Componens;
            return this;
        }

        // ha valaki hülyegyerek és egybe akar egy konstruktort
        public KonzolWindow Construct(int x, int y, int width, int height, ConsoleColor BackGround, ConsoleColor ForeGround, bool arnyek, ShadowType shadowtype, ConsoleColor arnyekSzin, ConsoleColor arnyekBackGround, string cim, char cimVonal, bool szegely, TitleType titleType, List<KonzolKomponens> komponensek)
        {
            this.shadowtype = shadowtype;
            this.Rx = x;
            this.Ry = y;
            this.width = width;
            this.height = height;
            this.BackGround = BackGround;
            this.ForeGround = ForeGround;
            this.arnyek = arnyek;
            this.arnyekSzin = arnyekSzin;
            this.arnyekBackGround = arnyekBackGround;
            this.header = cim;
            this.cimVonal = cimVonal;
            this.szegely = szegely;
            Komponensek = komponensek;
            this.TitleTypee = titleType;
            return this;
        }

        public override void Draw(int x, int y)
        {
            konzolmenu konzolmenu = new konzolmenu();
            konzolmenu.KomplexAblak(x, y, width, height, BackGround, ForeGround, arnyek, shadowtype, arnyekSzin, arnyekBackGround, header, cimVonal, szegely, TitleTypee);
        }
        public override object Update(int x, int y)
        {
            konzolmenu konzolmenu = new konzolmenu();
            konzolmenu.KomplexAblak(x + Rx, y + Ry, width, height, BackGround, ForeGround, arnyek, shadowtype, arnyekSzin, arnyekBackGround, header, cimVonal, szegely, TitleTypee);
            return "";
        }

        public void DrawKomponensek()
        {
            foreach (var asd in Komponensek)
            {
                asd.Draw(x, y);
            }
        }

        public void UpdateKomponensek(Action logika)
        {
            logika.Invoke();
        }

    }
}
