using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Diagnostics;
using System.IO;
using WeTongji.ParameterDictionary;
using System.Text;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace WeTongji
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            this.Loaded += (o, e) =>
            {
                App.ViewModel.SetNavigationService(this.NavigationService);
            };
            DataContext = App.ViewModel;
        }

        /// <summary>
        /// LogOn demo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogOn_Click(object sender, RoutedEventArgs e)
        {
            WeTongji.Api.DefaultWTClient client = new WeTongji.Api.DefaultWTClient();
            Dictionary<string, object> dict = new Dictionary<string, object>();

            dict[Request.Method] = WTUser.LogOn.Method;
            dict[WTUser.LogOn.NO] = "092983";
            dict[WTUser.LogOn.Password] = "123456";

            String url = WTClient.Instance.BuildURL(dict);
            HttpWebRequest request = HttpWebRequest.CreateHttp(url);
            object obj = new object();
            var result = request.BeginGetResponse((args) =>
            {
                var response = request.EndGetResponse(args);
                Stream responseStream = response.GetResponseStream();
                StreamReader sr = new StreamReader(responseStream);
                var str = sr.ReadToEnd();

                var jObj = JObject.Parse(str);

                if (jObj is JContainer)
                {
                    var jContainer = jObj as JContainer;
                    foreach (JToken item in jContainer.Children())
                    {
                        if (item is JProperty)
                        {
                            var jProperty = item as JProperty;

                            if (jProperty.Name == "Data")
                            {
                                WeTongji.Data.User user = new WeTongji.Data.User(jProperty.Value);
                                var s = JsonConvert.SerializeObject(user);
                                //Debug.WriteLine(s);
                                
                                return;
                            }
                        }
                    }
                }
            }, obj);

            JsonSerializerSettings settings = new JsonSerializerSettings();

        }
    }
}