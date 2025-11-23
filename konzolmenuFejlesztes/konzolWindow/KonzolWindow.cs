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


        public int x{ get; set; }
        public int y{ get; set; }
        public int szelesseg{ get; set; }
        public int hosszusag{ get; set; }
        public ConsoleColor hatterSzin{ get; set; }
        public ConsoleColor betuSzin{ get; set; }
        public bool arnyek{ get; set; }
        public ConsoleColor arnyekSzin{ get; set; }
        public ConsoleColor arnyekHatterSzin{ get; set; }
        public string cim{ get; set; }
        public char cimVonal{ get; set; }
        public bool szegely{ get; set; }

        public List<KonzolKomponens> Komponensek{ get; set; }


        public KonzolWindow(int x, int y, int szelesseg, int hosszusag, ConsoleColor hatterSzin, ConsoleColor betuSzin, bool arnyek, ConsoleColor arnyekSzin, ConsoleColor arnyekHatterSzin, string cim, char cimVonal, bool szegely, List<KonzolKomponens> Komponensek)
        {
            konzolmenu konzolmenu = new konzolmenu();
            this.x = x;
            this.y = y;
            this.szelesseg = szelesseg;
            this.hosszusag = hosszusag;
            this.hatterSzin = hatterSzin;
            this.betuSzin = betuSzin;
            this.arnyek = arnyek;
            this.arnyekSzin = arnyekSzin;
            this.arnyekHatterSzin = arnyekHatterSzin;
            this.cim = cim;
            this.cimVonal = cimVonal;
            this.szegely = szegely;
            this.Komponensek = Komponensek;

            DrawDefault();
        }

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
