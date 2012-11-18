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

        private void Test_Click(object sender, RoutedEventArgs e)
        {
            String url = "http://we.tongji.edu.cn/api/call?";

            Dictionary<string, string> dict = new Dictionary<string, string>(10);
            dict["V"] = "2.0.0";
            dict["M"] = "User.LogOn";
            dict["NO"] = "092983";
            dict["Password"] = "123456";
            dict["D"] = "iphone";

            var q = dict.OrderBy(pair => pair.Key);
            String queryStr = "";
            foreach (var item in q)
            {
                queryStr += HttpUtility.UrlEncode(item.Key) + "=" + HttpUtility.UrlEncode(item.Value) + "&";
            }

            queryStr = queryStr.Substring(0, queryStr.Length - 1);

            var lower = queryStr.ToLower();

            var hashStr = JeffWilcox.Utilities.Silverlight.MD5Core.GetHashString("D=iphone&M=User.LogOn&NO=092983&Password=123456&V=2.0.0");

            url += queryStr + "&H=" + hashStr.ToLower();
            Debug.WriteLine(url);

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