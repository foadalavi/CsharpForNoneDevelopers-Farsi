using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    class Mine
    {
        public Button MineButton { get; set; }
        public Label MineLabel { get; set; }
        public bool IsMine { get; set; }
        public int CountNighbourMines { get; internal set; }
        public bool HasChecked { get; internal set; }
        public bool HasFlag { get; internal set; }
    }
}
