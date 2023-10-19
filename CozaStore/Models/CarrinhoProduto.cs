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

    [Display(Name = "Data de cadastro")]
    public DateTime DataCadastro { get; set; } =  DateTime.Now; 

    [Display(Name = "Data de modificação")]
    public DateTime? Datamodificacao { get; set; }

    [Display(Name = "Preço")]
    [Column(TypeName = "decimal(8,2)")]
    [Required(ErrorMessage = "Informe o preço de venda")]

    public decimal Preco { get; set; }
    
    [Display(Name = "Preço com desconto")]
    [Column(TypeName = "decimal(8,2)")]
    [Required(ErrorMessage = "Informe o preço com desconto")]
    public decimal Precodesconto { get; set; }

    [Display(Name = "Qtde em Estoque")]
    [Required(ErrorMessage = "Informe a Qtde em Estoque")]
    public int QtdeEstoque { get; set; }

}
