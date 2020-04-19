using System.ComponentModel.DataAnnotations;

namespace Candy.Web.Data.Entities
{
	public class Provider:IEntity
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "{0} es requerido")]
		[MaxLength(30, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
		[Display(Name = "Nombre")]
		public string Name { get; set; }

		[Required(ErrorMessage = "{0} es requerido")]
		[DataType(DataType.EmailAddress)]
		[Display(Name = "Correo Electronico")]
		public string Email { get; set; }

		[Required(ErrorMessage = "{0} es requerido")]
		[MaxLength(13, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
		[Display(Name = "RFC")]
		public string RFC { get; set; }

		[Required(ErrorMessage = "{0} es requerido")]
		[Display(Name = "Numero De Telefono")]
		public int Phone { get; set; }

		[Required(ErrorMessage = "{0} es requerido")]
		[Display(Name = "Pais")]
		public Country Country { get; set; }

		[Required(ErrorMessage = "{0} es requerido")]
		[MaxLength(20, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
		[Display(Name = "Direccion")]
		public string address { get; set; }
	}
}
