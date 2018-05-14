using System.Data.Entity;
using FunnelBud.Enums;

namespace FunnelBud.Models
{
    public class ArticleDb : DbContext
    {
        public DbSet<Article> Articles { get; set; }
    }
}