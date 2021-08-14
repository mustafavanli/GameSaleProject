using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellProject.Entities
{
    class Game
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public int GameCategory { get; set; }
        public double GamePrice { get; set; }
    }
}
