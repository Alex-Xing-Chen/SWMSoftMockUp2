using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using SWMSoftMockUp.Models;
using SWMSoftMockUp.ViewModels;
using SWMSoftMockUp.IconFormat.Views;

namespace SWMSoftMockUp.Views
{
    public partial class MainPage : ContentPage
    {

        private string _assetType;
        private List<Tab> _tabs;
        private Asset _currentAsset;
        private ListView _aList;
        //private AssetViewModel facilityList;
        //private AssetViewModel structureList;
        //private AssetViewModel lidList;
        private AssetViewModel[] _assetList = new AssetViewModel[3];


        public MainPage()
        {
            InitializeComponent();

            tabfiller.BackgroundColor = Color.FromHex("ffce00"); //default tab color


            //syncDB.Clicked += MenuClickHandler;
            // settings.Clicked += MenuClickHandler;
            //myTasks.Clicked += MenuClickHandler;
            //find.Clicked += MenuClickHandler;
            //facilityList = new AssetViewModel("Facility");
            //structureList = new AssetViewModel("Structure");
            //lidList = new AssetViewModel("LID");

            _assetList[0] = new AssetViewModel("Facility");
            _assetList[1] = new AssetViewModel("Structure");
            _assetList[2] = new AssetViewModel("Structure");

            _tabs = new List<Tab>
            {
                new Tab
                {
                    title = "Facility",
                    tabColor = "#ffce00",
                    asset = _assetList[0]._assets
                },
                new Tab
                {
                    title = "Structure",
                    tabColor = "#c4fd22",
                    asset = _assetList[1]._assets
                },
                new Tab
                {
                    title = "LID",
                    tabColor = "#00baf0",
                    asset = _assetList[2]._assets
                }
            };

            //var assetList = new AssetViewModel();

            MainCarouselView.ItemsSource = _tabs;
            _aList = MainCarouselView.FindByName<ListView>("AssetList");


            //aList.ItemsSource = assets;

        }
        
        async void LoadingPage()
        {
            var modalPage = new LoadingPage();
            await Navigation.PushAsync(modalPage);
            var poppedPage = await Navigation.PopModalAsync();
        }

        private void TapSyncDB(object sender, EventArgs e)
        {
            DisplayAlert("Placeholder","Syncing Database . . . .", "Ok");
            //LoadingPage();
        }

        private void TapMyTasks(object sender, EventArgs e)
        {
            //sampleLabel.Text = "My Tasks";
            DisplayAlert("PlaceHolder", "Filtering . . . .", "Ok");
        }

        private void TapFind(object sender, EventArgs e)
        {
            //sampleLabel.Text = "Find";
            DisplayAlert("PlaceHolder", "Searching . . . .", "Ok");
        }

        private void TapSettings(object sender, EventArgs e)
        {
            //sampleLabel.Text = "Settings";
            DisplayAlert("PlaceHolder", "Selected Settings . . . .", "Ok");
        }


        //Tabs
        private void TapFacilityTab(object sender, EventArgs e)
        {
            MainCarouselView.Position = 0;
            _assetType = "Facility";
            //tabfiller.BackgroundColor = Color.FromHex("ffce00");
            /*AssetList = new ListView();
            AssetList.ItemsSource = new String[]
            {
                "Facility 1",
                "Facility 2",
                "Facility 3"
            };
            */
        }

        private void TapStructureTab(object sender, EventArgs e)
        {
            //tabfiller.BackgroundColor = Color.FromHex("#c4fd22");
            MainCarouselView.Position = 1;
            _assetType = "Structure";
            /*AssetList.ItemsSource = new String[]
            {
                "Structure 1",
                "Structure 2",
                "Structure 3"
            };*/
        }

        private void TapLIDTab(object sender, EventArgs e)
        {
            //tabfiller.BackgroundColor = Color.FromHex("#00baf0");
            MainCarouselView.Position = 2;
            _assetType = "LID";
            /*AssetList.ItemsSource = new String[]
            {
                "Site 1",
                "Site 2",
                "Site 3"
            };*/
        }

        private void MainCarouselViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //sampleLabel.Text = sender.ToString();
            //sampleLabel.Text = e.SelectedItem as string;

            /*
            if (MainCarouselView.Position == 0)
            {
                tabfiller.BackgroundColor = Color.FromHex("ffce00");
            }else if (MainCarouselView.Position == 1)
            {
                tabfiller.BackgroundColor = Color.FromHex("#c4fd22");
            }else if (MainCarouselView.Position == 2)
            {
                tabfiller.BackgroundColor = Color.FromHex("#00baf0");
            }
            else
            {
                sampleLabel.Text = "Error: Tab Postion not found";
            }
            */

        }

        private void RecordsTapped(object sender, EventArgs e)
        {

            //System.Diagnostics.Debug.WriteLine("Record Tapped registered");
            DisplayAlert("PlaceHolder","Records\n7/10/19\n8/10/20","Ok");
            // Asset currentItem = _aList.SelectedItem as Asset;
            // _assetList[MainCarouselView.Position].HideOrShow(currentItem);

            //DisplayAlert("Past Inspection Records", "7/10/19\n8/10/20", "Ok");
        }

        private void InspectionsTapped(object sender, EventArgs e)
        {
            OnCallInspectionPage(true);
        }

        private void InfoTapped(object sender, EventArgs e)
        {
            DisplayAlert("PlaceHolder","General Information","Ok");
        }

        async void OnCallInspectionPage(Boolean b)
        {
            //var iP = new NavigationPage (new InspectionPage());

            int currenTabPos = MainCarouselView.Position;

            if (currenTabPos == 0)
            {
                _assetType = "Facility";
            }
            else if (currenTabPos == 1)
            {
                _assetType = "Structure";
            }
            else if (currenTabPos == 2)
            {
                _assetType = "LID";
            }
            else
            {

            }
            
            //await Navigation.PushAsync(new InspectionPage(_tabs[MainCarouselView.Position]));
            await Navigation.PushAsync(new IconInspection(_tabs[MainCarouselView.Position]));
        }
    }
}
