using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinimalApi.Dominio.Entidades;

public class Veiculo
{
  [Key]
  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
  public int Id { get; set; } = default!;

  
  [StringLength(150)]
  [Required]
  public string Nome { get; set; } = default!;
  
  [Required]
  [StringLength(100)]
    public string Marca { get; set; } = default!;

    [StringLength(10)]
    [Required]
  public int Ano { get; set; } = default!;
}