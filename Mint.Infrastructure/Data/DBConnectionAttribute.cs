using System;
using System.Collections.Generic;
using System.Text;

namespace Mint.Infrastructure.Data
{
    public class DBConnectionAttribute : Attribute
    {
        public string DBName { get; set; }
    }
}
