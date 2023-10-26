using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Gran_devs.Models;

[Table("area_atuacao")]
    public class AreaAtuacao
    {

      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  
      public int Id { get; set; }  

      [Required(ErrorMessage = "Insira o nome")]
      [StringLength(30, ErrorMessage = "O nome deve possuir no máximo 30 caracteres")]  
      public string Nome { get; set; }
    }
