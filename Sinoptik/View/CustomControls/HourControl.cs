using Sinoptik.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinoptik.View.CustomControls
{
    public partial class HourControl : UserControl
    {
        public HourControl()
        {
            InitializeComponent();
        }

        public HourControl(HourTemperature hourTemperature) : this()
        {
            UpdateData(hourTemperature);
        }
        
        public void UpdateData(HourTemperature hourTemperature)
        {
            this.hoursL.Text = hourTemperature.Hours;
            this.mainTempL.Text = hourTemperature.MainTemperature;
            this.sensTempL.Text = hourTemperature.SensTemperature;
            this.pressL.Text = hourTemperature.Pressure.ToString();
            this.windL.Text = hourTemperature.Wind.ToString();
            this.wetnessL.Text = hourTemperature.Wetness.ToString();
            this.precipitL.Text = hourTemperature.Precipitation;
            byte[] bytes = File.ReadAllBytes(hourTemperature.Icon);
            FileStream fs = new FileStream(hourTemperature.Icon, FileMode.Open, FileAccess.Read, FileShare.None);
            fs.Read(bytes, 0, bytes.Length);
            this.weatherPB.Image = new Bitmap(fs);
            fs.Close();
            fs.Dispose();
            GC.Collect(GC.GetGeneration(fs));
            GC.Collect(GC.GetGeneration(bytes));
        }
    }
}
