﻿using Syncfusion.UI.Xaml.Charts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample1
{
    public class BoxWhiskerModel
    {
        public string Models { get; set; }
        public List<double> RawVals { get; set; }
    }

    public class BoxWhiskerViewModel
    {
        public Array PercentileModeArray
        {
            get
            {
                return Enum.GetValues(typeof(BoxPlotMode));
            }
        }

        //public BoxWhiskerViewModel()
        //{
        //    BoxWhiskerData = new ObservableCollection<BoxWhiskerModel>();
        //    DateTime date = new DateTime(2017, 1, 1);

        //    BoxWhiskerData.Add(new BoxWhiskerModel() { Department = "Development", Age = new List<double> { 22, 22, 23, 25, 25, 25, 26, 27, 27, 28, 28, 29, 30, 32, 34, 32, 34, 36, 35, 38 } });
        //    BoxWhiskerData.Add(new BoxWhiskerModel() { Department = "Testing", Age = new List<double> { 22, 33, 23, 25, 26, 28, 29, 30, 34, 33, 32, 31, 50 } });
        //    BoxWhiskerData.Add(new BoxWhiskerModel() { Department = "HR", Age = new List<double> { 22, 24, 25, 30, 32, 34, 36, 38, 39, 41, 35, 36, 40, 56 } });
        //    BoxWhiskerData.Add(new BoxWhiskerModel() { Department = "Finance", Age = new List<double> { 26, 27, 28, 30, 32, 34, 35, 37, 35, 37, 45 } });
        //    BoxWhiskerData.Add(new BoxWhiskerModel() { Department = "R&D", Age = new List<double> { 26, 27, 29, 32, 34, 35, 36, 37, 38, 39, 41, 43, 58 } });
        //    BoxWhiskerData.Add(new BoxWhiskerModel() { Department = "Sales", Age = new List<double> { 27, 26, 28, 29, 29, 29, 32, 35, 32, 38, 53 } });
        //    BoxWhiskerData.Add(new BoxWhiskerModel() { Department = "Inventry", Age = new List<double> { 21, 23, 24, 25, 26, 27, 28, 30, 34, 36, 38 } });
        //    BoxWhiskerData.Add(new BoxWhiskerModel() { Department = "Graphics", Age = new List<double> { 26, 28, 29, 30, 32, 33, 35, 36, 52 } });
        //    BoxWhiskerData.Add(new BoxWhiskerModel() { Department = "Training", Age = new List<double> { 28, 29, 30, 31, 32, 34, 35, 36 } });
        //}

        public ObservableCollection<BoxWhiskerModel> BoxWhiskerData { get; set; }

        public void Dispose()
        {
            if (this.BoxWhiskerData != null)
                this.BoxWhiskerData.Clear();
        }
    }
}
