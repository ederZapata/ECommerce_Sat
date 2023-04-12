using System.ComponentModel.DataAnnotations;

namespace ECommerce_Sat.DAL.Entities
{
    public class Country : Entity
    {
        [Display(Name = "Pais")] //Nombre que quiero mostrar en la web
        [MaxLength(50)] //Varcjar(50)
        [Required(ErrorMessage = "El campo {0} es obligatorio")] //Not null

        public string Name { get; set; }

        [Display(Name = "Estados")] //Nombre que quiero mostrar en la web

        public ICollection<State> States { get; set; }

        [Display(Name = "Número Estados")] //Nombre que quiero mostrar en la web

        public int StateNumber => States == null ? 0 : States.Count;// IF TERNARIO  SI Estate ES (==) null ENTONCES (?) mande 0 sino (:) mande el contador
    }
}
