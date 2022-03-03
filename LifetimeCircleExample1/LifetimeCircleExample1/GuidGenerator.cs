using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifetimeCircleExample1
{
    public class GuidGenerator
    {
        public string GUID { get; set; }

        public GuidGenerator()
        {
            GUID = Guid.NewGuid().ToString();
        }
    }
}
