using Energy.Core.Extensions.CustomTypes;
using System.IO;
using System.Threading.Tasks;

namespace Energy.Core.Interfaces.Repositories
{
    public interface IAsyncFileRepository<TFile> where TFile : FileStorageInfo
    {
        Task Download(TFile file, Stream stream);
        Task Upload(TFile file, Stream stream);
    }
}
