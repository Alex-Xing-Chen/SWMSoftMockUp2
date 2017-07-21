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
        public ObservableCollection<ItemTask> iTasks { get; set; }

        public ItemTasksVM(Tab tab){

            if (tab.title.Equals("Facility")) {

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

            }else if (tab.title.Equals("Structure"))
            {
                iTasks = new ObservableCollection<ItemTask>
            {
                new ItemTask
                {
                    name="Inlet",
                    expanded=false
                },
                new ItemTask
                {
                    name="Outlet",
                    expanded=false
                },
                new ItemTask
                {
                    name="Structure",
                    expanded=false
                }
            };
            }
            else if (tab.title.Equals("LID"))
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

        public void expandTask(ItemTask item)
        {
            item.expanded = true;
            UpdateTasks(item);
        }

        private void UpdateTasks(ItemTask item)
        {
            int index = iTasks.IndexOf(item);
            iTasks.Remove(item);
            iTasks.Insert(index, item);

        }
    }
}
