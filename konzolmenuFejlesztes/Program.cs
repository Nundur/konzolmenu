using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using konzolmenuFejlesztes.konzolWindow;
using konzolmenuFejlesztes.konzolWindow.Komponensek;

namespace konzolmenuFejlesztes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bemutató program:
            //-----------------
            //a lényeg hogy az összes függvény és metódus ami grafikusan megjelenít dolgokat a konzolon a
            //konzolmenu.cs-ben található. A Komponensek mappában lévő classok csak az egyszerűség kedvéért
            //vannak mert objektum orientáltan sokkal egyszerűbb használni mint egyesével beírni egy ablak
            //tulajdonságait:)

            //és az összes komponens örököl egy abstract class-t amit a KonzolKomponens.cs
            //ez adja meg hogy egy komponensnek milyen tulajdonságai legyen (relatív pozíció, szín, stb..)
            //ezt azért csináltam hogy legyen olyan mint például a GroupBox, ami bekér egy KonzolKomponens listát
            //és rajzol köréjük egy boxot. De több mindenre is lehet még használni.

            //mellesleg minden KonzolKomponens-nek van egy Draw() és egy Update() függvénye.
            //a Draw az csak simán kiraljzolja magát a komponenst, az update pedig le is futtatja (például
            //egy listánál a választás a nyilakkal)



            
            //itt példányosítom a konzolmenu-t hogy később ha kell, tudjam használni
            konzolmenu konzolmenu = new konzolmenu();

            //itt beállítok alap console Window dolgokat, ez nem a framework része
            Console.SetBufferSize(400, 400);
            Console.SetWindowSize(120, 40);
            Console.Title = "konzol menu teszt";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();



            //itt kozom létre a KonzolKomponensek listát
            List<KonzolKomponens> Komponensek = new List<KonzolKomponens>();


            //itt hozzá adok egy egyszerű MenuList-át
            string[] menupontok = {"Listtest<1>", "Listtest<2>", "Listtest<3>", "Listtest<4>", "Listtest<5>", "Listtest<6>" };
            //(a menu lista úgy mködik hogy vár egy string[] tömböt , aminek kijelzi a tartalmait)
            Komponensek.Add(new MenuLista().Contain(menupontok)
                .Position(4, 4).Size(15, 10)
                .Color(ConsoleColor.Black, ConsoleColor.Gray, ConsoleColor.Gray, ConsoleColor.Green)
                .OrientShadow(Orientation.vertical, true).showScroll(true));


            //itt hozzá adom a komponensek lista többi tartalmait amit szeretném hogy kijelezzen, vagy tartalmazzon a grafikus alkalmazásom
            Komponensek.Add(new TextBox().Construct(24, 4, 15, ConsoleColor.Black, ConsoleColor.White, false));//24, 5, 34, 8, ConsoleColor.Black, ConsoleColor.Gray, ConsoleKey.Tab)
            Komponensek.Add(new MTextBox().Construct(24, 6, 34, 8, ConsoleColor.Black, ConsoleColor.Gray, ConsoleKey.Tab));
            Komponensek.Add(new ProgressBar().Construct(4, 16, 55, 2, ConsoleColor.DarkGreen, ConsoleColor.White, 20)) ;
           


            //itt pedig létrehozom a KonzolWindow-ot ami röviden egy ablak. És beletöltöm a komponenseket
            KonzolWindow konzolWindow = new KonzolWindow()
                .Position(20, 15)
                .Size(68, 23)
                .Color(ConsoleColor.White, ConsoleColor.DarkGray)
                .Shadow(true, ConsoleColor.Black, ConsoleColor.DarkBlue, ShadowType.block)
                .Title("Teszt. MTextBoxbol kilepes TAB")
                .Componens(Komponensek);

            


            //itt van egy kis váratás

            Console.ReadKey();
            //itt a konzolwindow Draw függvényével megjelenítem a konzolWindow ablakot.
            konzolWindow.Draw(20, 15);
            //ezzel pedig csak a beletöltött komponenseket jelenítem meg
            konzolWindow.DrawKomponensek();


            //ez pedig az előbb említett group box-om. Még teszt fázisban van, de működő képes rendesen:)
            //ugyan úgy, vár egy konzolKomponens listát, ami köré tud rajzolni egy dobozt.
            GroupBox groupBoxTest = new GroupBox(Komponensek, "teszt", ConsoleColor.Cyan, ConsoleColor.DarkGray);
            groupBoxTest.Draw(20, 15);





            //itt pedig egyesével updatelem a komponenseket.


            //ide jön a projekted logikája
            konzolWindow.UpdateKomponensek(() =>
            {
                foreach (var asd in konzolWindow.Komponensek)
                {
                    asd.Update(konzolWindow.x, konzolWindow.y);
                    //és ide jön a logika
                }
            });




            Console.ReadKey();

            //vége:)
            //jöhet a teszt




            //ennyi lett volna. Fel lett töltve githubra is:)

        }

        
    }
}
