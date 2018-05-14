using FunnelBud.Enums;

namespace FunnelBud.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public EnumCategory Category { get; set; }

        //Saving price with VAT
        public double Price { get; set; }
        public double PriceNoVAT { get; set; }
    }
}