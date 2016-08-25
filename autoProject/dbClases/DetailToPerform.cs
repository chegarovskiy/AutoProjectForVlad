using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace autoProject.dbClases
{
    class DetailToPerform
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public virtual List<TypeOfWork> TypeOfWorks { get; set; } 
        public virtual List<Emploee> Emploees { get; set; } 
        public virtual List<SelaryWorker> SelaryWorkers { get; set; } 
    }
}
