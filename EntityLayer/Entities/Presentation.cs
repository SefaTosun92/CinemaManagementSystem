using EntityLayer.Abstract_Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    [Table("Presentation")]
    public class Presentation : Base<int>
    {

        public bool IsPresentation { get; set; }
        public int MovieID { get; set; }
        public byte SaloonID { get; set; }
        public byte SessionID { get; set; }

        [ForeignKey ("MovieID")]
        public virtual Movies Movie { get; set; }

        [ForeignKey("SaloonID")]
        public virtual Saloon Saloon { get; set; }

        [ForeignKey("SessionID")]
        public virtual Session Session { get; set; }

    }
}
