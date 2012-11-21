using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using WeTongji.Utility;


namespace WeTongji.Data
{
    public class User : INotifyPropertyChanged
    {
        #region [Field]

        private String _no;

        private String _name;

        private String _avatar;

        private String _uid;

        private String _phone;

        private String _displayName;

        private String _major;

        private String _nativePlace;

        private String _degree;

        private String _gender;

        private String _year;

        private DateTime _birthday;

        private String _plan;

        private String _sinaWeibo;

        private String _qq;

        private String _department;

        private String _email;

        #endregion

        #region [Readonly]

        private const String Property_NO = "NO";

        private const String Property_Name = "Name";

        private const String Property_Avatar = "Avatar";

        private const String Property_UID = "UID";

        private const String Property_Phone = "Phone";

        private const String Property_DisplayName = "DisplayName";

        private const String Property_Major = "Major";

        private const String Property_NativePlace = "NativePlace";

        private const String Property_Degree = "Degree";

        private const String Property_Gender = "Gender";

        private const String Property_Year = "Year";

        private const String Property_Birthday = "Birthday";

        private const String Property_Plan = "Plan";

        private const String Property_SinaWeibo = "SinaWeibo";

        private const String Property_QQ = "QQ";

        private const String Property_Department = "Department";

        private const String Property_Email = "Email";

        #endregion

        #region [Properties]

        public String NO
        {
            get { return _no; }
            set
            {
                if (value != _no)
                {
                    _no = value;
                    NotifyPropertyChanged(Property_NO);
                }
            }
        }

        public String Name
        {
            get { return _name; }
            set
            {
                if (value != _name)
                {
                    _name = value;
                    NotifyPropertyChanged(Property_Name);
                }
            }
        }

        public String Avatar
        {
            get { return _avatar; }
            set
            {
                if (value != _avatar)
                {
                    _avatar = value;
                    NotifyPropertyChanged(Property_Avatar);
                }
            }
        }

        public String UID
        {
            get { return _uid; }
            set
            {
                if (_uid != value)
                {
                    _uid = value;
                    NotifyPropertyChanged(Property_UID);
                }
            }
        }

        public String Phone
        {
            get { return _phone; }
            set
            {
                if (_phone != value)
                {
                    _phone = value;
                    NotifyPropertyChanged(Property_Phone);
                }
            }
        }

        public String DisplayName
        {
            get { return _displayName; }
            set
            {
                if (value != _displayName)
                {
                    _displayName = value;
                    NotifyPropertyChanged(Property_DisplayName);
                }
            }
        }

        public String Major
        {
            get { return _major; }
            set
            {
                if (value != _major)
                {
                    _major = value;
                    NotifyPropertyChanged(Property_Major);
                }
            }
        }

        public String NativePlace
        {
            get
            {
                return _nativePlace;
            }
            set
            {
                if (value != _nativePlace)
                {
                    _nativePlace = value;
                    NotifyPropertyChanged(Property_NativePlace);
                }
            }
        }

        public String Degree
        {
            get { return _degree; }
            set
            {
                if (value != _degree)
                {
                    _degree = value;
                    NotifyPropertyChanged(Property_Degree);
                }
            }
        }

        public String Gender
        {
            get { return _gender; }
            set
            {
                if (value != _gender)
                {
                    _gender = value;
                    NotifyPropertyChanged(Property_Gender);
                }
            }
        }

        public String Year
        {
            get { return _year; }
            set
            {
                if (_year != value)
                {
                    _year = value;
                    NotifyPropertyChanged(Property_Year);
                }
            }
        }

        public DateTime Birthday
        {
            get { return _birthday; }
            set
            {
                if (_birthday != value)
                {
                    _birthday = value;
                    NotifyPropertyChanged(Property_Birthday);
                }
            }
        }

        public String Plan
        {
            get { return _plan; }
            set
            {
                if (value != _plan)
                {
                    _plan = value;
                    NotifyPropertyChanged(Property_Plan);
                }
            }
        }

        public String SinaWeibo
        {
            get { return _sinaWeibo; }
            set
            {
                if (value != _sinaWeibo)
                {
                    _sinaWeibo = value;
                    NotifyPropertyChanged(Property_SinaWeibo);
                }
            }
        }

        public String QQ
        {
            get { return _qq; }
            set
            {
                if (value != _qq)
                {
                    _qq = value;
                    NotifyPropertyChanged(Property_QQ);
                }
            }
        }

        public String Department
        {
            get { return _department; }
            set
            {
                if (value != _department)
                {
                    _department = value;
                    NotifyPropertyChanged(Property_Department);
                }
            }
        }

        public String Email
        {
            get { return _email; }
            set
            {
                if (value != _email)
                {
                    _email = value;
                    NotifyPropertyChanged(Property_Email);
                }
            }
        }

        #endregion

        #region [Property Changed]

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String param)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(param));
            }
        }

        #endregion

        #region [Constructor]

        public User() { }

        public User(JToken  token) 
        {
            if (token is JContainer)
            {
                var jContainer = token as JContainer;
                foreach (JToken item in jContainer.Children())
                {
                    if (item is JProperty)
                    {
                        var jProperty = item as JProperty;

                        if (jProperty.Name != "User")
                            break;

                        foreach (var val in jProperty.Values())
                        {
                            if (val is JProperty)
                            {
                                var property = val as JProperty;

                                switch (property.Name)
                                {
                                    case Property_NO:
                                        NO = (String)property.Value;
                                        break;
                                    case Property_Name:
                                        Name = (String)property.Value;
                                        break;
                                    case Property_Avatar:
                                        Avatar = (String)property.Value;
                                        break;
                                    case Property_Birthday:
                                        Birthday = (DateTime)property.Value;
                                        break;
                                    case Property_Degree:
                                        Degree = (String)property.Value;
                                        break;
                                    case Property_Department:
                                        Department = (String)property.Value;
                                        break;
                                    case Property_DisplayName:
                                        DisplayName = (String)property.Value;
                                        break;
                                    case Property_Email:
                                        Email = (String)property.Value;
                                        break;
                                    case Property_Gender:
                                        Gender = (String)property.Value;
                                        break;
                                    case Property_Major:
                                        Major = (String)property.Value;
                                        break;
                                    case Property_NativePlace:
                                        NativePlace = (String)property.Value;
                                        break;
                                    case Property_Phone:
                                        Phone = (String)property.Value;
                                        break;
                                    case Property_Plan:
                                        Plan = (String)property.Value;
                                        break;
                                    case Property_QQ:
                                        QQ = (String)property.Value;
                                        break;
                                    case Property_SinaWeibo:
                                        SinaWeibo = (String)property.Value;
                                        break;
                                    case Property_UID:
                                        UID = (String)property.Value;
                                        break;
                                    case Property_Year:
                                        Year = (String)property.Value;
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                    }


                }
            }
        }

        #endregion
    }
}
