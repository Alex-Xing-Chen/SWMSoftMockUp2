using System;
using System.Collections.Generic;
using System.Text;

namespace SWMSoftMockUp.Models
{
    public class Asset
    {
        public string name { get; set; }
        public string id { get; set; }
        public string nameID { get; set;  }
        public bool expanded { get; set; } = false;
        public List<string> pastInspections { get; set; } = new List<string> { "Hello","Bye"};

        public string combine(string id, string name)
        {
            return id + "-" + name;
        }
    }
}
