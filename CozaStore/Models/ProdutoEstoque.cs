using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CozaStore.Models;


[Table("ProdutoEstoque")]
public class ProdutoEstoque
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Display(Name = "Produto")]
    [Required(ErrorMessage = "Informe o Produto")]
    public int ProdutoId { get; set; }
    [ForeignKey("ProdutoId")]
    public Produto Produto { get; set; }

    [Display(Name = "Cor")]
    [Required(ErrorMessage = "Informe a Cor")]
    public int CorId { get; set; }
    [ForeignKey("CorId")]
    public Cor Cor { get; set; }

    [Display(Name = "Tamanho")]
    [Required(ErrorMessage = "Informe o tamanho")]
    public int TamanhoId { get; set; }
    [ForeignKey("TamanhoId")]
    public Tamanho Tamanho { get; set; }

    [Display(Name = "Preço")]
    [Column(TypeName = "decimal(8,2)")]
    [Required(ErrorMessage = "Informe o preço de venda")]

    public decimal Preco { get; set; }
    
    [Display(Name = "Preço com desconto")]
    [Column(TypeName = "decimal(8,2)")]
    [Required(ErrorMessage = "Informe o preço com desconto")]
    public decimal Precodesconto { get; set; }

    [Display(Name = "Qtde")]
    [Required(ErrorMessage = "Informe a Qtde")]
    public int Qtde { get; set; }

}