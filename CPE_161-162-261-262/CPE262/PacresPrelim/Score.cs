using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacresPrelim
{
    public class Score
    {
        public string PlayerName { get; set; }
        public int TimeInSeconds { get; set; }
        public int Moves { get; set; }
        public int GridSize { get; set; }
        public Score (string playername, int timeinseconds, int moves, int gridsize)
        {
            PlayerName = playername;
            TimeInSeconds = timeinseconds;
            Moves = moves;
            GridSize = gridsize;
        }
    }
}
