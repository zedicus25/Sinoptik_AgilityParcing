using Sinoptik.Controller;
using Sinoptik.View.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sinoptik
{
    public partial class MainForm : Form
    {
        SinoptikController _sinoptikController;
        private Timer _timer;
        public MainForm()
        {
            InitializeComponent();
            _sinoptikController = new SinoptikController();
            UpdateWeather();
            _timer = new Timer();
            _timer.Tick += Timer_Tick;
            _timer.Interval = 300000;
            _timer.Start();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _sinoptikController.GetWeather();
            UpdateWeather();
        }

        private void UpdateWeather()
        {
            if (_sinoptikController.HourTemperatures.Count > 0)
            {
                Control[] controls = this.Controls.Find("todayWeatherControl1", false);
                for (int i = 0; i < controls.Length; i++)
                {
                    (controls[i] as TodayWeatherControl).UpdateData(_sinoptikController.HourTemperatures);
                }
                GC.Collect(GC.GetGeneration(controls));


                byte[] bytes = File.ReadAllBytes(_sinoptikController.Info.Icon);
                FileStream fs = new FileStream(_sinoptikController.Info.Icon, FileMode.Open, FileAccess.Read, FileShare.None);
                fs.Read(bytes, 0, bytes.Length);
                this.weatherPB.Image = new Bitmap(fs);
                fs.Close();
                fs.Dispose();
                GC.Collect(GC.GetGeneration(fs));
                GC.Collect(GC.GetGeneration(bytes));


                weatherTodayL.Text = _sinoptikController.Info.WeatherToday;
                lightDayL.Text = $"{_sinoptikController.Info.Sunrise} {_sinoptikController.Info.Decine}";
                dayInfoL.Text = _sinoptikController.Info.DayInfo;
                historyInfoL.Text = _sinoptikController.Info.PeopleWeather;
                historyTempL.Text = _sinoptikController.Info.HistoryInfo;
                minTempL.Text = _sinoptikController.Info.MinTemperature;
                maxTempL.Text = _sinoptikController.Info.MaxTemperature;
                currentTempL.Text = _sinoptikController.Info.CurrentTemperature;
            }
        }
    }
}
