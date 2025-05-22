using System.ComponentModel.DataAnnotations;

namespace TercerParcial.Models
{
    public class Pelicula:Media
    {
        [Required]
        public int Duracion { get; set; }
        [Required]
        public string Idioma { get; set; }
    }
}
