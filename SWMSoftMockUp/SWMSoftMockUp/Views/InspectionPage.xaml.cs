using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using SWMSoftMockUp.ViewModels;
using SWMSoftMockUp.Models;

namespace SWMSoftMockUp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InspectionPage : ContentPage
    {

        private ItemTasksVM _assetList;

        public InspectionPage(Tab tab)
        {
            InitializeComponent();
            var navPage = App.Current.MainPage as NavigationPage;
            navPage.BarTextColor = Color.Black;
            Title = tab.title;
            navPage.BarBackgroundColor = Color.FromHex(tab.tabColor);
            inspectionBackground.BackgroundColor = Color.FromHex(tab.tabColor);
            _assetList = new ItemTasksVM(tab);
            TaskList.ItemsSource = _assetList.iTasks;

        }

        private void TaskListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            if (e.SelectedItem == null)
            {
                return;
            }

            //DisplayAlert("Item Selected", e.SelectedItem.ToString(), "Ok");
            //task.IsVisible = true;

        }

        private void TaskList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as ItemTask;
            
            _assetList.HideOrShow(item);

        }

        private void RatingOne_Clicked(object sender, EventArgs e)
        {
            var btn = e.ToString();

            DisplayAlert("Rating","1","Ok");

        }

        private void RatingTwo_Clicked(object sender, EventArgs e)
        {
            var btn = e.ToString();

            DisplayAlert("Rating", "2", "Ok");

        }

        private void RatingThree_Clicked(object sender, EventArgs e)
        {
            var btn = e.ToString();

            DisplayAlert("Rating", "3", "Ok");

        }

        private void RatingFour_Clicked(object sender, EventArgs e)
        {
            var btn = e.ToString();

            DisplayAlert("Rating","4", "Ok");

        }

        private void RatingFive_Clicked(object sender, EventArgs e)
        {
            var btn = e.ToString();

            DisplayAlert("Rating", "5", "Ok");

        }

        private void Photo_Clicked(object sender, EventArgs e)
        {
            var btn = e.ToString();
            DisplayAlert("Button", "Picture Taken", "Ok");

        }
    }
}