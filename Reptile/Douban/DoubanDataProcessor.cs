using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reptile.Core;

namespace Reptile.Douban
{
    public sealed class DoubanDataProcessor : DataProcessor
    {
        public override string Analytical(string data)
        {
            return data;
        }
    }
}
