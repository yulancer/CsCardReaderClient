﻿namespace CsCardReaderClient.Containers
{
    public class CardTitle
    {
        public string CardName { get; set; }
        public string ImageFileName { get; set; }
        public string ImageFilePath { get; set; }
        public int CardType { get; set; }
        public int Confidence { get; set; }
        public bool Success { get; set; }
    }
}
