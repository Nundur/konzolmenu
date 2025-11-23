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
            konzolmenu konzolmenu = new konzolmenu();
            Console.SetBufferSize(200, 200);
            Console.SetWindowSize(150, 50);

            List<KonzolKomponens> Komponensek = new List<KonzolKomponens>();
            string[] menupontok = { "Uj fajl", "torles", "Kilepes" };
            Komponensek.Add(new MenuLista(menupontok, 2, 3, 10, 10, ConsoleColor.Black, ConsoleColor.Gray, ConsoleColor.Gray, ConsoleColor.Green, Orientation.vertical, true));
            Komponensek.Add(new TextBox(24, 3, 15, ConsoleColor.Black, ConsoleColor.White, false));
            Komponensek.Add(new ProgressBar(2, 15, 55, 2, ConsoleColor.DarkGreen, ConsoleColor.White, 20)) ;
            
            //Komponensek.Add(new KonzolWindow(5, 6, 10, 10, ConsoleColor.DarkRed, ConsoleColor.White, true, ConsoleColor.DarkGray, ConsoleColor.Black, "HIBA", '═', true, new List<KonzolKomponens>())) ;
            KonzolWindow konzolWindow = new KonzolWindow(20, 15, 60, 20, ConsoleColor.DarkGray, ConsoleColor.White, true, ConsoleColor.DarkGray, ConsoleColor.Black,"Mappa neve és kiterjesztese", '═', true, Komponensek);
            konzolWindow.DrawKomponensek();
            Console.ReadKey(true);
            
            konzolWindow.UpdateKomponensek(() =>
            {
                foreach (var asd in konzolWindow.Komponensek)
                {
                    asd.Update(konzolWindow.x, konzolWindow.y);
                    //és ide jön a logika
                }
            });

            //konzolmenu.progressBar(25, 20, 40, 2, ConsoleColor.DarkGreen, ConsoleColor.White, 100);
            Console.ReadKey();




            Console.ReadKey(true);



            /*
                Grid asdasdasd = new Grid(1, 1, 42, 12, 3, 1, Komponensek);
                asdasdasd.Draw(20, 15);
                asdasdasd.Update(20, 15);*/
        }
    }
}
