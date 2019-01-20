using Reptile.Core;

namespace Reptile.Douban
{
    public sealed class DoubanDataSource : DataSource
    {
        public DoubanDataSource(IHttp socket) : base(socket)
        {
        }

        protected override string GetUrl()
        {
            return "https://www.douban.com/";
        }
    }
}
