using System.Threading.Tasks;

namespace Reptile.Core
{
    public abstract class DataSource
    {
        private readonly IHttp socket;
        protected DataSource(IHttp socket)
        {
            this.socket = socket;
        }

        public async Task<string> GetAsync()
        {
            var data = string.Empty;

            if (socket.Open())
            {
                var url = GetUrl();
                data = await socket.GetAsync(url);
                socket.Close();
            }

            return data;
        }

        protected abstract string GetUrl();
    }
}