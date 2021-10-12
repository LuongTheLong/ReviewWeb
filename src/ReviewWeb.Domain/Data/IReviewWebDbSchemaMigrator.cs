using System.Threading.Tasks;

namespace ReviewWeb.Data
{
    public interface IReviewWebDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}