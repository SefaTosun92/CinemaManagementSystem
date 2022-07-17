using EntityLayer.Abstract_Entities;

using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Entities
{
    [Table("Movies")]
    public class Movies:Base<int>
    {
        public string Name { get; set; }

        public byte MovieTypeID { get; set; }

        public string Director { get; set; }

        public string Duration { get; set; }
        
        [ForeignKey("MovieTypeID")]
        public virtual MovieType movieType { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }

    }
}
