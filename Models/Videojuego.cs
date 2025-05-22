using System.ComponentModel.DataAnnotations;

namespace TercerParcial.Models
{
    public class Videojuego:Media
    {
        [Required]
        public string Plataforma { get; set; }
        [Required]
        public int Peso { get; set; }
    }
}
