using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konzolmenuFejlesztes.konzolWindow.Komponensek
{
    class Grid : KonzolKomponens
    {
        public override int Rx { get; set; }
        public override int Ry { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }

        public int Columns { get; set; }
        public int Rows { get; set; }

        public List<KonzolKomponens> Children { get; set; }

        public Grid(int x, int y, int width, int height, int columns, int rows, List<KonzolKomponens> Childreen)
        {
            Rx = x;
            Ry = y;
            Width = width;
            Height = height;
            Columns = columns;
            Rows = rows;
            Children = Childreen;
        }

        public void Add(KonzolKomponens comp)
        {
            Children.Add(comp);
        }

        public override void Draw(int px, int py)
        {
            int cellW = Width / Columns;
            int cellH = Height / Rows;

            for (int i = 0; i < Children.Count; i++)
            {
                int col = i % Columns;
                int row = i / Columns;

                int childX = px + Rx + col * cellW;
                int childY = py + Ry + row * cellH;

                Children[i].Draw(childX, childY);
            }
        }

        public override object Update(int px, int py)
        {
            int cellW = Width / Columns;
            int cellH = Height / Rows;

            object lastResult = null;

            for (int i = 0; i < Children.Count; i++)
            {
                int col = i % Columns;
                int row = i / Columns;

                int childX = px + Rx + col * cellW;
                int childY = py + Ry + row * cellH;

                lastResult = Children[i].Update(childX, childY);
            }

            return lastResult;
        }
    }
}
