using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzaria.Models;

namespace Pizzaria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDb = new List<PizzasModel>()
        {
            new PizzasModel() {ImageTitle="BBQ Chicken", PizzaName="BBQ Chicken", BasePrice=2, TomatoSouce = true, Cheese=true, Peperoni = false, Mushroom = true, Tuna= false, PineApple= false, Ham=true, Beef= true, FinalPrice=4},
            new PizzasModel() {ImageTitle="Buffalo Pizza", PizzaName="Buffalo Pizza", BasePrice=2, TomatoSouce = true, Cheese=true, Peperoni = false, Mushroom = true, Tuna= false, PineApple= false, Ham=true, Beef= true, FinalPrice=4},
            new PizzasModel() {ImageTitle="CheesePizza", PizzaName="Cheese Pizza", BasePrice=2, TomatoSouce = true, Cheese=true, Peperoni = false, Mushroom = true, Tuna= false, PineApple= false, Ham=true, Beef= true, FinalPrice=4},
            new PizzasModel() {ImageTitle="Hawaiian Pizza", PizzaName="Hawaiian Pizza", BasePrice=2, TomatoSouce = true, Cheese=true, Peperoni = false, Mushroom = true, Tuna= false, PineApple= false, Ham=true, Beef= true, FinalPrice=4},
            new PizzasModel() {ImageTitle="Margherita Pizza", PizzaName="Margherita Pizza", BasePrice=2, TomatoSouce = true, Cheese=true, Peperoni = false, Mushroom = true, Tuna= false, PineApple= false, Ham=true, Beef= true, FinalPrice=4},
            new PizzasModel() {ImageTitle="Margherita Special", PizzaName="Margherita Special", BasePrice=2, TomatoSouce = true, Cheese=true, Peperoni = false, Mushroom = true, Tuna= false, PineApple= false, Ham=true, Beef= true, FinalPrice=4},
            new PizzasModel() {ImageTitle="Meat Pizza", PizzaName="Meat Pizza", BasePrice=2, TomatoSouce = true, Cheese=true, Peperoni = false, Mushroom = true, Tuna= false, PineApple= false, Ham=true, Beef= true, FinalPrice=4},
            new PizzasModel() {ImageTitle="Pepperoni pizza", PizzaName="Pepperoni pizza", BasePrice=2, TomatoSouce = true, Cheese=true, Peperoni = false, Mushroom = true, Tuna= false, PineApple= false, Ham=true, Beef= true, FinalPrice=4},
            new PizzasModel() {ImageTitle="Supreme Pizza", PizzaName="Supreme Pizza", BasePrice=2, TomatoSouce = true, Cheese=true, Peperoni = false, Mushroom = true, Tuna= false, PineApple= false, Ham=true, Beef= true, FinalPrice=4},
            new PizzasModel() {ImageTitle="Veggie Pizza", PizzaName="Veggie Pizza", BasePrice=2, TomatoSouce = true, Cheese=true, Peperoni = false, Mushroom = true, Tuna= false, PineApple= false, Ham=true, Beef= true, FinalPrice=4},
            new PizzasModel() {ImageTitle="Works Pizza", PizzaName="Works Pizza", BasePrice=2, TomatoSouce = true, Cheese=true, Peperoni = false, Mushroom = true, Tuna= false, PineApple= false, Ham=true, Beef= true, FinalPrice=4},

        };


        public void OnGet()
        {
        }
    }
}
