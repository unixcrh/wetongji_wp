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
                //...Parse the string below
                Debug.WriteLine(str);
            },obj );
        }
    }
}