using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace autoProject.dbClases
{
    public class PriseSpeaPart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public float Prise { get; set; }

        // forin key for speaPart
        public virtual SpeaPart SpeaPart { get; set; }
             
            

    }
}
