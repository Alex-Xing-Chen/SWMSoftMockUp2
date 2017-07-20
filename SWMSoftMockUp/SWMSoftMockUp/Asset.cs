using System;
using System.Collections.Generic;
using System.Text;

namespace SWMSoftMockUp
{
    public class Asset
    {
        public string name { get; set; }
        public string id { get; set; }
        public string nameID { get; set;  }

        public string combine(string id, string name)
        {
            return id + "-" + name;
        }
    }
}
