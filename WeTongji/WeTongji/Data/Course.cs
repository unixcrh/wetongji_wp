using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WeTongji.Data
{
    public class Course : INotifyPropertyChanged
    {
        #region [Field]

        private String _no;

        private int _hours;

        private float _point;

        private String _name;

        private String _teacher;

        private String _weekType;

        private String _weekDay;

        private int _sectionStart;

        private int _sectionEnd;

        private bool _required;

        private String _location;

        #endregion

        #region [Const Property Name]

        private const String Property_NO = "NO";

        private const String Property_Hours = "Hours";

        private const String Property_Point = "Point";

        private const String Property_Name = "Name";

        private const String Property_Teacher = "Teacher";

        private const String Property_WeekType = "WeekType";

        private const String Property_WeekDay = "WeekDay";

        private const String Property_SectionStart = "SectionStart";

        private const String Property_SectionEnd = "SectionEnd";

        private const String Property_Required = "Required";

        private const String Property_Location = "Location";

        #endregion

        #region [Property]

        public String NO
        {
            get { return _no; }
            set
            {
                if (_no != value)
                {
                    _no = value;
                    NotifyPropertyChanged(Property_NO);
                }
            }
        }

        public int Hours
        {
            get { return _hours; }
            set
            {
                if (_hours != value)
                {
                    _hours = value;
                    NotifyPropertyChanged(Property_Hours);
                }
            }
        }

        public float Point
        {
            get { return _point; }
            set
            {
                if (_point != value)
                {
                    _point = value;
                    NotifyPropertyChanged(Property_Point);
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

        public String Teacher
        {
            get { return _teacher; }
            set
            {
                if (value != _teacher)
                {
                    _teacher = value;
                    NotifyPropertyChanged(Property_Teacher);
                }
            }
        }


        public String WeekType
        {
            get { return _weekType; }
            set
            {
                if (value != _weekType)
                {
                    _weekType = value;
                    NotifyPropertyChanged(Property_WeekType);
                }
            }
        }

        public String WeekDay
        {
            get { return _weekDay; }
            set
            {
                if (value != _weekDay)
                {
                    _weekDay = value;
                    NotifyPropertyChanged(Property_WeekDay);
                }
            }
        }

        public int SectionStart
        {
            get { return _sectionStart; }
            set
            {
                if (value != _sectionStart)
                {
                    _sectionStart = value;
                    NotifyPropertyChanged(Property_SectionStart);
                }
            }
        }

        public int SectionEnd
        {
            get { return _sectionEnd; }
            set
            {
                if (value != _sectionEnd)
                {
                    _sectionEnd = value;
                    NotifyPropertyChanged(Property_SectionEnd);
                }
            }
        }

        public bool Required
        {
            get { return _required; }
            set
            {
                if (value != _required)
                {
                    _required = value;
                    NotifyPropertyChanged(Property_Required);
                }
            }
        }

        public String Location
        {
            get { return _location; }
            set
            {
                if (value != _location)
                {
                    _location = value;
                    NotifyPropertyChanged(Property_Location);
                }
            }
        }

        #endregion

        #region [Construction]

        public Course() { }

        public Course(JToken token) 
        {
            if (token is JContainer)
            {
                var jContainer = token as JContainer;
                foreach (JToken item in jContainer.Children())
                {
                    if (item is JProperty)
                    {
                        var jProperty = item as JProperty;

                        if (jProperty.Name != "Course")
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
                                    case Property_Hours:
                                        Hours = (int)property.Value;
                                        break;
                                    case Property_Location:
                                        Location = (String)property.Value;
                                        break;
                                    case Property_Name:
                                        Name = (String)property.Value;
                                        break;
                                    case Property_Point:
                                        Point = (float)property.Value;
                                        break;
                                    case Property_Required:
                                        Required = (bool)property.Value;
                                        break;
                                    case Property_SectionEnd:
                                        SectionEnd = (int)property.Value;
                                        break;
                                    case Property_SectionStart:
                                        SectionStart = (int)property.Value;
                                        break;
                                    case Property_Teacher:
                                        Teacher = (String)property.Value;
                                        break;
                                    case Property_WeekDay:
                                        WeekDay = (String)property.Value;
                                        break;
                                    case Property_WeekType:
                                        WeekDay = (String)property.Value;
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
    }
}
