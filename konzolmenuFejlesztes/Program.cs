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


            Console.SetBufferSize(400, 400);
            Console.SetWindowSize(120, 40);
            Console.Title = "konzol menu teszt";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            List<KonzolKomponens> Komponensek = new List<KonzolKomponens>();
            string[] menupontok = {"Listtest<1>", "Listtest<2>", "Listtest<3>", "Listtest<4>", "Listtest<5>", "Listtest<6>" };
           
            Komponensek.Add(new MenuLista().Contain(menupontok)
                .Position(4, 4).Size(15, 10)
                .Color(ConsoleColor.Black, ConsoleColor.Gray, ConsoleColor.Gray, ConsoleColor.Green)
                .OrientShadow(Orientation.vertical, true).showScroll(true));

            Komponensek.Add(new TextBox().Construct(24, 4, 15, ConsoleColor.Black, ConsoleColor.White, false));//24, 5, 34, 8, ConsoleColor.Black, ConsoleColor.Gray, ConsoleKey.Tab)
            Komponensek.Add(new MTextBox().Construct(24, 6, 34, 8, ConsoleColor.Black, ConsoleColor.Gray, ConsoleKey.Tab));
            Komponensek.Add(new ProgressBar().Construct(4, 16, 55, 2, ConsoleColor.DarkGreen, ConsoleColor.White, 20)) ;
           



            KonzolWindow konzolWindow = new KonzolWindow()
                .Position(20, 15)
                .Size(68, 23)
                .Color(ConsoleColor.White, ConsoleColor.DarkGray)
                .Shadow(true, ConsoleColor.Black, ConsoleColor.DarkBlue, ShadowType.block)
                .Title("Teszt. MTextBoxbol kilepes TAB")
                .Componens(Komponensek);

            



            Console.ReadKey();
            konzolWindow.Draw(20, 15);
            konzolWindow.DrawKomponensek();

            GroupBox groupBoxTest = new GroupBox(Komponensek, "teszt", ConsoleColor.Cyan, ConsoleColor.DarkGray);
            groupBoxTest.Draw(20, 15);








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
