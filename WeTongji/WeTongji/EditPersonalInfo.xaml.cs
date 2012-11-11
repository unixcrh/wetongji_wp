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
using System.Windows.Navigation;
using System.Windows.Controls.Primitives;
using System.Diagnostics;

namespace WeTongji
{
    public partial class EditPersonalInfo : PhoneApplicationPage
    {
        private UserCenterViewModel _vm = new UserCenterViewModel()
        {
            Tel = "13900000000",
            Email = "wetongji@tongji.edu.cn",
            QQ = "1234567890",
            SinaMicroBlog = "王微博尼微博玛微博"
        };

        public EditPersonalInfo()
        {
            InitializeComponent();

            this.DataContext = _vm;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/UserCenter.xaml", UriKind.Relative));
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/UserCenter.xaml", UriKind.Relative));
        }
    }
}