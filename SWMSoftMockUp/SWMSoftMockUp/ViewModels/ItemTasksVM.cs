using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using SWMSoftMockUp.Models;

namespace SWMSoftMockUp.ViewModels
{

    public class ItemTasksVM : INotifyPropertyChanged
    {
        public ObservableCollection<ItemTask> _iTasks { get; set; }
        public string black = "#000000";
        public string gray = "#808080";

        public ItemTasksVM(Tab tab){

            if (tab.title.Equals("Facility")) {

                _iTasks = new ObservableCollection<ItemTask>
            {
                new ItemTask
                {
                    name="Bench Mark",
                    description = "Make sure to record any offset from the actual bench mark",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                },
                new ItemTask
                {
                    name="Emergency Spillway",
                    description = "Check for structural condition (crackling, flaking, broken seperating leaning), obstructions",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                },
                new ItemTask
                {
                    name="Emergency Spillway: Grating",
                    description="Check grate bars for rust, bent, broken, open/closed, and lock",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                },
                new ItemTask
                {
                    name="Facility",
                    description="Check for garbage, erosion, proper function",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                },
                new ItemTask
                {
                    name="Fence",
                    description="Check for structural condition (broken, leaning)",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                },
                new ItemTask
                {
                    name="Inlet Channel",
                    description="Check for standing water, structural integrity and in-steam erosion",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                },
                new ItemTask
                {
                    name="Manhole 1",
                    description="Check for integrity of cover (rust, bent, broken, open/closed, lock-bolts), selling around erosion",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                },
                new ItemTask
                {
                    name="Manhole 2",
                    description="Check for integrity of cover (rust, bent, broken, open/closed, lock-bolts), selling around erosion",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                },
                new ItemTask
                {
                    name="Outlet-Back",
                    description="Check for obstructions/debris",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                },
                new ItemTask
                {
                    name="Outlet_Back: Baffle Blocks",
                    description="Check for structural condition (crackling, flaking)",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                },
                new ItemTask
                {
                    name="Outlet_Back: Grate",
                    description="Check grate bars for rust, bent, broken, open/closed, lock",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                },
                new ItemTask
                {
                    name="Outlet_Back: Headwall",
                    description="Filter Bed Erosion",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                },
                new ItemTask
                {
                    name="Outlet_Back: Pipe",
                    description="Check Pipe",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                },
                new ItemTask
                {
                    name="Outelet_Front",
                    description="Check for obstruction/debris",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                },
                new ItemTask
                {
                    name="Outlet_Front: Grate",
                    description="Check grate bars for rust, bent, broken, open/closed, lock",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                },
                new ItemTask
                {
                    name="Outlet_Front: Headwall",
                    description="Check for structural condition (crackling/flaking)",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                },
                new ItemTask
                {
                    name="Outlet_Front: Pipe",
                    description="Check for obstructions/debris built up",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                }

            };

            }else if (tab.title.Equals("Structure"))
            {
                _iTasks = new ObservableCollection<ItemTask>
            {
                new ItemTask
                {
                    name="Inlet",
                    description="No obstruction/debris, standing water or sediment accumulation",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                },
                new ItemTask
                {
                    name="Outlet",
                    description="No obstruction/debris, standing water or sediment accumulation",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                },
                new ItemTask
                {
                    name="Structure",
                    description="Structure",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                }
            };
            }
            else if (tab.title.Equals("LID"))
            {
                _iTasks = new ObservableCollection<ItemTask>
            {
                new ItemTask
                {
                    name="Contributing Drainage Area",
                    description="Check for Contributing Drainage Area Condition",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                },
                    new ItemTask
                {
                    name="Contributing Drainage Area",
                    description="Trash and Debris",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                },
                new ItemTask
                {
                    name="Inlet",
                    description="Inlet/Flow Spreader/Outlet Structural Integrity",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                },
                new ItemTask
                {
                    name="Inlet",
                    description="Inlet/Flow Spreader/Outlet Obstruction",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                },
                new ItemTask
                {
                    name="Inlet",
                    description="Inlet Erosion",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                },
                new ItemTask
                {
                    name="Inlet",
                    description="Trash and Debris",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                },
                new ItemTask
                {
                    name="Pretreatment Area",
                    description="Check for Sediment Accumulation",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                },
                new ItemTask
                {
                    name="Pretreatment Area",
                    description="Trash and Debris",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                },
                new ItemTask
                {
                    name="Perimeter",
                    description="Trash and Debris",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                },
                new ItemTask
                {
                    name="Filter Bed",
                    description="Standing Water",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                },
                new ItemTask
                {
                    name="Filter Bed",
                    description="Trash and Debris",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                },
                new ItemTask
                {
                    name="Filter Bed",
                    description="Filter Bed Erosion",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                },
                new ItemTask
                {
                    name="Filter Bed",
                    description="Mulch Depth",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                },
                new ItemTask
                {
                    name="Filter Bed",
                    description="Filter Bed Sediment Accumulation",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                },
                new ItemTask
                {
                    name="Filter Bed",
                    description="Filter Bed Surface Sinking",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                },
                new ItemTask
                {
                    name="Filter Bed",
                    description="Check Dams",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                },
                new ItemTask
                {
                    name="Filter Bed",
                    description="Sediment Accumulation Testing",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                },
                new ItemTask
                {
                    name="Vegetation",
                    description="Vegetation Cover",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false

                },
                new ItemTask
                {
                    name="Vegetation",
                    description="Vegetation Condition",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false

                },
                new ItemTask
                {
                    name="Vegetation",
                    description="Vegetation Composition",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false

                },
                new ItemTask
                {
                    name="Overflow Outlet",
                    description="Overflow Outlet Obstruction",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                },
                new ItemTask
                {
                    name="Monitoring Well",
                    description="Monitoring Well Condition",
                    comments="",
                    rating=0,
                    hasPhoto=false,
                    complete=false
                }

            };
            }
            else
            {
                //Todo
            }

        }

