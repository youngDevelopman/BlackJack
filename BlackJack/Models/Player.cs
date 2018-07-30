﻿using System.ComponentModel.DataAnnotations;

namespace BlackJack.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
    }
}