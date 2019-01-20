using System;
using System.Threading.Tasks;

namespace Reptile.Core
{
    /// <summary>
    /// 表示用户界面。
    /// </summary>
    public abstract class UserInterface
    {
        private readonly DataSource dataSource;
        private readonly DataProcessor dataProcessor;
        protected UserInterface(DataSource dataSource, DataProcessor dataProcessor)
        {
            this.dataSource = dataSource ?? throw new ArgumentNullException(nameof(dataSource));
            this.dataProcessor = dataProcessor ?? throw new ArgumentNullException(nameof(dataProcessor));
        }

        public async Task<string> GetAsync()
        {
            var data = await dataSource.GetAsync();
            if (data != null)
                return dataProcessor.Analytical(data);
            return null;
        }
    }
}
