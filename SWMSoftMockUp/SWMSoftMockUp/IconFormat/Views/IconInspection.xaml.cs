using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using SWMSoftMockUp.Models;
using SWMSoftMockUp.ViewModels;

namespace SWMSoftMockUp.IconFormat.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IconInspection : ContentPage
    {
        private ItemTasksVM _assetList;
        private ItemTask _currentItem;

        private double width;
        private double height;

        public IconInspection(Tab tab)
        {
            InitializeComponent();
            var navPage = App.Current.MainPage as NavigationPage;
            navPage.BarTextColor = Color.Black;
            Title = tab.title;
            navPage.BarBackgroundColor = Color.FromHex(tab.tabColor);
            inspectionBackground.BackgroundColor = Color.FromHex(tab.tabColor);
            _assetList = new ItemTasksVM(tab);
            gridID.FlowItemsSource = _assetList._iTasks;
        }

        //Change based on orientation
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            if (this.width != width || this.height != height)
            {
                this.width = width;
                this.height = height;

                if (width > height)
                {
                    
                    //gridID.FlowColumnCount = 5;

                }
                else
                {
                    //gridID.FlowColumnCount = 3;
                }

            }

        }

    }
}