using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace CozaStore.Models;


[Table("Cor")]
    public class cor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Id {get; set; }

        [Required(ErrorMessage = "Informe o Nome")]
        [StringLength(30, ErrorMessage = "O Nome deve possuir no máximo 30 caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Código da Cor")]
        [Required(ErrorMessage = "Informe o código da cor")]
        [StringLength(7, ErrorMessage = "O código da cor deve possuir no máximo 7 caracateres")]
        public string CodigoHexa { get; set; }
    }