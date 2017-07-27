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
        public string rating1Selected { get; set; } = "#808080";
        public string rating2Selected { get; set; } = "#808080";
        public string rating3Selected { get; set; } = "#808080";
        public string rating4Selected { get; set; } = "#808080";
        public string rating5Selected { get; set; } = "#808080";
        public string photoBtnSelected { get; set; } = "#808080";
        public bool hasPhoto { get; set; }
        public bool complete { get; set; }
        public bool expanded { get; set; } = false;


    }

}
