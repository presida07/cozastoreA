using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CozaStore.Models;


[Table("Carrinho")]
public class Carrinho
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [Display(Name = "Cliente")]
    public string UsuarioId { get; set; }
    [ForeignKey("UsuarioId")]
    public Usuario Usuario { get; set; }

    [Display(Name = "Data de cadastro")]
    public DateTime DataCadastro { get; set; } =  DateTime.Now; 

    [Display(Name = "Data de modificação")]
    public DateTime? DataModificacao { get; set; }
}