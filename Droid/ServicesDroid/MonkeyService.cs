using System;
using System.Collections.Generic;
using System.Net;
using XamarinFormsMix2.Droid.ServicesDroid;
using Xamarin.Forms;
using XamarinFormsMix2.Services;
using XamarinFormsMix2.Models;
using Newtonsoft.Json;
using System.Threading.Tasks;

[assembly: Dependency(typeof(MonkeyService) )]
namespace XamarinFormsMix2.Droid.ServicesDroid
{
    public class MonkeyService : IMonkeyService
    {

        //private string weburi = "https://raw.githubusercontent.com/jamesmontemagno/MonkeysApp-AppIndexing/master/MonkeysApp/monkeydata.json";
        public MonkeyService()
        {
        }

        public List<Monkey> GetMonkeys(string serviceUrl)
        {
            var webclient = new WebClient();
            var response = webclient.DownloadData(serviceUrl);

            var json = System.Text.Encoding.UTF8.GetString(response);
            var monkey = JsonConvert.DeserializeObject<List<Monkey>>(json);
            return monkey;
        }
    }
}
