﻿namespace Pizzaria.Models
{
    public class PizzasModel
    {
        public string? ImageTitle { get; set; }
        public string? PizzaName { get; set; } 
        public float BasePrice { get; set; } = 2;
        public bool TomatoSouce { get; set; }
        public bool Cheese { get; set; }
        public bool Peperoni { get; set; }
        public bool Mushroom { get; set; }
        public bool Tuna { get; set; }
        public bool PineApple { get; set; }
        public bool Ham { get; set; }
        public bool Beef { get; set; }

        public float FinalPrice { get; set; }

    }
}
