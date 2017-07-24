using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using SWMSoftMockUp.Models;

namespace SWMSoftMockUp.ViewModels
{
    public class TabVM : INotifyPropertyChanged
    {

        private ObservableCollection<Tab> tabs { get; set;  }

        public TabVM()
        {
            tabs = new ObservableCollection<Tab>()
            {
                new Tab
                {
                    title = "Facility",
                    tabColor = "#ffce00",
                    asset = new AssetViewModel("Facility")._assets
                },
                new Tab
                {
                    title = "Structure",
                    tabColor = "#c4fd22",
                    asset = new AssetViewModel("Structure")._assets
                },
                new Tab
                {
                    title = "L.I.D.",
                    tabColor = "#00baf0",
                    asset = new AssetViewModel("LID")._assets
                }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
