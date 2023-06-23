using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {

        public List<PizzasModel> FakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){ImageTitle="Margerita",PizzaName="Margerita", BasePrice=2, TomatoSouce=true, Cheese=true, FinalPrice=4},

             new PizzasModel(){ImageTitle="Hawaiian",PizzaName="Hawiaan", BasePrice=2, TomatoSouce=true, Cheese=true, FinalPrice=4},

        };
        public void OnGet()
        {
        }
    }
}
