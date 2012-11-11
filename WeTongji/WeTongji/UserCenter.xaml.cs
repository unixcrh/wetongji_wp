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

namespace WeTongji
{
    public sealed class UserCenterViewModel : INotifyPropertyChanged
    {
        #region [Field]

        #region [Basic]

        /// <summary>
        /// user name
        /// </summary>
        private String _name;

        /// <summary>
        /// user id
        /// </summary>
        private String _id;

        /// <summary>
        /// sex
        /// </summary>
        private string _sex;

        /// <summary>
        /// birthday
        /// </summary>
        private DateTime _birthday = DateTime.MinValue;

        #endregion

        #region [Education]

        /// <summary>
        /// start year
        /// </summary>
        private string _startYear;

        /// <summary>
        /// education span
        /// </summary>
        private int _eduSpan;

        /// <summary>
        /// school
        /// </summary>
        private string _school;

        /// <summary>
        /// major
        /// </summary>
        private string _major;

        #endregion

        #region [SNS]

        /// <summary>
        /// telephone
        /// </summary>
        private string _tel;

        /// <summary>
        /// email
        /// </summary>
        private string _email;

        /// <summary>
        /// qq
        /// </summary>
        private string _qq;

        /// <summary>
        /// sina micro blog
        /// </summary>
        private string _sina;

        #endregion

        #endregion

        #region [Properties]

        #region [Basic]

        /// <summary>
        /// name
        /// </summary>
        public String Name
        {
            get { return _name; }
            set
            {
                if (value != _name)
                {
                    _name = value;
                    NotifyPropertyChanged("Name");
                }
            }
        }

        /// <summary>
        /// Id
        /// </summary>
        public String Id
        {
            get { return _id; }
            set
            {
                if (value != _id)
                {
                    _id = value;
                    NotifyPropertyChanged("Id");
                }
            }
        }

        /// <summary>
        /// sex
        /// </summary>
        public String Sex
        {
            get { return _sex; }
            set
            {
                if (value != _sex)
                {
                    _sex = value;
                    NotifyPropertyChanged("Sex");
                }
            }
        }

        /// <summary>
        /// birthday
        /// </summary>
        public String Birthday
        {
            get
            {
                return String.Format("{0:D4}年{1:D2}月{2:D2}日", _birthday.Year, _birthday.Month, _birthday.Day);
            }
            set
            {
                var strings = value.Split('-');
                int y,m,d;
                Int32.TryParse(strings.ElementAt(0), out y);
                Int32.TryParse(strings.ElementAt(1), out m);
                Int32.TryParse(strings.ElementAt(2), out d);
                if (_birthday.Year!=y || _birthday.Month!=m || _birthday.Day!=d)
                {
                    _birthday = new DateTime(y,m,d);
                    NotifyPropertyChanged("Birthday");
                }
            }
        }

        #endregion

        #region [Education]

        /// <summary>
        /// start year
        /// </summary>
        public string StartYear
        {
            get { return _startYear; }
            set
            {
                if (value != _startYear)
                {
                    _startYear = value;
                    NotifyPropertyChanged("StartYear");
                }
            }
        }

        /// <summary>
        /// education span
        /// </summary>
        public int EduSpan
        {
            get { return _eduSpan; }
            set
            {
                if (value != _eduSpan)
                {
                    _eduSpan = value;
                    NotifyPropertyChanged("EduSpan");
                }
            }
        }

        /// <summary>
        /// school
        /// </summary>
        public string School
        {
            get { return _school; }
            set
            {
                if (value != _school)
                {
                    _school = value;
                    NotifyPropertyChanged("School");
                }
            }
        }

        /// <summary>
        /// major
        /// </summary>
        public string Major
        {
            get { return _major; }
            set
            {
                if (value != _major)
                {
                    _major = value;
                    NotifyPropertyChanged("Major");
                }
            }
        }

        #endregion

        #region [SNS]

        /// <summary>
        /// telephone
        /// </summary>
        public string Tel
        {
            get { return _tel; }
            set
            {
                if (value != _tel)
                {
                    _tel = value;
                    NotifyPropertyChanged("Tel");
                }
            }
        }

        /// <summary>
        /// email
        /// </summary>
        public string Email
        {
            get { return _email; }
            set
            {
                if (value != _email)
                {
                    _email = value;
                    NotifyPropertyChanged("Email");
                }
            }
        }

        /// <summary>
        /// qq
        /// </summary>
        public string QQ
        {
            get { return _qq; }
            set
            {
                if (value != _qq)
                {
                    _qq = value;
                    NotifyPropertyChanged("QQ");
                }
            }
        }

        /// <summary>
        /// sina micro blog
        /// </summary>
        public string SinaMicroBlog
        {
            get { return _sina; }
            set
            {
                if (value != _sina)
                {
                    _sina = value;
                    NotifyPropertyChanged("SinaMicroBlog");
                }
            }
        }

        #endregion

        #endregion

        #region [PropertyChanged Event members]

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }


    public partial class UserCenter : PhoneApplicationPage
    {
        private UserCenterViewModel _vm = new UserCenterViewModel()
        {
            Name = "阿不都肉索里·阿不力孜·伊玛尼",
            Id = "090000",
            Birthday = "1990-01-01",
            Sex = "男",
            StartYear = "2009",
            EduSpan = 4,
            School = "软件学院",
            Major = "软件工程（媒体艺术与科学）",
            Tel = "13900000000",
            Email = "wetongji@tongji.edu.cn",
            QQ = "1234567890",
            SinaMicroBlog = "王微博尼微博玛微博"
        };

        public UserCenter()
        {
            InitializeComponent();

            this.DataContext = _vm;
        }

        private void Button_Edit_Click(object sender, EventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/EditPersonalInfo.xaml", UriKind.Relative));
        }
    }
}