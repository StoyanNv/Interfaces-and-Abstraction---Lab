﻿namespace HTTPServer.GameStore.Models
{
    using System.Collections.Generic;

    public class ShoppingCart
    {
        public const string SessionKey = "%^Current_Shopping_Cart^%";

        public List<Game> Orders { get; private set; } = new List<Game>();
    }
}