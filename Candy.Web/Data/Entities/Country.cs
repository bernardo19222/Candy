using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Candy.Web.Data.Entities
{
	public class Country : IEntity
	{
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        [MaxLength(15, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        [Display(Name = "Pais")]
        public string Name { get; set; }
        public ICollection<Client> Clients { get; set; }
        public ICollection<Provider> Providers { get; set; }
    }
}
