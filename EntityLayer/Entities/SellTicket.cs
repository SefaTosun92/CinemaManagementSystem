using EntityLayer.Abstract_Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Entities
{[Table("SellTickets")]
    public class SellTicket : Base<int>
    {
        public int MovieId { get; set; }
        public int CustomerId { get; set; }
        public byte SessionId { get; set; }

        public byte SaloonId { get; set; }

        [ForeignKey("MovieId")]
        public virtual Movies movies { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer custumer { get; set; }
        [ForeignKey("SessionId")]
        public virtual Session session { get; set; }
        [ForeignKey("SaloonId")]
        public virtual Saloon saloon { get; set; }
    }
}
