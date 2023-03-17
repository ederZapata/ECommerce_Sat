using System.ComponentModel.DataAnnotations;

namespace ECommerce_Sat.DAL.Entities
{
    public class Country : Entity
    {
        [Display(Name = "Pais")] //Nombre que quiero mostrar en la web
        [MaxLength(50)] //Varcjar(50)
        [Required(ErrorMessage = "El campo {0} es obligatorio")] //Not null

        public string Name { get; set; }

       
    }
}
