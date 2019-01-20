using System.Threading.Tasks;

namespace Reptile.Core
{
    public interface IHttp
    {
        bool Open();
        void Close();
        Task<string> GetAsync(string url);
    }
}