using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace autoProject.dbClases
{
    class SelaryWorker  
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        public int  IdEmploee { get; set; }


        // forin key for DetailToPerform
        public virtual DetailToPerform DetailToPerform { get; set; }




    }
        
 }

