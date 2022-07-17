using EntityLayer.Abstract_Entities;

namespace EntityLayer.Entities
{
    public class Session : Base<byte>
    {
        public string MovieSession { get; set; }

        public override string ToString()
        {
            return $"{MovieSession}";
        }
    }
}
