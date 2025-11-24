using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konzolmenuFejlesztes.konzolWindow
{
    class KonzolWindow
    {
        //int x, int y, int szelesseg, int hosszusag, ConsoleColor hatterSzin,
        //ConsoleColor betuSzin, bool arnyek,
        //ConsoleColor arnyekSzin, ConsoleColor arnyekHatterSzin,
        //string cim, char cimVonal, bool szegely


        public int x { get; set; }
        public int y { get; set; }
        public int szelesseg { get; set; }
        public int hosszusag { get; set; }
        public ConsoleColor hatterSzin { get; set; } = ConsoleColor.Green;
        public ConsoleColor betuSzin { get; set; } = ConsoleColor.White;
        public bool arnyek { get; set; } = true;
        public ConsoleColor arnyekSzin { get; set; } = ConsoleColor.DarkGray;
        public ConsoleColor arnyekHatterSzin { get; set; } = ConsoleColor.Black;
        public string cim { get; set; } = "title";
        public char cimVonal { get; set; } = '═';
        public bool szegely { get; set; } = true;


        //proba:
        public KonzolWindow Position(int x, int y)
        {
            this.x = x;
            this.y = y;
            return this;
        }
        public KonzolWindow Size(int Width, int Height)
        {
            this.szelesseg = Width;
            this.hosszusag = Height;
            return this;
        }
        public KonzolWindow Color(ConsoleColor ForeGround, ConsoleColor BackGround)
        {
            this.betuSzin = ForeGround;
            this.hatterSzin = BackGround;
            return this;
        }
        public KonzolWindow Shadow(bool shadow, ConsoleColor ForeGround, ConsoleColor BackGround)
        {
            this.arnyek = shadow;
            this.arnyekSzin = ForeGround;
            this.arnyekHatterSzin = BackGround;
            return this;
        }
        public KonzolWindow Title(string title, char titleLine = '═', bool border = true)
        {
            this.cim = title;
            this.cimVonal = titleLine;
            this.szegely = border;
            return this;
        }
        public KonzolWindow Componens(List<KonzolKomponens> Componens)
        {
            this.Komponensek = Componens;
            return this;
        }

        public List<KonzolKomponens> Komponensek { get; set; }

        /*
        public KonzolWindow(int x, int y, int szelesseg, int hosszusag, ConsoleColor hatterSzin, ConsoleColor betuSzin, bool arnyek, ConsoleColor arnyekSzin, ConsoleColor arnyekHatterSzin, string cim, char cimVonal, bool szegely, List<KonzolKomponens> Komponensek)
        {
            konzolmenu konzolmenu = new konzolmenu();
            //
            this.x = x;
            this.y = y;
            //
            this.szelesseg = szelesseg;
            this.hosszusag = hosszusag;
            //
            this.hatterSzin = hatterSzin;
            this.betuSzin = betuSzin;
            //
            this.arnyek = arnyek;
            this.arnyekSzin = arnyekSzin;
            this.arnyekHatterSzin = arnyekHatterSzin;
            //
            this.cim = cim;
            this.cimVonal = cimVonal;
            this.szegely = szegely;
            //
            this.Komponensek = Komponensek;

            DrawDefault();
        }
        */
        public void DrawDefault()
        {
            konzolmenu konzolmenu = new konzolmenu();
            konzolmenu.KomplexAblak(x, y, szelesseg, hosszusag, hatterSzin, betuSzin, arnyek, arnyekSzin, arnyekHatterSzin, cim, cimVonal, szegely);
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
