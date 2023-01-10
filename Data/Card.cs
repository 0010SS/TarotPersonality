using System;
namespace TarotPersonality.Data
{
    public class Card  // the class for the each card
    {
        public int id { get; set; }
        public string field { get; set; }
        public string deg { get; set; }
        public bool flipped { get; set; }
        public string pattern { get; set; }
        public string graph { get; set; }
    }
}

