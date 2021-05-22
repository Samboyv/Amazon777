using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon777.Areas.Usuarios.Controllers
{

    [Area("Usuarios")]
    public class UsuariosController : Controller
    {
        public IActionResult Usuarios()
        {
            return View();
        }
    }
}
