using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaTelefonica.Entities
{
    [Table("CONTATO")]
    public class ContatoEntity
    {
        [Key()]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
