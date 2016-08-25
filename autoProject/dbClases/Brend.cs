using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace autoProject.dbClases
{
    public class Brend : IdentificableEntity
    {
        public string BrandName { get; set; }

        //public int CarId { get; set; }

        // forin key for Car
        public virtual Car Car { get; set; }

        public virtual List<Model> Models { get; set; } 
    }
}
