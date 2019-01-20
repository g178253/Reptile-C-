using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reptile.Core;

namespace Reptile.Douban
{
    public sealed class DoubanUI : UserInterface
    {
        public DoubanUI(DataSource dataSource, DataProcessor dataProcessor) : base(dataSource, dataProcessor)
        {
        }
    }
}
