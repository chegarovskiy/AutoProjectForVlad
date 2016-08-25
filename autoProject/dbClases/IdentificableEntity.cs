using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace autoProject.dbClases
{
    public class IdentificableEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // automatic generate unic key
        public int Id { get; set; }

    }
}