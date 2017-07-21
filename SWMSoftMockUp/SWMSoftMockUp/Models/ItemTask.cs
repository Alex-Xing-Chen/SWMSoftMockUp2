using System;
using System.Collections.Generic;
using System.Text;

namespace SWMSoftMockUp.Models
{
    public class ItemTask
    {
        public string name { get; set; }
        public string description { get; set; }
        public string comments { get; set; }
        public int rating { get; set; }
        public bool hasPhoto { get; set; }
        public bool complete { get; set; }
        public bool expanded { get; set; }
    }

}
