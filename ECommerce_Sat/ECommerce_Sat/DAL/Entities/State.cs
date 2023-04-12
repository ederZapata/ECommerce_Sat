using System.ComponentModel.DataAnnotations;

namespace ECommerce_Sat.DAL.Entities
{
    public class State : Entity
    {
        [Display(Name = "Pais")] //Nombre que quiero mostrar en la web
        [MaxLength(50)] //Varchar(50)
        [Required(ErrorMessage = "El campo {0} es obligatorio")] //Not null

        public string Name { get; set; }

        public Country Counytry { get; set; }
    }
}
