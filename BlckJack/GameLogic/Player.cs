using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;

namespace BlckJack.GameLogic
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
    }
}
