using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon777.Areas.Usuarios.Models
{
    public class InputModelRegister
    {
        [Required(ErrorMessage = "El Campo Nombre es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Campo Apellido es obligatorio.")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El Campo Nid es obligatorio.")]
        public string NID { get; set; }

        [Required(ErrorMessage = "El Campo Telefono es obligatorio.")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?[0-9]{2})\)?[-, ]?([0-9]{2})[-, ]?([0-9]{5})$", ErrorMessage = "El formato Telefono ingresado no es valido.")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El Campo Correo electronico es obligatorio.")]
        [EmailAddress(ErrorMessage = "El campo correo electronico no es una direccion de correo electronico valido")]
        public string Email { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "El Campo Contraseña es obligatorio.")]
        [StringLength(100, ErrorMessage = "El numero de caracteres de {0} debe ser al menos {2}.", MinimumLength = 6)]
        public string Password { get; set; }
    }
}
