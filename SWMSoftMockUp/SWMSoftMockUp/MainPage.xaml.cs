using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SWMSoftMockUp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            tabfiller.BackgroundColor = Color.FromHex("ffce00");


            //syncDB.Clicked += MenuClickHandler;
            // settings.Clicked += MenuClickHandler;
            //myTasks.Clicked += MenuClickHandler;
            //find.Clicked += MenuClickHandler;
            var facilityList = new AssetViewModel("Facility");
            var structureList = new AssetViewModel("Structure");
            var lidList = new AssetViewModel("LID");

            var tabs = new List<Tab>
            {
                new Tab
                {
                    title = "Facility",
                    tabColor = "#ffce00",
                    asset = facilityList.assets
                },
                new Tab
                {
                    title = "Structure",
                    tabColor = "#c4fd22",
                    asset = structureList.assets
                },
                new Tab
                {
                    title = "L.I.D.",
                    tabColor = "#00baf0",
                    asset = lidList.assets
                }
            };

            //var assetList = new AssetViewModel();

            MainCarouselView.ItemsSource = tabs;
            ListView aList = MainCarouselView.FindByName<ListView>("AssetList");


            //aList.ItemsSource = assets;

        }

        void MenuClickHandler(object sender, EventArgs args)
        {
            /*
           Button menuBtn = sender as Button;

           if (menuBtn == syncDB)
           {
               sampleLabel.Text = "Sync DB";
           }else if (menuBtn == myTasks)
           {
               sampleLabel.Text = "My Tasks";
           }else if (menuBtn == find)
           {
               sampleLabel.Text = "Find";
           }else if (menuBtn == settings)
           {
               sampleLabel.Text = "Settings";
           }
           else
           {
               sampleLabel.Text = "Unknown";
           }

           */
        }

        private void TapSyncDB(object sender, EventArgs e)
        {
            //sampleLabel.Text = "Sync DB";
        }

        private void TapMyTasks(object sender, EventArgs e)
        {
            //sampleLabel.Text = "My Tasks";
        }

        private void TapFind(object sender, EventArgs e)
        {
            //sampleLabel.Text = "Find";
        }

        private void TapSettings(object sender, EventArgs e)
        {
            //sampleLabel.Text = "Settings";
        }


        //Tabs
        private void TapFacilityTab(object sender, EventArgs e)
        {
            MainCarouselView.Position = 0;
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

        }

        private void InspectionsTapped(object sender, EventArgs e)
        {


            OnCallInspectionPage(true);
        }

        private void InfoTapped(object sender, EventArgs e)
        {

        }

        async void OnCallInspectionPage(Boolean b)
        {
            //var iP = new NavigationPage (new InspectionPage());

            //iP.BarBackgroundColor = Color.GreenYellow;
            await Navigation.PushAsync(new InspectionPage(MainCarouselView.Position));
            //await Navigation.PushAsync(iP);
        }
    }
}
