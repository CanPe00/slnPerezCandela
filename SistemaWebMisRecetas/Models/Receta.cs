using SistemaWebMisRecetas.Validations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading;

namespace SistemaWebMisRecetas.Models
{
    [Table("Receta")]
    public class Receta
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [CheckCategoriaAttrubute]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [DataType(DataType.MultilineText)]
        public string Ingredientes { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [DataType(DataType.MultilineText)]
        public string Instrucciones { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        [DisplayName("Nombre")]
        public string NombreAutor { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        [DisplayName("Apellido")]
        public string ApellidoAutor { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Range(18, 101, ErrorMessage = "La edad debe ser mayor o igual a 18 años")]
        [DisplayName("Edad")]
        public int EdadAutor { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail no valido")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "E-mail no valido")]
        [DisplayName("Email")]
        public string EmailAutor { get; set; }

    }
}
