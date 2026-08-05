using System.ComponentModel.DataAnnotations;

namespace AcademiaCrud.Models
{
    public class Instrutor
    {
        [Key]
        public int idInstrutor { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string sexo { get; set; }
        public int idade { get; set; }
    }
}
