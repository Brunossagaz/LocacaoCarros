using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocacaoCarros.Models
{

    [Table("Carros")]
    public class Carros
    {
        [Column("Id")]
        [Display(Name ="Código")]
        public int Id { get; set; }

        [Column("Marca")]
        [Display(Name = "Marca")]
        public string Marca { get; set; }

        [Column("Modelo")]
        [Display(Name = "Modelo")]
        public string Modelo { get; set; }

        [Column("Ano")]
        [Display(Name = "Ano")]
        public int Ano { get; set; }

        [Column("Cor")]
        [Display(Name = "Cor")]
        public string Cor { get; set; }

        [Column("Diaria")]
        [Display(Name = "Diaria")]
        public float Diaria { get; set; }

    }
}
