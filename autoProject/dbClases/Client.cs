using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace autoProject.dbClases
{
    public class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  // autoinkriment but not последовательный 
        public int Id { get; set; }

        public string fullName { get; set; }

        public int phone { get; set; }

        public string address { get; set; }

        public string passportData { get; set; }

        public string notes { get; set; }
        
        public float orders_money { get; set; }

        public virtual List<Car> Cars { get; set; }



    }
}
