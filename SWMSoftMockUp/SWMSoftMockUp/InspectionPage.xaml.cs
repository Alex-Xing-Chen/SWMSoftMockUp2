using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SWMSoftMockUp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InspectionPage : ContentPage
    {
        public InspectionPage(int position)
        {
            InitializeComponent();
            string assetType;
            var navPage = App.Current.MainPage as NavigationPage;
            navPage.BarTextColor = Color.Black;
            if (position == 0)
            {
                navPage.BarBackgroundColor = Color.FromHex("#ffce00");
                inspectionBackground.BackgroundColor = Color.FromHex("#ffce00");
                assetType = "Facility";
                Title = assetType;
                var facList = new ItemTasksVM(assetType);
                TaskList.ItemsSource = facList.iTasks;
            }
            else if (position == 1)
            {
                navPage.BarBackgroundColor = Color.FromHex("#c4fd22");
                inspectionBackground.BackgroundColor = Color.FromHex("#c4fd22");
                assetType = "Structure";
                Title = assetType;
                var facList = new ItemTasksVM(assetType);
                TaskList.ItemsSource = facList.iTasks;
            }
            else if (position == 2)
            {
                navPage.BarBackgroundColor = Color.FromHex("#00baf0");
                inspectionBackground.BackgroundColor = Color.FromHex("#00baf0");
                assetType = "LID";
                Title = assetType;
                var facList = new ItemTasksVM(assetType);
                TaskList.ItemsSource = facList.iTasks;
            }
            else
            {

            }

        }
    }
}