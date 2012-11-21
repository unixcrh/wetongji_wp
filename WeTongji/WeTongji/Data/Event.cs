using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WeTongji.Data
{
    public class Event : INotifyPropertyChanged
    {
        #region [Field]

        private int _id;

        private DateTime _begin;

        private DateTime _end;

        private String _title;

        private String _location;

        private String _description;

        #endregion

        #region [Const Property Name]

        private const String Property_Id = "Id";

        private const String Property_Begin = "Begin";

        private const String Property_End = "End";

        private const String Property_Title = "Title";

        private const String Property_Location = "Location";

        private const String Property_Description = "Description";

        #endregion

        #region [Property]

        public int Id
        {
            get { return _id; }
            set
            {
                if (value != _id)
                {
                    _id = value;
                    NotifyPropertyChanged(Property_Id);
                }
            }
        }

        public DateTime Begin
        {
            get { return _begin; }
            set
            {
                if (_begin != value)
                {
                    _begin = value;
                    NotifyPropertyChanged(Property_Begin);
                }
            }
        }

        public DateTime End
        {
            get { return _end; }
            set
            {
                if (_end != value)
                {
                    _end = value;
                    NotifyPropertyChanged(Property_End);
                }
            }
        }

        public String Title
        {
            get { return _title; }
            set
            {
                if (value != _title)
                {
                    _title = value;
                    NotifyPropertyChanged(Property_Title);
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

        public String Description
        {
            get { return _description; }
            set
            {
                if (value != _description)
                {
                    _description = value;
                    NotifyPropertyChanged(Property_Description);
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

        public Event() { }

        public Event(JToken token)
        {
            if (token is JContainer)
            {
                var jContainer = token as JContainer;
                foreach (JToken item in jContainer.Children())
                {
                    if (item is JProperty)
                    {
                        var jProperty = item as JProperty;

                        if (jProperty.Name != "Event")
                            break;

                        foreach (var val in jProperty.Values())
                        {
                            if (val is JProperty)
                            {
                                var property = val as JProperty;

                                switch (property.Name)
                                {
                                    case Property_Description:
                                        Description = (String)property.Value;
                                        break;
                                    case Property_Begin:
                                        Begin = (DateTime)property.Value;
                                        break;
                                    case Property_End:
                                        End = (DateTime)property.Value;
                                        break;
                                    case Property_Id:
                                        Id = (int)property.Value;
                                        break;
                                    case Property_Location:
                                        Location = (String)property.Value;
                                        break;
                                    case Property_Title:
                                        Title = (String)property.Value;
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
