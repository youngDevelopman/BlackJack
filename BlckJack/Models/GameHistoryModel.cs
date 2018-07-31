using BlckJack.GameLogic;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlckJack.Models
{
    public class GameHistoryModel
    {
        [Key]
        public int GameId { get; set; }
        public int WinnerId { get; set; }

        public string WinnerName { get; set; }
        public int WinnerCount { get; set; }

        public List<Player> Players { get; set; }
    }
}
