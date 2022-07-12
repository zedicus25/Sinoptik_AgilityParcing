using Sinoptik.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinoptik.View.CustomControls
{
    public partial class TodayWeatherControl : UserControl
    {
        public TodayWeatherControl()
        {
            InitializeComponent();
        }

        public TodayWeatherControl(List<HourTemperature> hourTemperatures) : this()
        {
            
            UpdateData(hourTemperatures);
        }

        public void UpdateData(List<HourTemperature> hourTemperatures)
        {
            List<HourTemperature> hourTemperaturesList = new List<HourTemperature>(hourTemperatures);
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i].Name.Contains("panel"))
                {
                    for (int j = 0; j < this.Controls[i].Controls.Count; j++)
                    {
                        if (this.Controls[i].Controls[j].Name.Contains("hourControl"))
                        {
                            (this.Controls[i].Controls[j] as HourControl).UpdateData(hourTemperaturesList.Last());
                            hourTemperaturesList.RemoveAt(hourTemperaturesList.Count - 1);
                        }
                    }

                }
            }
            GC.Collect(GC.GetGeneration(hourTemperatures));
        }


    }
}
