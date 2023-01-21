using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_web_api.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public long Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Campo nome obrigatorio")]
        [StringLength(200, MinimumLength = 1,ErrorMessage = "Campo deve ter no maximo 200 caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Profissão")]
        [Required(ErrorMessage = "Campo Profissão obrigatorio")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Campo deve ter no maximo 100 caracteres")]
        public string Profissao { get; set; }
    }
}
