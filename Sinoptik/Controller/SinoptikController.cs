using HtmlAgilityPack;
using Sinoptik.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Sinoptik.Controller
{
    internal class SinoptikController
    {
        public List<HourTemperature> HourTemperatures { get; private set; }
        public OtherInfo Info { get; private set; }
        private WebClient _client;
        private string _html;
        private HtmlDocument _htmlDocument;

        public SinoptikController()
        {
            _client = new WebClient();
            HourTemperatures = new List<HourTemperature>();
            _html = Encoding.UTF8.GetString(_client.DownloadData("https://sinoptik.ua/"));
            _htmlDocument = new HtmlDocument();
            _htmlDocument.LoadHtml(_html);
            GetHoursTempearures();
        }

        private void GetHoursTempearures()
        {
            HtmlNodeCollection HoursNodes = _htmlDocument.DocumentNode.SelectNodes("//tr[@class='gray time']//td");
            HtmlNodeCollection ImgNodes = _htmlDocument.DocumentNode.SelectNodes("//tr[@class='img weatherIcoS']//td//div//img['@class=weatherImg']");
            HtmlNodeCollection TemperatureNodes = _htmlDocument.DocumentNode.SelectNodes("//tr[@class='temperature']//td");
            HtmlNodeCollection TemperatureSensNodes = _htmlDocument.DocumentNode.SelectNodes("//tr[@class='temperatureSens']//td");
            HtmlNodeCollection PressureWindNodes = _htmlDocument.DocumentNode.SelectNodes("//tr[@class='gray']//td");
            for (int i = 0; i < 8; i++)
            {
                string hours = HoursNodes[i].InnerText;
                string img = $"https:{ImgNodes[i].GetAttributeValue("src", "")}";
                string temp = TemperatureNodes[i].InnerText;
                string senstemp = TemperatureSensNodes[i].InnerText;
                int press = int.Parse(PressureWindNodes[i].InnerText);
                float wind = float.Parse(PressureWindNodes[i+8].InnerText.Replace('.',','));
                HourTemperatures.Add(new HourTemperature(hours, img, temp, senstemp, press, wind));
            }
            //HtmlNodeCollection WetnessPrecipitationNodes = _htmlDocument.DocumentNode.SelectNodes("//div[@class='rSide']//tbody//tr[class='']//td"); 
        }
    }
}
