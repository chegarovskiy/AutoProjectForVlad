using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace autoProject.dbClases
{
    class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  // autoinkriment but not последоватeльный
        public int Id { get; set; }

        public string Login { get; set; }

        [MaxLength(4)]
        [MinLength(4)]
        public string Password { get; set; }

        public string Position { get; set; }

        public string CodeAccsess { get; set; }

    }
}
