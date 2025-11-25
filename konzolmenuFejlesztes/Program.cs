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
            Console.Title = "konzol menu teszt";

            List<KonzolKomponens> Komponensek = new List<KonzolKomponens>();
            string[] menupontok = {"DKK-101", "DKK-102", "DKK-103", "DKK-104", "DKK-105", "DKK-106" };
            //Komponensek.Add(new MenuLista(menupontok, 2, 3, 10, 10, ConsoleColor.Black, ConsoleColor.Gray, ConsoleColor.Gray, ConsoleColor.Green, Orientation.vertical, true));
            Komponensek.Add(new MenuLista().Contain(menupontok)
                .Position(4, 4).Size(15, 10)
                .Color(ConsoleColor.Black, ConsoleColor.Gray, ConsoleColor.Gray, ConsoleColor.Green)
                .OrientShadow(Orientation.vertical, true).showScroll(true));

            Komponensek.Add(new TextBox().Construct(24, 4, 15, ConsoleColor.Black, ConsoleColor.White, false));//24, 5, 34, 8, ConsoleColor.Black, ConsoleColor.Gray, ConsoleKey.Tab)
            //Komponensek.Add(new MTextBox().Position(24, 5).Size(34, 8).Color(ConsoleColor.Black, ConsoleColor.Gray).ExitB(ConsoleKey.Tab));
            Komponensek.Add(new MTextBox().Construct(24, 6, 34, 8, ConsoleColor.Black, ConsoleColor.Gray, ConsoleKey.Tab));
            Komponensek.Add(new ProgressBar().Construct(4, 16, 55, 2, ConsoleColor.DarkGreen, ConsoleColor.White, 20)) ;

            //Komponensek.Add(new KonzolWindow(5, 6, 10, 10, ConsoleColor.DarkRed, ConsoleColor.White, true, ConsoleColor.DarkGray, ConsoleColor.Black, "HIBA", '═', true, new List<KonzolKomponens>())) ;
            //KonzolWindow konzolWindow = new KonzolWindow(20, 15, 60, 20, ConsoleColor.DarkGray, ConsoleColor.White, true, ConsoleColor.DarkGray, ConsoleColor.Black,"Teszt. MTextBoxbol kilepes TAB", '═', true, Komponensek);
            
            
            
            
            //----------ez az új változtatás:---------------
            KonzolWindow konzolWindow = new KonzolWindow()
                .Position(20, 15)
                .Size(68, 23)
                .Color(ConsoleColor.White, ConsoleColor.DarkGray)
                .Shadow(true, ConsoleColor.DarkGray, ConsoleColor.Black)
                .Title("Teszt. MTextBoxbol kilepes TAB")
                .Componens(Komponensek);
            konzolWindow.DrawDefault();


            konzolWindow.DrawKomponensek();


            /* //(fejlec teszt)
            konzolmenu.Ablak(0, 0, 150, 1, ConsoleColor.Gray, false, 0);
            MenuLista fejlec = new MenuLista().Contain(menupontok)
                .Position(0, 0).Size(10, 10)
                .Color(ConsoleColor.Black, ConsoleColor.Gray, ConsoleColor.Gray, ConsoleColor.Green)
                .OrientShadow(Orientation.horizontal, false);
            fejlec.Draw(0, 0);
            //fejlec.Update(0, 0);
            */

            GroupBox gruppenSex = new GroupBox(Komponensek, "teszt", ConsoleColor.Cyan, ConsoleColor.DarkGray);
            gruppenSex.Draw(20, 15);




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



            /*
                Grid asdasdasd = new Grid(1, 1, 42, 12, 3, 1, Komponensek);
                asdasdasd.Draw(20, 15);
                asdasdasd.Update(20, 15);*/
        }

        
    }
}
