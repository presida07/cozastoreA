using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CozaStore.Models;

[Table("CarrinhoProduto")]
public class CarrinhoProduto
{
    [Key, Column(Order = 1)]
    [Display(Name = "Carrinho")]
    public int CarrinhoId { get; set; }
    [ForeignKey("CarrinhoId")]
    public Carrinho Carrinho { get; set; }

    [Key, Column(Order = 2)]
    [Display(Name = "Produto")]
    public int ProdutoEstoqueId { get; set; }
    [ForeignKey("ProdutoEstoqueId")]
    public ProdutoEstoque ProdutoEstoque { get; set; }

    [Display(Name = "Preço")]
    [Column(TypeName = "decimal(8,2)")]
    [Required(ErrorMessage = "Informe o Preço de Venda")]
    public decimal Preco { get; set; }

    [Display(Name = "Preço com Desconto")]
    [Column(TypeName = "decimal(8,2)")]
    [Required(ErrorMessage = "Informe o Preço com Desconto")]
    public decimal PrecoDesconto { get; set; }

    [Display(Name = "Qtde")]
    [Required(ErrorMessage = "Informe a Qtde")]
    public int Qtde { get; set; }
}
