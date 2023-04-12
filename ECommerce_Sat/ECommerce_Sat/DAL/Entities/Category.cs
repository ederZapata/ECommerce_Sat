﻿using System.ComponentModel.DataAnnotations;

namespace ECommerce_Sat.DAL.Entities
{
    public class Category : Entity
    {
        [Display(Name = "Categoria")] //Nombre que quiero mostrar en la web
        [MaxLength(100)] //Varcjar(50)
        [Required(ErrorMessage = "El campo {0} es obligatorio")] //Not null

        public string Name { get; set; }

        [Display(Name = "Descripción")] //Nombre que quiero mostrar en la web

        public string? Description { get; set; }



    }
}
