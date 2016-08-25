using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace autoProject.dbClases
{
    public class Model : IdentificableEntity
    {
        public string ModelName { get; set; }

        public string Engin { get; set; }

        public string Year { get; set; }

        public string Bodytype { get; set; }

        //forin key for car
        public virtual Brend Brend { get; set; }
    }
}
