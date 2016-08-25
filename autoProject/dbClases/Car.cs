using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace autoProject.dbClases
{
    public class Car : IdentificableEntity
    {
      
        public int vin { get; set; }

        public string IdBrend { get; set; }

        public string IdModel { get; set; }

        public string IdYearRelis { get; set; }

        // foreign key for Client

        public Client Client { get; set; }

        public virtual List<Brend> Brends { get; set; } 

        public virtual List<Model> Models { get; set; }

        public virtual List<Order> Orders { get; set; }
    }
}
