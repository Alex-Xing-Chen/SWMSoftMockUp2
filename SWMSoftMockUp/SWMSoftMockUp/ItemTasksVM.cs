using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SWMSoftMockUp
{

    public class ItemTasksVM
    {
        public ObservableCollection<ItemTask> iTasks { get; set; }

        public ItemTasksVM(string assetType){

            if (assetType.Equals("Facility")) {

                iTasks = new ObservableCollection<ItemTask>
            {
                new ItemTask
                {
                    name="Bench Mark"
                },
                new ItemTask
                {
                    name="Emergency Spillway"
                },
                new ItemTask
                {
                    name="Emergency Spillway: Grating"
                },
                new ItemTask
                {
                    name="Facility"
                },
                new ItemTask
                {
                    name="Fence"
                },
                new ItemTask
                {
                    name="Inlet Channel"
                },
                new ItemTask
                {
                    name="Manhole 1"
                },
                new ItemTask
                {
                    name="Manhole 2"
                },
                new ItemTask
                {
                    name="Outlet-Back"
                },
                new ItemTask
                {
                    name="Outlet_Back: Baffle Blocks"
                },
                new ItemTask
                {
                    name="Outlet_Back: Grate"
                },
                new ItemTask
                {
                    name="Outlet_Back: Headwall"
                },
                new ItemTask
                {
                    name="Outlet_Back: Pipe"
                },
                new ItemTask
                {
                    name="Outelet_Front"
                },
                new ItemTask
                {
                    name="Outlet_Front: Grate"
                },
                new ItemTask
                {
                    name="Outlet_Front: Headwall"
                },
                new ItemTask
                {
                    name="Outlet_Front: Pipe"
                }

            };

            }else if (assetType.Equals("Structure"))
            {
                iTasks = new ObservableCollection<ItemTask>
            {
                new ItemTask
                {
                    name="Inlet"
                },
                new ItemTask
                {
                    name="Outlet"
                },
                new ItemTask
                {
                    name="Structure"
                }
            };
            }
            else if (assetType.Equals("LID"))
            {
                iTasks = new ObservableCollection<ItemTask>
            {
                new ItemTask
                {
                    name="Contributing Drainage Area"
                },
                new ItemTask
                {
                    name="Inlet"
                },
                new ItemTask
                {
                    name="Pretreatment Area"
                },
                new ItemTask
                {
                    name="Perimeter"
                },
                new ItemTask
                {
                    name="Filter Bed"
                },
                new ItemTask
                {
                    name="Vegetation"
                },
                new ItemTask
                {
                    name="Overflow Outlet"
                },
                new ItemTask
                {
                    name="Monitoring Well"
                }

            };
            }
            else
            {
                //Todo
            }

        }

    }
}
