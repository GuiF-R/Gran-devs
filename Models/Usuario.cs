using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Gran_devs.Models;

[Table("Usuario")]
public class Usuario
{
    [Key]

    public string UsuarioId { get; set; }
    [ForeignKey("UsuarioId")]
    public Microsoft.AspNetCore.Identity.IdentityUser MyProperty { get; set; }

    [Required(ErrorMessage = "Insira o nome")]
    [StringLength(60, ErrorMessage = "O nome deve possuir no máximo 60 caracteres")]  
    public string Nome { get; set; }

    [Required(ErrorMessage = "Informe a data de nascimento")]
    [DataType(DataType.Date)]

    public DateTime DataNascimento { get; set; }

    [StringLength(300)]

    public string FotoPerfil { get; set; }

    [Required(ErrorMessage = "Informe a Area de atuação")]

    public int AreaAtuacaoId { get; set; }
    [ForeignKey("AreaAtuacaoId")]

    public AreaAtuacao AreaAtuacao { get; set; } 

}
