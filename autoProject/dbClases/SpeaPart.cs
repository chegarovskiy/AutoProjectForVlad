using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace autoProject.dbClases
{
    public class SpeaPart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int Code { get; set; }
        public string Manufacturer { get; set;}
        public string Notes { get; set; }

        // forin key for speaPart
        public virtual Order Order { get; set; }

        public virtual List<PriseSpeaPart> PriseSpeaParts { get; set; } 
    }
}
