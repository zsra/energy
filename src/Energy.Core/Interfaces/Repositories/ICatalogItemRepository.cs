using Energy.Core.Entities.CatalogItems;
using Energy.Core.Extensions.CustomTypes;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Energy.Core.Interfaces.Repositories
{
    public interface ICatalogItemRepository : IAsyncRepository<CatalogItem>, IAsyncFileRepository<FileStorageInfo>
    {
        Task AddPicture(string itemid, Stream filestream, CancellationToken cancellationToken = default);
    }
}
