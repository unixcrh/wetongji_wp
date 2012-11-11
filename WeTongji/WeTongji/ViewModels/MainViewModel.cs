using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Collections.ObjectModel;
using System.Windows.Navigation;


namespace WeTongji
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<AppSquareItem> _appSquareItems = null;

        public MainViewModel()
        {
            _appSquareItems = new ObservableCollection<AppSquareItem>();

            AppSquareItem item = null;

            //...Activities
            item = new AppSquareItem("./Images/AppSquare/activities_icon.png", "活动推荐", "Activities");
            _appSquareItems.Add(item);

            //...News
            item = new AppSquareItem("./Images/AppSquare/news_icon.png", "同济新闻", "News");
            _appSquareItems.Add(item);

            //...Schedule
            item = new AppSquareItem("./Images/AppSquare/schedule_icon.png", "日程管理", "Schedule");
            _appSquareItems.Add(item);

            //...Favorite
            item = new AppSquareItem("./Images/AppSquare/favorite_icon.png", "我的收藏", "Favorite");
            _appSquareItems.Add(item);

            //...User center
            item = new AppSquareItem("./Images/AppSquare/user_center_icon.png", "个人信息", "UserCenter");
            _appSquareItems.Add(item);

            //...Guide book
            item = new AppSquareItem("./Images/AppSquare/guide_book_icon.png", "新生指南", "FreshmanGuide");
            _appSquareItems.Add(item);

        }

        public void SetNavigationService(NavigationService ns)
        {
            if (null != _appSquareItems)
            {
                var temp = new ObservableCollection<AppSquareItem>();
                foreach (var item in _appSquareItems)
                {
                    AppSquareItem asi = item;
                    asi.SetNavigationService = ns;
                    temp.Add(asi);
                }
                _appSquareItems = temp;
            }
        }

        public ObservableCollection<AppSquareItem> AppSquareItems
        {
            get
            {
                return _appSquareItems;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
