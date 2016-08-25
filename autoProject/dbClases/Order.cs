using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace autoProject.dbClases
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime DataStart { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime DataOut { get; set; }

        public float Money { get; set; }

        // foreign key for Car

        public virtual Car Car { get; set; }

        public virtual ICollection<SpeaPart> SpeaParts { get; set; } 

         

    }
}
