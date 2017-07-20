using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace SWMSoftMockUp
{
    class Tab
    {
        public string title { get; set; }
        public string tabColor { get; set; }
        public ObservableCollection<Asset> asset { get; set; }
       
    }
}
