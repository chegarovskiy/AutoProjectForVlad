using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace autoProject.dbClases
{
    class TypeOfWork
    {
        public TypeOfWork()
        {
            Emploees = new List<Emploee>();
        }
        public virtual ICollection<Emploee> Emploees { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string NameOfWork { get; set; }
        public float ImplementTime { get; set; }
        public float Prise { get; set; }

        // forin key for DetailToPerform

        public virtual DetailToPerform DetailToPerform { get; set; }
    }
}
