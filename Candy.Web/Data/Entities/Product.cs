using System.ComponentModel.DataAnnotations;

namespace Candy.Web.Data.Entities
{
	public class Product : IEntity
	{
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [MaxLength(30, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        [Display(Name = "Tipo De Producto")]
        public TypeP TypeP { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [Display(Name = "Cantidad")]
        public int Amount { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [Display(Name = "Precio")]
        public float Price { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [Display(Name = "Peso en Kg")]
        public float Weight { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [Display(Name = "Codigo de Barras")]
        public int Barcode { get; set; }
    }
}
