using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CozaStore.Models;


[Table("ProdutoAvaliacao")]
public class ProdutoAvaliacao
{
    [Key, Column(Order = 1)]
    public int ProdutoId { get; set; }
    [ForeignKey("ProdutoId")]
    public Produto Produto { get; set; }

    [Key, Column(Order = 2)]
    [Display(Name = "Cliente")]
    public string UsuarioId { get; set; }
    [ForeignKey("UsuarioId")]
    public Usuario Usuario { get; set; }

    [Display(Name = "Avaliação")]
    [Required(ErrorMessage = "Informe o Texto de Avaliação")]
    [StringLength(300, ErrorMessage = "O Texto deve possuir no máximo 300 caracteres")]
    public string AvaliacaoTexto { get; set; }

   [Display(Name = "Data da Avaliação")]
    public DateTime AvaliacaoData { get; set; }

   [Display(Name = "Nota de Produto")]
    public byte? ProdutoNota { get; set; }

}