using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Tarea1.Pages
{
    public class Programa1Model : PageModel
    {
        [BindProperty]
        public string altura { get; set; } = "";
        
        [BindProperty]
        public string peso { get; set; } = "";

        public double masa;

        public void OnPost()
        {
            double pesoo = double.Parse(peso);
            double alturaa = double.Parse(altura);
            masa = pesoo / (alturaa * alturaa);

            ModelState.Clear();

        }
    }
}
