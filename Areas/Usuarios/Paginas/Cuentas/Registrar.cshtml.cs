using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon777.Areas.Usuarios.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Amazon777.Areas.Usuarios.Paginas.Cuentas
{
    public class RegistrarModel : PageModel
    {
        public void OnGet()
        {
        }

        [BindProperty]

        public InputModel Input { get; set; }
        public class InputModel : InputModelRegister
        {

        }
    }
}
