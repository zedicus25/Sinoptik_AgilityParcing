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
            TodayWeatherControl td = new TodayWeatherControl(_sinoptikController.HourTemperatures);
            this.Controls.Add(td);
        }
    }
}
