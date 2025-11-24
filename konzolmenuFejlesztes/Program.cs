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
            string[] menupontok = { "Menü teszt", "Menu t 2", "asdasd",  "Kilepes" };
            Komponensek.Add(new MenuLista(menupontok, 2, 3, 10, 10, ConsoleColor.Black, ConsoleColor.Gray, ConsoleColor.Gray, ConsoleColor.Green, Orientation.vertical, true));
            Komponensek.Add(new TextBox(24, 3, 15, ConsoleColor.Black, ConsoleColor.White, false));
            Komponensek.Add(new MTextBox(24, 5, 34, 8, ConsoleColor.Black, ConsoleColor.Gray, ConsoleKey.Tab));
            Komponensek.Add(new ProgressBar(2, 15, 55, 2, ConsoleColor.DarkGreen, ConsoleColor.White, 20)) ;

            //Komponensek.Add(new KonzolWindow(5, 6, 10, 10, ConsoleColor.DarkRed, ConsoleColor.White, true, ConsoleColor.DarkGray, ConsoleColor.Black, "HIBA", '═', true, new List<KonzolKomponens>())) ;
            //KonzolWindow konzolWindow = new KonzolWindow(20, 15, 60, 20, ConsoleColor.DarkGray, ConsoleColor.White, true, ConsoleColor.DarkGray, ConsoleColor.Black,"Teszt. MTextBoxbol kilepes TAB", '═', true, Komponensek);
            
            
            
            
            //----------ez az új változtatás:---------------
            KonzolWindow konzolWindow = new KonzolWindow()
                .Position(20, 15)
                .Size(60, 20)
                .Color(ConsoleColor.White, ConsoleColor.DarkGray)
                .Shadow(true, ConsoleColor.DarkGray, ConsoleColor.Black)
                .Title("Teszt. MTextBoxbol kilepes TAB")
                .Componens(Komponensek);
            konzolWindow.DrawDefault();


            konzolWindow.DrawKomponensek();
            //Console.ReadKey(true);

            //aki ezt a projektet nezi : a kövi pár kommentelt valamit szard le

            //konzolmenu.TextBox(22, 18, 10, ConsoleColor.Black, ConsoleColor.White, false);
            //char[,] asd = konzolmenu.MTextBox(22, 18, 40, 8, ConsoleColor.Black, ConsoleColor.White, ConsoleKey.Tab);

            /*
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < asd.GetLength(0); i++)
            {
                for (int k = 0; k < asd.GetLength(1); k++)
                {
                    Console.Write(asd[i, k]);
                }
                Console.WriteLine();
            }*/


            //ide jön a projekted logikája
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



            /*
                Grid asdasdasd = new Grid(1, 1, 42, 12, 3, 1, Komponensek);
                asdasdasd.Draw(20, 15);
                asdasdasd.Update(20, 15);*/
        }

        
    }
}
