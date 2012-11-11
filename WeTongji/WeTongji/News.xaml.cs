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
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Data;
using System.Globalization;

namespace WeTongji
{
    public class NewsTypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is NewsType)
            {
                NewsType nt = (NewsType)value;
                string result = "";

                switch (nt)
                {
                    case NewsType.CampusNews:
                        result = "校园动态";
                        break;
                    case NewsType.CampusNote:
                        result = "校务通知";
                        break;
                    case NewsType.CampusRecruiment:
                        result = "校园招聘";
                        break;
                    case NewsType.ProductGuide:
                        result = "产品说明";
                        break;
                    case NewsType.ProductUpdate:
                        result = "产品更新";
                        break;
                    case NewsType.SolicitContribution:
                        result = "校园征稿";
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Invalid News Type.");
                }

                return result;
            }
            else
                throw new ArgumentOutOfRangeException("Unexpected type");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public enum NewsType : byte
    {
        ProductUpdate,
        CampusNews,
        CampusRecruiment,
        CampusNote,
        ProductGuide,
        SolicitContribution
    }


    public class NewsItemViewModel : INotifyPropertyChanged
    {
        #region [Field]

        private String _title;

        private NewsType _type;

        private DateTime _time;

        #endregion

        #region [Properties]

        public String Title
        {
            get { return _title; }
            set
            {
                if (_title != value)
                {
                    _title = value;
                    NotifyPropertyChanged("Title");
                }
            }
        }

        public String Type
        {
            get
            {
                string result = "";

                switch (_type)
                {
                    case NewsType.CampusNews:
                        result = "校园动态";
                        break;
                    case NewsType.CampusNote:
                        result = "校务通知";
                        break;
                    case NewsType.CampusRecruiment:
                        result = "校园招聘";
                        break;
                    case NewsType.ProductGuide:
                        result = "产品说明";
                        break;
                    case NewsType.ProductUpdate:
                        result = "产品更新";
                        break;
                    case NewsType.SolicitContribution:
                        result = "校园征稿";
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Invalid News Type.");
                }
                return result;
            }
        }

        public NewsType SetType
        {
            set
            {
                if (value != _type)
                {
                    _type = value;
                    NotifyPropertyChanged("Type");
                }
            }
        }

        public String Time
        {
            get
            {
                return string.Format("发表于 {0:yyyy}年{0:MM}月{0:dd}日", _time);
            }
        }

        public DateTime SetTime
        {
            set
            {
                if (_time != value)
                {
                    _time = value;
                    NotifyPropertyChanged("Time");
                }
            }
        }

        #endregion

        #region [PropertyChanged Members]

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String propertyName)
        {
            var temp = PropertyChanged;
            if (temp != null)
                temp(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }

    public class NewsViewModel
    {
        private ObservableCollection<NewsItemViewModel> _items = new ObservableCollection<NewsItemViewModel>();

        public ObservableCollection<NewsItemViewModel> Items
        {
            get { return _items; }
            set { _items = value; }
        }
    }


    public partial class News : PhoneApplicationPage
    {
        private NewsViewModel _viewModel = new NewsViewModel();

        public News()
        {
            InitializeComponent();


            NewsItemViewModel nvm;

            nvm = new NewsItemViewModel()
            {
                Title = "My Title One",
                SetTime = DateTime.Now,
                SetType = NewsType.CampusNews
            };
            _viewModel.Items.Add(nvm);

            nvm = new NewsItemViewModel()
            {
                Title = "My Title Two",
                SetTime = DateTime.Now,
                SetType = NewsType.CampusNote
            };
            _viewModel.Items.Add(nvm);

            nvm = new NewsItemViewModel()
            {
                Title = "My Title Three",
                SetTime = DateTime.Now,
                SetType = NewsType.CampusRecruiment
            };
            _viewModel.Items.Add(nvm);

            nvm = new NewsItemViewModel()
            {
                Title = "My Title Four",
                SetTime = DateTime.Now,
                SetType = NewsType.ProductGuide
            };
            _viewModel.Items.Add(nvm);

            ListBox_News.ItemsSource = _viewModel.Items;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/NewsContent.xaml", UriKind.Relative));
        }
    }
}