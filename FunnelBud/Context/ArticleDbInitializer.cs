using System.Data.Entity;
using FunnelBud.ConfigurationManagement;
using FunnelBud.Enums;

namespace FunnelBud.Models
{
    public class ArticleDbInitializer : DropCreateDatabaseAlways<ArticleDb>
    {
        protected override void Seed(ArticleDb context)
        {
            context.Articles.Add(new Article
            {
                Id = 39533028,
                Name = "Elcykel Allegro",
                Description = "En smart och tillförlitlig elcykel för" +
                                    " dam från Batavus utmärkt både för långa och kortare turer.",
                Category = EnumCategory.Sport,
                Price = 18499,
                PriceNoVAT = 18499- 18499* (ConfigManager.VATPercentageIncrement / 100)
            });
            context.Articles.Add(new Article
            {
                Id = 40266837,
                Name = "Lapierre Overvolt Urban 300",
                Description = "Praktisk och bekväm elcykel med upprätt körställning.",
                Category = EnumCategory.Sport,
                Price = 20990,
                PriceNoVAT = 20990 - 20990 * (ConfigManager.VATPercentageIncrement/100)
            });
            context.Articles.Add(new Article
            {
                Id = 35372817,//p35372817 i assumed that "p" is a typo
                Name = "Chrome cast 2nd generationen",
                Description = "Visar film eller annan media från mobilen på TV:n",
                Category = EnumCategory.Hemelektronik,
                Price = 390,
                PriceNoVAT = 390 - 390 * (ConfigManager.VATPercentageIncrement / 100)
            });
            context.Articles.Add(new Article
            {
                Id = 35552289,
                Name = "Apple TV 64GB 4th generation",
                Description = "Nu kommer App Store till din tv. Du kan förvänta dig massor av spännande spel.",
                Category = EnumCategory.Hemelektronik,
                Price = 1990,
                PriceNoVAT = 1990 - 1990 * (ConfigManager.VATPercentageIncrement / 100)
            });
            context.Articles.Add(new Article
            {
                Id = 40151785,
                Name = "Big Foot truck 2wd",
                Description = "Det här är bilen som startade alltihop och skapade den idag enorma monster-truck trenden.",
                Category = EnumCategory.Leksaker,
                Price = 2795,
                PriceNoVAT = 2795 - 2795 * (ConfigManager.VATPercentageIncrement / 100)
            });
        }
    }
}