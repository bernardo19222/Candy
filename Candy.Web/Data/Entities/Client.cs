using System;
using System.ComponentModel.DataAnnotations;

namespace Candy.Web.Data.Entities
{
	public class Client:IEntity
	{
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [MaxLength(30, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        [Display(Name = "Nombre")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [MaxLength(30, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        [Display(Name = "Apellidos")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        [Display(Name = "Fecha de nacimiento")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [Display(Name = "Nombre completo")]
        public string FullName => $"{LastName} {FirstName}";

        [Required(ErrorMessage = "{0} es requerido")]
        [Display(Name = "Género")]
        public Gender Gender { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Correo Electronico")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [Display(Name = "Numero De Telefono")]
        public int Phone { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [Display(Name = "Pais")]
        public Country Country { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [MaxLength(20, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        [Display(Name = "Direccion")]
        public string Address { get; set; }
    }
}
