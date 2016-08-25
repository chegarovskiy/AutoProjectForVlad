using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace autoProject.dbClases
{
    class Emploee
    {
        public Emploee()
        {
            TypeOfWorks = new List<TypeOfWork>();
        }
        public virtual ICollection<TypeOfWork> TypeOfWorks { get; set; }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string FullName { get; set; }
        public string Specialization { get; set; }

        // forin key for DetailToPerform
        public virtual DetailToPerform DetailToPerform { get; set; }

    }
}
