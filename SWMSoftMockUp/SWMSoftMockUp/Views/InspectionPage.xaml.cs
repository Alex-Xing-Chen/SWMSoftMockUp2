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
        private ItemTask _currentItem;

        public InspectionPage(Tab tab)
        {
            InitializeComponent();
            var navPage = App.Current.MainPage as NavigationPage;
            navPage.BarTextColor = Color.Black;
            Title = tab.title;
            navPage.BarBackgroundColor = Color.FromHex(tab.tabColor);
            inspectionBackground.BackgroundColor = Color.FromHex(tab.tabColor);
            _assetList = new ItemTasksVM(tab);
            TaskList.ItemsSource = _assetList._iTasks;

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
            _currentItem = e.Item as ItemTask;
            
            _assetList.HideOrShow(_currentItem);

        }

        private void RatingOne_Clicked(object sender, EventArgs e)
        {

            _assetList.UpdateRatings(_currentItem, 1);

        }

        private void RatingTwo_Clicked(object sender, EventArgs e)
        {
            _assetList.UpdateRatings(_currentItem, 2);

        }

        private void RatingThree_Clicked(object sender, EventArgs e)
        {
            _assetList.UpdateRatings(_currentItem, 3);

        }

        private void RatingFour_Clicked(object sender, EventArgs e)
        {
            _assetList.UpdateRatings(_currentItem, 4);

        }

        private void RatingFive_Clicked(object sender, EventArgs e)
        {
            _assetList.UpdateRatings(_currentItem, 5);

        }

        private void Photo_Clicked(object sender, EventArgs e)
        {
            _assetList.UpdatePhotoBtn(_currentItem);

        }
    }
}