using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;
            if (Pizza.Beef) PizzaPrice += .25f;
            if (Pizza.Tuna) PizzaPrice += .25f;
            if (Pizza.Cheese) PizzaPrice += .50f;
            if (Pizza.Ham) PizzaPrice += .5f;
            if (Pizza.Mushroom) PizzaPrice += .50f;
            if (Pizza.Peperoni) PizzaPrice += .50f;
            if (Pizza.Pineapple) PizzaPrice += 10;
            if (Pizza.TomatoSauce) PizzaPrice += .50f;

            return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName, PizzaPrice });
            // return new OkResult();
        }
    }
}
