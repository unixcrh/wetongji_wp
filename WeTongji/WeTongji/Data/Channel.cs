using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WeTongji.Data
{
    public class Channel : INotifyPropertyChanged
    {
        #region [Field]

        private int _id;

        private String _title;

        private String _image;

        private int _follow;

        private String _description;

        #endregion

        #region [Const Property Name]

        private const String Property_Id = "Id";

        private const String Property_Title = "Title";

        private const String Property_Image = "Image";

        private const String Property_Follow = "Follow";

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

        public String Image
        {
            get { return _image; }
            set
            {
                if (_image != value)
                {
                    _image = value;
                    NotifyPropertyChanged(_image);
                }
            }
        }

        public int Follow
        {
            get{return _follow;}
            set
            {
                if(_follow!=value)
                {
                    _follow = value;
                    NotifyPropertyChanged(Property_Follow);
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

        public Channel() { }

        public Channel(JToken token)
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
                                    case Property_Description:
                                        Description = (String)property.Value;
                                        break;
                                    case Property_Id:
                                        Id = (int)property.Value;
                                        break;
                                    case Property_Title:
                                        Title = (String)property.Value;
                                        break;
                                    case Property_Image:
                                        Image = (String)property.Value;
                                        break;
                                    case Property_Follow:
                                        Follow = (int)property.Value;
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
