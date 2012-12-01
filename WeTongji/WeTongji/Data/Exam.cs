using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WeTongji.Data
{
    public class Exam : INotifyPropertyChanged
    {
        #region [Field]

        private String _no;

        private String _name;

        private String _teacher;

        private String _location;

        private DateTime _begin;

        private DateTime _end;

        private float _point;

        private bool _required;

        private int _hours;
        
        #endregion

        #region [Const Property Name]

        private const String Property_NO = "NO";

        private const String Property_Name = "Name";

        private const String Property_Teacher = "Teacher";

        private const String Property_Location = "Location";

        private const String Property_Begin = "Begin";

        private const String Property_End = "End";

        private const String Property_Point = "Point";

        private const String Property_Required = "Required";

        private const String Property_Hours = "Hours";

        #endregion

        #region [Property]

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

        public String Teacher
        {
            get { return _teacher; }
            set
            {
                if (_teacher != value)
                {
                    _teacher = value;
                    NotifyPropertyChanged(Property_Teacher);
                }
            }
        }

        public String Location
        {
            get { return _location; }
            set
            {
                if (_location != value)
                {
                    _location = value;
                    NotifyPropertyChanged(Property_Location);
                }
            }
        }

        public DateTime Begin
        {
            get { return _begin; }
            set
            {
                if (value != _begin)
                {
                    _begin = value;
                    NotifyPropertyChanged(Property_Begin);
                }
            }
        }

        public DateTime End
        {
            get{return _end;}
            set
            {
                if(value!=_end)
                {
                    _end = value;
                    NotifyPropertyChanged(Property_End);
                }
            }
        }

        public float Point
        {
            get{return _point;}
            set
            {
                if(value!=_point)
                {
                    _point = value;
                    NotifyPropertyChanged(Property_Point);
                }
            }
        }

        public bool Required
        {
            get{return _required;}
            set
            {
                if(value!=_required)
                {
                    _required = value;
                    NotifyPropertyChanged(Property_Required);
                }
            }
        }

        public int Hours
        {
            get{return _hours;}
            set
            {
                if(value!=_hours)
                {
                    _hours = value;
                    NotifyPropertyChanged(Property_Hours);
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

        public Exam() { }

        public Exam(JToken token)
        {
            if (token is JContainer)
            {
                var jContainer = token as JContainer;
                foreach (JToken item in jContainer.Children())
                {
                    if (item is JProperty)
                    {
                        var jProperty = item as JProperty;

                        if (jProperty.Name != "Activity")
                            break;

                        foreach (var val in jProperty.Values())
                        {
                            if (val is JProperty)
                            {
                                var property = val as JProperty;

                                switch (property.Name)
                                {
                                    case Property_Begin:
                                        Begin = (DateTime)property.Value;
                                        break;
                                    case Property_End:
                                        End = (DateTime)property.Value;
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
                                    case Property_NO:
                                        NO = (String)property.Value;
                                        break;
                                    case Property_Point:
                                        Point = (float)property.Value;
                                        break;
                                    case Property_Required:
                                        Required = (bool)property.Value;
                                        break;
                                    case Property_Teacher:
                                        Teacher = (String)property.Value;
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
