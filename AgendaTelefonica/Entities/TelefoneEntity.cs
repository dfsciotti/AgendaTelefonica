using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaTelefonica.Entities
{
    [Table("TELEFONE")]
    public class TelefoneEntity
    {
        [Key()]
        public int Id { get; set; }
        public int IdContato { get; set; }
        public string Numero { get; set; }
    }
}