        internal void HideOrShow(ItemTask item)
        {

            if (!item.expanded)
            {
                item.expanded = true;
            }
            else
            {
                item.expanded = false;
            }
            
            UpdateTasks(item);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        internal void UpdateRatings(ItemTask item, int givenRating)
        {
            

            item.rating = givenRating;
            if (givenRating == 1)
            {
                item.rating1Selected = black;
                item.rating2Selected = gray;
                item.rating3Selected = gray;
                item.rating4Selected = gray;
                item.rating5Selected = gray;
                item.photoBtnSelected = gray;

            }else if (givenRating == 2)
            {
                item.rating1Selected = gray;
                item.rating2Selected = black;
                item.rating3Selected = gray;
                item.rating4Selected = gray;
                item.rating5Selected = gray;
                item.photoBtnSelected = gray;

            }
            else if (givenRating == 3)
            {
                item.rating1Selected = gray;
                item.rating2Selected = gray;
                item.rating3Selected = black;
                item.rating4Selected = gray;
                item.rating5Selected = gray;
                item.photoBtnSelected = gray;

            }
            else if (givenRating == 4)
            {
                item.rating1Selected = gray;
                item.rating2Selected = gray;
                item.rating3Selected = gray;
                item.rating4Selected = black;
                item.rating5Selected = gray;
                item.photoBtnSelected = gray;

            }
            else if (givenRating == 5)
            {
                item.rating1Selected = gray;
                item.rating2Selected = gray;
                item.rating3Selected = gray;
                item.rating4Selected = gray;
                item.rating5Selected = black;
                item.photoBtnSelected = gray;

            }
            else
            {
                item.rating1Selected = gray;
                item.rating2Selected = gray;
                item.rating3Selected = gray;
                item.rating4Selected = gray;
                item.rating5Selected = gray;
                item.photoBtnSelected = gray;
            }

            UpdateTasks(item);

        }

        internal void UpdatePhotoBtn(ItemTask item)
        {
            item.hasPhoto = true;
            item.photoBtnSelected = black;
            UpdateTasks(item);

        }

        private void UpdateTasks(ItemTask item)
        {
            int index = _iTasks.IndexOf(item);
            _iTasks.Remove(item);
            _iTasks.Insert(index, item);

        }
    }
}
