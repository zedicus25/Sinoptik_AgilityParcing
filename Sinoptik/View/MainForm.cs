using Sinoptik.Controller;
using Sinoptik.View.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinoptik
{
    public partial class MainForm : Form
    {
        SinoptikController _sinoptikController;
        public MainForm()
        {
            InitializeComponent();
            _sinoptikController = new SinoptikController();
            UpdateWeather();
            
        }

        private void UpdateWeather()
        {
            Control[] controls = this.Controls.Find("todayWeatherControl1", false);
            for (int i = 0; i < controls.Length; i++)
            {
                (controls[i] as TodayWeatherControl).UpdateData(_sinoptikController.HourTemperatures);
            }

            weatherPB.Image = Image.FromFile(_sinoptikController.Info.Icon);
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
