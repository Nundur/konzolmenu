using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace konzolmenuFejlesztes.konzolWindow.Komponensek
{
    class GroupBox : KonzolKomponens
    {
        public override string name { get; set; } = "GroupBox";
        public override int Rx { get; set; } = 0;
        public override int Ry { get; set; } = 0;
        public override string header { get; set; }
        public override int width { get; set; } = 10;
        public override int height { get; set; } = 2;

        public override ConsoleColor ForeGround { get; set; }
        public override ConsoleColor BackGround { get; set; }

        public List<KonzolKomponens> Komponensek { get; set; } = new List<KonzolKomponens>();

        public string title { get; set; }

        public GroupBox(List<KonzolKomponens> komponensek, string title, ConsoleColor foreGround, ConsoleColor backGround)
        {
            Komponensek = komponensek;
            this.title = title;
            ForeGround = foreGround;
            BackGround = backGround;
        }

        private void setCordinates()
        {
            int minX = Komponensek.Min(c => c.Rx);
            int minY = Komponensek.Min(c => c.Ry);

            int maxX = Komponensek.Max(c => c.Rx + c.width);
            int maxY = Komponensek.Max(c => c.Ry + c.height);

            Rx = minX - 1;
            Ry = minY - 1;

            width = (maxX - minX) + 2;
            height = (maxY - minY) + 2;
        }
        public override void Draw(int x, int y)
        {
            setCordinates();
            Console.ForegroundColor = ForeGround; Console.BackgroundColor = BackGround;
            // TOP
            Console.SetCursorPosition(x + Rx, y + Ry);
            Console.Write("┌");
            for (int i = 0; i < width - 2; i++) Console.Write("─");
            Console.Write("┐");

            // MIDDLE
            for (int i = 1; i < height - 1; i++)
            {
                Console.SetCursorPosition(x + Rx, y + Ry + i);
                Console.Write("│");
                Console.SetCursorPosition(x + Rx + width - 1, y + Ry + i);
                Console.Write("│");
            }

            // BOTTOM
            Console.SetCursorPosition(x + Rx, y + Ry + height - 1);
            Console.Write("└");
            for (int i = 0; i < width - 2; i++) Console.Write("─");
            Console.Write("┘");

            // TITLE
            if (!string.IsNullOrEmpty(title))
            {
                Console.SetCursorPosition(x + Rx + 2, y + Ry);
                Console.Write($" {title} ");
            }
        }

        public override object Update(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
