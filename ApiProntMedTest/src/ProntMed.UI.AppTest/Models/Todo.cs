using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProntMed.UI.AppTest.Models
{
    public class TodoModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id{ get; set; }

        [Required(ErrorMessage="O campo {0} é obrigatório")]
        [StringLength(100,ErrorMessage ="O campo {0} precisar ter {2} e {1} caracteres",MinimumLength =3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "É necessário informar se {0} é Sim ou Não")]
        public bool Completed { get; set; }

        public bool IsValid()
        {
            if ((this.Name == string.Empty) || (this.Name.Length <3)) { return false; };
            return true;

        }

        public TodoModel()
        {
            this.Name = string.Empty;
            this.Id = 0;
            this.Completed = false;
        }

    }
}
