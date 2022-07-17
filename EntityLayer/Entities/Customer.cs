using EntityLayer.Abstract_Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Entities
{
    [Table("Customers")]
   public class Customer : Base<int>
    {
        public string NameSurname { get; set; }
    }
}
