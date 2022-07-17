using EntityLayer.Abstract_Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Entities
{
    [Table("MovieTypes")]
    public class MovieType : Base<byte>
    {
        public string TypeName { get; set; }
    }
}
