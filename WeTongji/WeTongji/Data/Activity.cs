using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WeTongji.Data
{
    public class Activity : INotifyPropertyChanged
    {
        #region [Field]

        private int _id;

        private DateTime _begin;

        private DateTime _end;

        private String _title;

        private String _location;

        private int _favorite;

        private int _like;

        private int _schedule;

        private bool _canFavorite;

        private bool _canLike;

        private int _channelId;

        private bool _canSchedule;

        private String _organizer;

        private String _organizerAvatar;

        private String _status;

        private String _image;

        private String _description;

        private DateTime _createdAt;

        #endregion

        #region [Const Property Name]

        private const String Property_Id = "Id";

        private const String Property_Begin = "Begin";

        private const String Property_End = "End";

        private const String Property_Title = "Title";

        private const String Property_Location = "Location";

        private const String Property_Favorite = "Favorite";

        private const String Property_Like = "Like";

        private const String Property_Schedule = "Schedule";

        private const String Property_CanFavorite = "CanFavorite";

        private const String Property_CanLike = "CanLike";

        private const String Property_Channel_Id = "Channel_Id";

        private const String Property_CanSchedule = "CanSchedule";

        private const String Property_Organizer = "Organizer";

        private const String Property_OrganizerAvatar = "OrganizerAvatar";

        private const String Property_Status = "Status";

        private const String Property_Image = "Image";

        private const String Property_Description = "Description";

        private const String Property_CreatedAt = "CreatedAt";

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

        public int Favorite
        {
            get { return _favorite; }
            set
            {
                if (_favorite != value)
                {
                    _favorite = value;
                    NotifyPropertyChanged(Property_Favorite);
                }
            }
        }

        public int Like
        {
            get { return _like; }
            set
            {
                if (_like != value)
                {
                    _like = value;
                    NotifyPropertyChanged(Property_Like);
                }
            }
        }

        public int Schedule
        {
            get { return _schedule; }
            set
            {
                if (_schedule != value)
                {
                    _schedule = value;
                    NotifyPropertyChanged(Property_Schedule);
                }
            }
        }

        public bool CanFavorite
        {
            get { return _canFavorite; }
            set
            {
                if (value != _canFavorite)
                {
                    _canFavorite = value;
                    NotifyPropertyChanged(Property_CanFavorite);
                }
            }
        }

        public bool CanLike
        {
            get { return _canLike; }
            set
            {
                if (value != _canLike)
                {
                    _canLike = value;
                    NotifyPropertyChanged(Property_CanLike);
                }
            }
        }

        public int Channel_Id
        {
            get { return _channelId; }
            set
            {
                if (value != _channelId)
                {
                    _channelId = value;
                    NotifyPropertyChanged(Property_Channel_Id);
                }
            }
        }

        public bool CanSchedule
        {
            get { return _canSchedule; }
            set
            {
                if (value != _canSchedule)
                {
                    _canSchedule = value;
                    NotifyPropertyChanged(Property_CanSchedule);
                }
            }
        }

        public String Organizer
        {
            get { return _organizer; }
            set
            {
                if (value != _organizer)
                {
                    _organizer = value;
                    NotifyPropertyChanged(Property_Organizer);
                }
            }
        }

        public String OrganizerAvatar
        {
            get { return _organizerAvatar; }
            set
            {
                if (value != _organizerAvatar)
                {
                    _organizerAvatar = value;
                    NotifyPropertyChanged(Property_OrganizerAvatar);
                }
            }
        }

        public String Status
        {
            get { return _status; }
            set
            {
                if (_status != value)
                {
                    _status = value;
                    NotifyPropertyChanged(Property_Status);
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

        public DateTime CreatedAt
        {
            get { return _createdAt; }
            set
            {
                if (value != _createdAt)
                {
                    _createdAt = value;
                    NotifyPropertyChanged(Property_CreatedAt);
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

        public Activity() { }

        public Activity(JToken token)
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
                                    case Property_Favorite:
                                        Favorite = (int)property.Value;
                                        break;
                                    case Property_Like:
                                        Like = (int)property.Value;
                                        break;
                                    case Property_Schedule:
                                        Schedule = (int)property.Value;
                                        break;
                                    case Property_CanFavorite:
                                        CanFavorite = (bool)property.Value;
                                        break;
                                    case Property_CanLike:
                                        CanLike = (bool)property.Value;
                                        break;
                                    case Property_Channel_Id:
                                        Channel_Id = (int)property.Value;
                                        break;
                                    case Property_CanSchedule:
                                        CanSchedule = (bool)property.Value;
                                        break;
                                    case Property_Organizer:
                                        Organizer = (String)property.Value;
                                        break;
                                    case Property_OrganizerAvatar:
                                        OrganizerAvatar = (String)property.Value;
                                        break;
                                    case Property_Status:
                                        Status = (String)property.Value;
                                        break;
                                    case Property_Image:
                                        Image = (String)property.Value;
                                        break;
                                    case Property_CreatedAt:
                                        CreatedAt = (DateTime)property.Value;
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
