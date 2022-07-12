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
    public class SinoptikController
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
            Info = new OtherInfo();
            _html = Encoding.UTF8.GetString(_client.DownloadData("https://sinoptik.ua/"));
            _htmlDocument = new HtmlDocument();
            _htmlDocument.LoadHtml(_html);
            GetHoursTempearures();
            GetOtherInfo();
        }

        private void GetHoursTempearures()
        {
            HtmlNodeCollection HoursNodes = _htmlDocument.DocumentNode.SelectNodes("//tr[@class='gray time']//td");
            HtmlNodeCollection ImgNodes = _htmlDocument.DocumentNode.SelectNodes("//tr[@class='img weatherIcoS']//td//div//img['@class=weatherImg']");
            HtmlNodeCollection TemperatureNodes = _htmlDocument.DocumentNode.SelectNodes("//tr[@class='temperature']//td");
            HtmlNodeCollection TemperatureSensNodes = _htmlDocument.DocumentNode.SelectNodes("//tr[@class='temperatureSens']//td");
            HtmlNodeCollection PressureWindNodes = _htmlDocument.DocumentNode.SelectNodes("//tr[@class='gray']//td");
            HtmlNodeCollection WetnessPrecipitationNodes = _htmlDocument.DocumentNode.SelectNodes("//div[@class='rSide']//tbody//tr[not(@class)]//td"); 
           
            for (int i = 0; i < 8; i++)
            {
                string hours = HoursNodes[i].InnerText;
                string img = $"https:{ImgNodes[i].GetAttributeValue("src", "")}";
                string name = img.Substring(img.LastIndexOf('/'));
                _client.DownloadFile(img, name);
                string temp = TemperatureNodes[i].InnerText.Replace("deg;","");
                string senstemp = TemperatureSensNodes[i].InnerText.Replace("deg;", "");
                int press = int.Parse(PressureWindNodes[i].InnerText);
                float wind = float.Parse(PressureWindNodes[i+8].InnerText.Replace('.',','));
                int wetness = int.Parse(WetnessPrecipitationNodes[i].InnerText);
                string precipit = WetnessPrecipitationNodes[i + 8].InnerText;
                HourTemperatures.Add(new HourTemperature(hours, name, temp, senstemp, press, wind,wetness,precipit));
            }

            GC.Collect(GC.GetGeneration(HoursNodes));
            GC.Collect(GC.GetGeneration(ImgNodes));
            GC.Collect(GC.GetGeneration(TemperatureNodes));
            GC.Collect(GC.GetGeneration(TemperatureSensNodes));
            GC.Collect(GC.GetGeneration(PressureWindNodes));
            GC.Collect(GC.GetGeneration(WetnessPrecipitationNodes));
        }

        private void GetOtherInfo()
        {
            HtmlNode node = _htmlDocument.DocumentNode.SelectSingleNode("//div[@class='img']//img");
            string ic = node?.GetAttributeValue("src", "");
            string name = ic.Substring(ic.LastIndexOf('/'));
            _client.DownloadFile($"https:{ic}",name);
            Info.Icon = name;

            node = _htmlDocument.DocumentNode.SelectSingleNode("//p[@class='today-temp']");
            Info.CurrentTemperature = node?.InnerText.Replace("deg;", "");

            node = _htmlDocument.DocumentNode.SelectSingleNode("//div[@class='wDescription clearfix']//div[@class='rSide']//div[@class='description']");
            Info.DayInfo = node?.InnerText;

            node = _htmlDocument.DocumentNode.SelectSingleNode("//div[@class='oDescription clearfix']//div[@class='rSide']//div[@class='description']");
            Info.PeopleWeather = node?.InnerText;

            HtmlNodeCollection nodes = _htmlDocument.DocumentNode.SelectNodes("//div[@class='infoDaylight']//span");
            Info.Sunrise = $"Восход {nodes[0]?.InnerText}";
            Info.Decine = $"Закат {nodes[1]?.InnerText}";

            node = _htmlDocument.DocumentNode.SelectSingleNode("//p[@class='infoHistory']");
            Info.HistoryInfo = node?.InnerText;

            node = _htmlDocument.DocumentNode.SelectSingleNode("//p[@class='infoHistoryval']");
            string maxMin = node?.InnerText.Replace("deg;", "");
            maxMin = maxMin.Insert(maxMin.IndexOf(')')+1," |");
            string[] temps = maxMin.Split('|');
            Info.MaxTemperature = temps[0].Trim();
            Info.MinTemperature = temps[1].Trim();

            Info.WeatherToday = _htmlDocument.DocumentNode.SelectSingleNode("//p[@class='today-time']")?.InnerText;

            GC.Collect(GC.GetGeneration(node));
            GC.Collect(GC.GetGeneration(nodes));
            GC.Collect(GC.GetGeneration(temps));


        }
    }
}
